using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public class ResetChanceComponent : IComponent
    {
        // This internal component does the actual heavy lifting. Whenever we want to do something
        // like display text, we will call the appropriate function on the internal component.
        protected InfoTextComponent InternalComponent { get; set; }
        // This is how we will access all the settings that the user has set.
        public ResetChanceSettings Settings { get; set; }
        // This object contains all of the current information about the splits, the timer, etc.
        protected LiveSplitState CurrentState { get; set; }

        public string ComponentName => "Reset Chance";

        // The list containing all the calculated reset chances for each split.
        protected List<float> ResetChances { get; set; }
        // The reset chance of the current split.
        protected float CurrentResetChance { get; set; }
        protected bool ResetChancesValid { get; set; }
        protected bool CurrentSplitValid { get; set; }

        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingRight => InternalComponent.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;

        // This function is called when LiveSplit creates your component. This happens when the
        // component is added to the layout, or when LiveSplit opens a layout with this component
        // already added.
        public ResetChanceComponent(LiveSplitState state)
        {
            Settings = new ResetChanceSettings();
            InternalComponent = new InfoTextComponent("Reset Chance", "0%");

            state.OnStart += state_OnStart;
            state.OnSplit += state_OnSplitChange;
            state.OnSkipSplit += state_OnSplitChange;
            state.OnUndoSplit += state_OnSplitChange;
            state.OnReset += state_OnReset;
            CurrentState = state;

            ResetChancesValid = false;
            CurrentSplitValid = false;
        }

        private void state_OnStart(object sender, EventArgs e)
        {
            // Invalidate the list of reset chances so we can recalculate them.
            ResetChancesValid = false;
            // Invalidate the current split, so we recalculate the current split.
            CurrentSplitValid = false;
        }

        private void state_OnSplitChange(object sender, EventArgs e)
        {
            // Invalidate the current split, so we recalculate the current split.
            CurrentSplitValid = false;
        }

        private void state_OnReset(object sender, TimerPhase e)
        {
            // Invalidate the current split, so we recalculate the current split.
            CurrentSplitValid = false;
        }

        private void DrawBackground(Graphics g, LiveSplitState state, float width, float height)
        {
            if (Settings.BackgroundColor.A > 0
                || Settings.BackgroundGradient != GradientType.Plain
                && Settings.BackgroundColor2.A > 0)
            {
                var gradientBrush = new LinearGradientBrush(
                            new PointF(0, 0),
                            Settings.BackgroundGradient == GradientType.Horizontal
                            ? new PointF(width, 0)
                            : new PointF(0, height),
                            Settings.BackgroundColor,
                            Settings.BackgroundGradient == GradientType.Plain
                            ? Settings.BackgroundColor
                            : Settings.BackgroundColor2);
                g.FillRectangle(gradientBrush, 0, 0, width, height);
            }
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            DrawBackground(g, state, HorizontalWidth, height);

            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = Settings.OverrideTextColor ? Settings.TextColor : state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = Settings.OverrideChanceColor ? Settings.ChanceColor : state.LayoutSettings.TextColor;

            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            DrawBackground(g, state, width, VerticalHeight);

            InternalComponent.DisplayTwoRows = Settings.Display2Rows;

            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = Settings.OverrideTextColor ? Settings.TextColor : state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = Settings.OverrideChanceColor ? Settings.ChanceColor : state.LayoutSettings.TextColor;

            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }
        
        private int getCompletionsAboveMinRunId(ISegment segment, int minRunId)
        {
            if (minRunId == 0)
            {
                return segment.SegmentHistory.Count;
            }

            int numCompletions = 0;
            foreach (var id in segment.SegmentHistory.Keys)
            {
                if (id >= minRunId)
                    numCompletions++;
            }
            return numCompletions;
        }

        private List<float> resetChancesForAllRuns(LiveSplitState state)
        {
            List<float> chances = new List<float>();

            for (int segmentIndex = 0; segmentIndex < state.Run.Count(); segmentIndex++)
            {
                float numCompletions = state.Run[segmentIndex].SegmentHistory.Count;
                // For the first segment, the number of attempts is the number of overall run
                // attempts. Otherwise, it's the number of completions for the previous split.
                float numAttempts = segmentIndex == 0
                    ? state.Run.AttemptHistory.Count
                    : state.Run[segmentIndex - 1].SegmentHistory.Count;

                // We'll use -1 as an initial value.
                float resetChance = -1;
                if (numCompletions > 0 && numAttempts > 0)
                {
                    resetChance = (float)((1 - (numCompletions / numAttempts)) * 100.0);
                }
                chances.Add(resetChance);
            }

            return chances;
        }

        private List<float> resetChancesForSubsetOfRuns(LiveSplitState state)
        {
            // This minimum run ID will determine which run attempts and run completions can be
            // used in the calculation.
            int minRunId = Math.Max(0, state.Run.AttemptHistory.Count + 1 - Settings.BasisSubset);

            // Determine how many completed attempts each segment has above the minimum run ID.
            List<int> completedSplits = new List<int>();
            for (int segmentIndex = 0; segmentIndex < state.Run.Count(); segmentIndex++)
            {
                int numCompletions = getCompletionsAboveMinRunId(state.Run[segmentIndex], minRunId);
                completedSplits.Add(numCompletions);
            }
            List<float> chances = new List<float>();

            for (int segmentIndex = 0; segmentIndex < state.Run.Count(); segmentIndex++)
            {
                float numCompletions = completedSplits[segmentIndex];

                float numAttempts = segmentIndex == 0
                    // If this is the first split, we get the specified number of runs to use, or the
                    // total number of run attempts, whichever is smaller.
                    ? Math.Min(state.Run.AttemptHistory.Count, Settings.BasisSubset)
                    // Otherwise, it's the number of completions on the previous split that are above
                    // our minimum run ID.
                    : completedSplits[segmentIndex - 1];
                // We'll use -1 as an initial value.
                float resetChance = -1;
                if (numCompletions > 0 && numAttempts > 0)
                {
                    resetChance = (float)((1 - (numCompletions / numAttempts)) * 100.0);
                }
                chances.Add(resetChance);
            }

            return chances;
        }

        private List<float> resetChancesForSubsetOfSplitAttempts(LiveSplitState state)
        {
            List<int> numCompletionsList = new List<int>();
            List<int> minRunIds = new List<int>();

            // For each split, determine the number of attempts at that split (which may be smaller
            // than intended) and the minimum run ID for that segment.
            for (int segmentIndex = 0; segmentIndex < state.Run.Count(); segmentIndex++)
            {
                ISegment currentSegment = state.Run[segmentIndex];
                // If this split has been completed fewer times than the basis for the calculation,
                // just indicate how many completions there were. The minimum run ID will be set to
                // 0, so the next split can look at all attempts.
                if (currentSegment.SegmentHistory.Count <= Settings.BasisSubsetSplits)
                {
                    numCompletionsList.Add(currentSegment.SegmentHistory.Count);
                    minRunIds.Add(0);
                }
                else
                {
                    // Get the full list of run IDs from the previous segment, sort them, and use
                    // that to determine the minimum run ID.
                    List<int> splitIds = currentSegment.SegmentHistory.Keys.ToList<int>();
                    splitIds.Sort();
                    int minRunId = splitIds[currentSegment.SegmentHistory.Count - Settings.BasisSubsetSplits];
                    minRunIds.Add(minRunId);
                    numCompletionsList.Add(Settings.BasisSubsetSplits);
                }
            }

            List<float> chances = new List<float>();
            for (int segmentIndex = 0; segmentIndex < state.Run.Count(); segmentIndex++)
            {
                // Initialize the data for the first split.
                int minRunId = Math.Max(0, state.Run.AttemptHistory.Count + 1 - Settings.BasisSubsetSplits);
                float numAttempts = Math.Min(state.Run.AttemptHistory.Count, Settings.BasisSubsetSplits);

                // For other splits, we'll use the data we previously calculated.
                if (segmentIndex > 0)
                {
                    minRunId = minRunIds[segmentIndex - 1];
                    numAttempts = numCompletionsList[segmentIndex - 1];
                }

                // Determine how many times this split was completed, based on the minimum run ID.
                float numCompletions = getCompletionsAboveMinRunId(state.Run[segmentIndex], minRunId);

                // We'll use -1 as an initial value.
                float resetChance = -1;
                if (numCompletions > 0 && numAttempts > 0)
                {
                    resetChance = (float)((1 - (numCompletions / numAttempts)) * 100.0);
                }

                chances.Add(resetChance);
            }

            return chances;
        }

        // This is the function where we determine the chances of resetting for each individual
        // split.
        private List<float> calculateResetChances(LiveSplitState state)
        {
            if (Settings.Basis.Equals(ResetChanceSettings.ResetChanceBasis.AllRuns))
                return resetChancesForAllRuns(state);
            else if (Settings.Basis.Equals(ResetChanceSettings.ResetChanceBasis.Subset))
                return resetChancesForSubsetOfRuns(state);
            else
                return resetChancesForSubsetOfSplitAttempts(state);
        }

        // Get the current reset chance to display, taking into account the timer state.
        private float getResetChance(LiveSplitState state)
        {
            // If the timer has finished, or has been reset and not started, we won't fetch a reset
            // chance.
            bool noResetChance = state.CurrentPhase.Equals(TimerPhase.NotRunning)
                || state.CurrentPhase.Equals(TimerPhase.Ended);
            return noResetChance ? 0 : ResetChances[state.CurrentSplitIndex];
        }

        // This is the function where we decide what needs to be displayed at this moment in time,
        // and tell the internal component to display it. This function is called hundreds to
        // thousands of times per second.
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            // If necessary, recalculate the reset chances.
            if (!ResetChancesValid)
            {
                ResetChancesValid = true;
                ResetChances = calculateResetChances(state);
            }

            // If necessary, obtain the reset chance for the current split, and create a new
            // display string.
            if (!CurrentSplitValid)
            {
                CurrentSplitValid = true;
                CurrentResetChance = getResetChance(state);

                // Format with no decimal points.
                string resetChanceFormat = $"{CurrentResetChance:0}%";
                if (Settings.Accuracy.Equals(ResetChanceSettings.ResetChanceAccuracy.OneDecimal))
                {
                    // Format with up to one decimal point.
                    resetChanceFormat = Settings.ShowTrailingZeroes
                        ? $"{CurrentResetChance:0.0}%"
                        : $"{CurrentResetChance:0.#}%";
                }
                else if (Settings.Accuracy.Equals(ResetChanceSettings.ResetChanceAccuracy.TwoDecimal))
                {
                    // Format with up to two decimal points.
                    resetChanceFormat = Settings.ShowTrailingZeroes
                        ? $"{CurrentResetChance:0.00}%"
                        : $"{CurrentResetChance:0.##}%";
                }
                // If we can't make an estimate, just display "?".
                InternalComponent.InformationValue = CurrentResetChance >= 0 ? resetChanceFormat : "?";
            }

            InternalComponent.Update(invalidator, state, width, height, mode);
        }

        // This function is called when the component is removed from the layout, or when LiveSplit
        // closes a layout with this component in it.
        public void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnSplit -= state_OnSplitChange;
            CurrentState.OnSkipSplit -= state_OnSplitChange;
            CurrentState.OnUndoSplit -= state_OnSplitChange;
            CurrentState.OnReset -= state_OnReset;
        }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    }
}
