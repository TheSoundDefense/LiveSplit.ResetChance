using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class ResetChanceSettings : UserControl
    {
        public Color TextColor { get; set; }
        public bool OverrideTextColor { get; set; }
        public Color ChanceColor { get; set; }
        public bool OverrideChanceColor { get; set; }

        public Color BackgroundColor { get; set; }
        public Color BackgroundColor2 { get; set; }
        public GradientType BackgroundGradient { get; set; }
        public string GradientString
        {
            get { return BackgroundGradient.ToString(); }
            set { BackgroundGradient = (GradientType)Enum.Parse(typeof(GradientType), value); }
        }

        public enum ResetChanceMode
        {
            ResetChance,
            SuccessChance,
            RunsEnded
        }
        public ResetChanceMode ChanceMode { get; set; }

        public enum ResetChanceAccuracy
        {
            ZeroDecimal,
            OneDecimal,
            TwoDecimal
        }
        public ResetChanceAccuracy Accuracy { get; set; }
        public bool ShowTrailingZeroes { get; set; }

        public enum ResetChanceBasis
        {
            AllRuns,
            Subset,
            SubsetSplits
        }
        public ResetChanceBasis Basis { get; set; }
        // The number used when basing the chance off a number of runs.
        public int BasisSubset { get; set; }
        // The number used when basing the chance off a number of split attempts.
        public int BasisSubsetSplits { get; set; }
        
        public bool Display2Rows { get; set; }

        public LayoutMode Mode { get; set; }
        
        public ResetChanceSettings()
        {
            InitializeComponent();

            TextColor = Color.FromArgb(255, 255, 255);
            OverrideTextColor = false;
            ChanceColor = Color.FromArgb(255, 255, 255);
            OverrideChanceColor = false;
            BackgroundColor = Color.Transparent;
            BackgroundColor2 = Color.Transparent;
            BackgroundGradient = GradientType.Plain;
            ChanceMode = ResetChanceMode.ResetChance;
            Accuracy = ResetChanceAccuracy.ZeroDecimal;
            Basis = ResetChanceBasis.AllRuns;
            BasisSubset = 100;
            BasisSubsetSplits = 50;
            Display2Rows = false;

            chkOverrideTextColor.DataBindings.Add("Checked", this, "OverrideTextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnTextColor.DataBindings.Add("BackColor", this, "TextColor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideResetColor.DataBindings.Add("Checked", this, "OverrideChanceColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnResetColor.DataBindings.Add("BackColor", this, "ChanceColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColor1.DataBindings.Add("BackColor", this, "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbGradientType.DataBindings.Add("SelectedItem", this, "GradientString", false, DataSourceUpdateMode.OnPropertyChanged);
            chkTrailingZeroes.DataBindings.Add("Checked", this, "ShowTrailingZeroes", false, DataSourceUpdateMode.OnPropertyChanged);
            basisNumericUpDown.DataBindings.Add("Value", this, "BasisSubset", false, DataSourceUpdateMode.OnPropertyChanged);
            basisSplitsNumericUpDown.DataBindings.Add("Value", this, "BasisSubsetSplits", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ResetChanceSettings_Load(object sender, EventArgs e)
        {
            chkOverrideTextColor_CheckedChanged(null, null);
            chkOverrideResetColor_CheckedChanged(null, null);

            rdoModeResetChance.Checked = ChanceMode == ResetChanceMode.ResetChance;
            rdoModeSuccessChance.Checked = ChanceMode == ResetChanceMode.SuccessChance;
            rdoModeRunsEnded.Checked = ChanceMode == ResetChanceMode.RunsEnded;

            rdoDecimalZero.Checked = Accuracy == ResetChanceAccuracy.ZeroDecimal;
            rdoDecimalOne.Checked = Accuracy == ResetChanceAccuracy.OneDecimal;
            rdoDecimalTwo.Checked = Accuracy == ResetChanceAccuracy.TwoDecimal;

            rdoBasisAllRuns.Checked = Basis == ResetChanceBasis.AllRuns;
            rdoBasisSubset.Checked = Basis == ResetChanceBasis.Subset;
            rdoBasisSubsetSplits.Checked = Basis == ResetChanceBasis.SubsetSplits;
            if (Basis == ResetChanceBasis.AllRuns)
            {
                basisNumericUpDown.Enabled = false;
                basisSplitsNumericUpDown.Enabled = false;
            }
            else if (Basis == ResetChanceBasis.Subset)
            {
                basisNumericUpDown.Enabled = true;
                basisSplitsNumericUpDown.Enabled = false;
            }
            else
            {
                basisNumericUpDown.Enabled = false;
                basisSplitsNumericUpDown.Enabled = true;
            }

            if (Mode == LayoutMode.Horizontal)
            {
                chkTwoRows.Enabled = false;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.Checked = true;
            }
            else
            {
                chkTwoRows.Enabled = true;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            TextColor = SettingsHelper.ParseColor(element["TextColor"]);
            OverrideTextColor = SettingsHelper.ParseBool(element["OverrideTextColor"]);
            ChanceColor = SettingsHelper.ParseColor(element["ChanceColor"]);
            OverrideChanceColor = SettingsHelper.ParseBool(element["OverrideChanceColor"]);
            BackgroundColor = SettingsHelper.ParseColor(element["BackgroundColor"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GradientString = SettingsHelper.ParseString(element["BackgroundGradient"]);
            ChanceMode = SettingsHelper.ParseEnum<ResetChanceMode>(element["ChanceMode"]);
            Accuracy = SettingsHelper.ParseEnum<ResetChanceAccuracy>(element["Accuracy"]);
            ShowTrailingZeroes = SettingsHelper.ParseBool(element["ShowTrailingZeroes"]);
            Basis = SettingsHelper.ParseEnum<ResetChanceBasis>(element["Basis"]);
            BasisSubset = SettingsHelper.ParseInt(element["BasisSubset"]);
            BasisSubsetSplits = SettingsHelper.ParseInt(element["BasisSubsetSplits"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "TextColor", TextColor) ^
                SettingsHelper.CreateSetting(document, parent, "OverrideTextColor", OverrideTextColor) ^
                SettingsHelper.CreateSetting(document, parent, "ChanceColor", ChanceColor) ^
                SettingsHelper.CreateSetting(document, parent, "OverrideChanceColor", OverrideChanceColor) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundColor", BackgroundColor) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundGradient", BackgroundGradient) ^
                SettingsHelper.CreateSetting(document, parent, "ChanceMode", ChanceMode) ^
                SettingsHelper.CreateSetting(document, parent, "Accuracy", Accuracy) ^
                SettingsHelper.CreateSetting(document, parent, "ShowTrailingZeroes", ShowTrailingZeroes) ^
                SettingsHelper.CreateSetting(document, parent, "Basis", Basis) ^
                SettingsHelper.CreateSetting(document, parent, "BasisSubset", BasisSubset) ^
                SettingsHelper.CreateSetting(document, parent, "BasisSubsetSplits", BasisSubsetSplits) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows);
        }

        private void rdoModeResetChance_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMode();
        }

        private void rdoModeSuccessChance_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMode();
        }

        private void rdoModeRunsEnded_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMode();
        }

        private void rdoDecimalZero_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoDecimalOne_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoDecimalTwo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoBasisAllRuns_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBasis();
        }

        private void rdoBasisSubset_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBasis();
        }

        private void rdoBasisSubsetSplits_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBasis();
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void cmbGradientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnColor1.Visible = cmbGradientType.SelectedItem.ToString() != "Plain";
            btnColor2.DataBindings.Clear();
            btnColor2.DataBindings.Add("BackColor", this, btnColor1.Visible ? "BackgroundColor2" : "BackgroundColor", false, DataSourceUpdateMode.OnPropertyChanged);
            GradientString = cmbGradientType.SelectedItem.ToString();
        }

        private void chkOverrideTextColor_CheckedChanged(object sender, EventArgs e)
        {
            textColorLabel.Enabled = btnTextColor.Enabled = chkOverrideTextColor.Checked;
        }

        private void chkOverrideResetColor_CheckedChanged(object sender, EventArgs e)
        {
            resetColorLabel.Enabled = btnResetColor.Enabled = chkOverrideResetColor.Checked;
        }

        private void UpdateMode()
        {
            if (rdoModeResetChance.Checked)
                ChanceMode = ResetChanceMode.ResetChance;
            else if (rdoModeSuccessChance.Checked)
                ChanceMode = ResetChanceMode.SuccessChance;
            else
                ChanceMode = ResetChanceMode.RunsEnded;
        }

        private void UpdateAccuracy()
        {
            if (rdoDecimalZero.Checked)
                Accuracy = ResetChanceAccuracy.ZeroDecimal;
            else if (rdoDecimalOne.Checked)
                Accuracy = ResetChanceAccuracy.OneDecimal;
            else
                Accuracy = ResetChanceAccuracy.TwoDecimal;
        }

        private void UpdateBasis()
        {
            if (rdoBasisAllRuns.Checked)
                Basis = ResetChanceBasis.AllRuns;
            else if (rdoBasisSubset.Checked)
                Basis = ResetChanceBasis.Subset;
            else
                Basis = ResetChanceBasis.SubsetSplits;

            if (Basis == ResetChanceBasis.AllRuns)
            {
                basisNumericUpDown.Enabled = false;
                basisSplitsNumericUpDown.Enabled = false;
            }
            else if (Basis == ResetChanceBasis.Subset)
            {
                basisNumericUpDown.Enabled = true;
                basisSplitsNumericUpDown.Enabled = false;
            }
            else
            {
                basisNumericUpDown.Enabled = false;
                basisSplitsNumericUpDown.Enabled = true;
            }
        }
    }
}
