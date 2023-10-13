using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class ResetChanceFactory : IComponentFactory
    {
        // The displayed name of the component in the Layout Editor.
        public string ComponentName => "Reset Chance";

        public string Description => "Displays the likelihood of the run being reset during this split.";

        // The sub-menu this component will appear under when adding the component to the layout.
        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new ResetChanceComponent(state);

        public string UpdateName => ComponentName;

        public string UpdateURL => "https://raw.githubusercontent.com/TheSoundDefense/LiveSplit.ResetChance/master/";

        public string XMLURL => UpdateURL + "Components/update.LiveSplit.ResetChance.xml";

        public Version Version => Version.Parse("1.2.0");
    }
}
