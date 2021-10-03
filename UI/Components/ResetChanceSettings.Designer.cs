
namespace LiveSplit.UI.Components
{
    partial class ResetChanceSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textGroupBox = new System.Windows.Forms.GroupBox();
            this.textTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkOverrideTextColor = new System.Windows.Forms.CheckBox();
            this.textColorLabel = new System.Windows.Forms.Label();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.resetChanceGroupBox = new System.Windows.Forms.GroupBox();
            this.resetChanceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.decimalGroupBox = new System.Windows.Forms.GroupBox();
            this.decimalLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rdoDecimalZero = new System.Windows.Forms.RadioButton();
            this.rdoDecimalOne = new System.Windows.Forms.RadioButton();
            this.rdoDecimalTwo = new System.Windows.Forms.RadioButton();
            this.chkTrailingZeroes = new System.Windows.Forms.CheckBox();
            this.resetClrGroupBox = new System.Windows.Forms.GroupBox();
            this.resetClrLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkOverrideResetColor = new System.Windows.Forms.CheckBox();
            this.resetColorLabel = new System.Windows.Forms.Label();
            this.btnResetColor = new System.Windows.Forms.Button();
            this.basisGroupBox = new System.Windows.Forms.GroupBox();
            this.basisTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rdoBasisAllRuns = new System.Windows.Forms.RadioButton();
            this.rdoBasisSubset = new System.Windows.Forms.RadioButton();
            this.basisNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.basisSubsetLabel = new System.Windows.Forms.Label();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.bgColorLabel = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.cmbGradientType = new System.Windows.Forms.ComboBox();
            this.rdoBasisSubsetSplits = new System.Windows.Forms.RadioButton();
            this.basisSplitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.basisSubsetSplitsLabel = new System.Windows.Forms.Label();
            this.topLevelLayoutPanel.SuspendLayout();
            this.textGroupBox.SuspendLayout();
            this.textTableLayoutPanel.SuspendLayout();
            this.resetChanceGroupBox.SuspendLayout();
            this.resetChanceTableLayoutPanel.SuspendLayout();
            this.decimalGroupBox.SuspendLayout();
            this.decimalLayoutPanel.SuspendLayout();
            this.resetClrGroupBox.SuspendLayout();
            this.resetClrLayoutPanel.SuspendLayout();
            this.basisGroupBox.SuspendLayout();
            this.basisTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basisNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisSplitsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLevelLayoutPanel.ColumnCount = 4;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLevelLayoutPanel.Controls.Add(this.textGroupBox, 0, 2);
            this.topLevelLayoutPanel.Controls.Add(this.resetChanceGroupBox, 0, 3);
            this.topLevelLayoutPanel.Controls.Add(this.chkTwoRows, 0, 1);
            this.topLevelLayoutPanel.Controls.Add(this.bgColorLabel, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.btnColor1, 1, 0);
            this.topLevelLayoutPanel.Controls.Add(this.btnColor2, 2, 0);
            this.topLevelLayoutPanel.Controls.Add(this.cmbGradientType, 3, 0);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(10, 11);
            this.topLevelLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 4;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(694, 755);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // textGroupBox
            // 
            this.textGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLevelLayoutPanel.SetColumnSpan(this.textGroupBox, 4);
            this.textGroupBox.Controls.Add(this.textTableLayoutPanel);
            this.textGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textGroupBox.Location = new System.Drawing.Point(4, 95);
            this.textGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textGroupBox.Name = "textGroupBox";
            this.textGroupBox.Size = new System.Drawing.Size(686, 118);
            this.textGroupBox.TabIndex = 2;
            this.textGroupBox.TabStop = false;
            this.textGroupBox.Text = "Text";
            // 
            // textTableLayoutPanel
            // 
            this.textTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textTableLayoutPanel.ColumnCount = 2;
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.textTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textTableLayoutPanel.Controls.Add(this.chkOverrideTextColor, 0, 0);
            this.textTableLayoutPanel.Controls.Add(this.textColorLabel, 0, 1);
            this.textTableLayoutPanel.Controls.Add(this.btnTextColor, 1, 1);
            this.textTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.textTableLayoutPanel.MinimumSize = new System.Drawing.Size(0, 100);
            this.textTableLayoutPanel.Name = "textTableLayoutPanel";
            this.textTableLayoutPanel.RowCount = 2;
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textTableLayoutPanel.Size = new System.Drawing.Size(680, 100);
            this.textTableLayoutPanel.TabIndex = 0;
            // 
            // chkOverrideTextColor
            // 
            this.chkOverrideTextColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverrideTextColor.AutoSize = true;
            this.chkOverrideTextColor.Location = new System.Drawing.Point(10, 13);
            this.chkOverrideTextColor.Margin = new System.Windows.Forms.Padding(10, 5, 4, 5);
            this.chkOverrideTextColor.Name = "chkOverrideTextColor";
            this.chkOverrideTextColor.Size = new System.Drawing.Size(216, 24);
            this.chkOverrideTextColor.TabIndex = 0;
            this.chkOverrideTextColor.Text = "Override Layout Settings";
            this.chkOverrideTextColor.UseVisualStyleBackColor = true;
            this.chkOverrideTextColor.CheckedChanged += new System.EventHandler(this.chkOverrideTextColor_CheckedChanged);
            // 
            // textColorLabel
            // 
            this.textColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textColorLabel.AutoSize = true;
            this.textColorLabel.Location = new System.Drawing.Point(4, 65);
            this.textColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textColorLabel.Name = "textColorLabel";
            this.textColorLabel.Size = new System.Drawing.Size(222, 20);
            this.textColorLabel.TabIndex = 1;
            this.textColorLabel.Text = "Color:";
            // 
            // btnTextColor
            // 
            this.btnTextColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTextColor.Location = new System.Drawing.Point(234, 55);
            this.btnTextColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(36, 40);
            this.btnTextColor.TabIndex = 2;
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // resetChanceGroupBox
            // 
            this.resetChanceGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLevelLayoutPanel.SetColumnSpan(this.resetChanceGroupBox, 4);
            this.resetChanceGroupBox.Controls.Add(this.resetChanceTableLayoutPanel);
            this.resetChanceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetChanceGroupBox.Location = new System.Drawing.Point(4, 223);
            this.resetChanceGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetChanceGroupBox.Name = "resetChanceGroupBox";
            this.resetChanceGroupBox.Size = new System.Drawing.Size(686, 527);
            this.resetChanceGroupBox.TabIndex = 3;
            this.resetChanceGroupBox.TabStop = false;
            this.resetChanceGroupBox.Text = "Reset Chance";
            // 
            // resetChanceTableLayoutPanel
            // 
            this.resetChanceTableLayoutPanel.ColumnCount = 1;
            this.resetChanceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resetChanceTableLayoutPanel.Controls.Add(this.decimalGroupBox, 0, 1);
            this.resetChanceTableLayoutPanel.Controls.Add(this.resetClrGroupBox, 0, 0);
            this.resetChanceTableLayoutPanel.Controls.Add(this.basisGroupBox, 0, 2);
            this.resetChanceTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.resetChanceTableLayoutPanel.Name = "resetChanceTableLayoutPanel";
            this.resetChanceTableLayoutPanel.RowCount = 3;
            this.resetChanceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.resetChanceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.resetChanceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.resetChanceTableLayoutPanel.Size = new System.Drawing.Size(680, 503);
            this.resetChanceTableLayoutPanel.TabIndex = 0;
            // 
            // decimalGroupBox
            // 
            this.decimalGroupBox.AutoSize = true;
            this.decimalGroupBox.Controls.Add(this.decimalLayoutPanel);
            this.decimalGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.decimalGroupBox.Location = new System.Drawing.Point(4, 133);
            this.decimalGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decimalGroupBox.MinimumSize = new System.Drawing.Size(0, 150);
            this.decimalGroupBox.Name = "decimalGroupBox";
            this.decimalGroupBox.Size = new System.Drawing.Size(672, 150);
            this.decimalGroupBox.TabIndex = 1;
            this.decimalGroupBox.TabStop = false;
            this.decimalGroupBox.Text = "Decimal Points";
            // 
            // decimalLayoutPanel
            // 
            this.decimalLayoutPanel.AutoSize = true;
            this.decimalLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decimalLayoutPanel.ColumnCount = 3;
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.decimalLayoutPanel.Controls.Add(this.rdoDecimalZero, 0, 0);
            this.decimalLayoutPanel.Controls.Add(this.rdoDecimalOne, 1, 0);
            this.decimalLayoutPanel.Controls.Add(this.rdoDecimalTwo, 2, 0);
            this.decimalLayoutPanel.Controls.Add(this.chkTrailingZeroes, 0, 1);
            this.decimalLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.decimalLayoutPanel.Name = "decimalLayoutPanel";
            this.decimalLayoutPanel.RowCount = 2;
            this.decimalLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.decimalLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.decimalLayoutPanel.Size = new System.Drawing.Size(666, 125);
            this.decimalLayoutPanel.TabIndex = 0;
            // 
            // rdoDecimalZero
            // 
            this.rdoDecimalZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoDecimalZero.AutoSize = true;
            this.rdoDecimalZero.Location = new System.Drawing.Point(4, 19);
            this.rdoDecimalZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDecimalZero.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoDecimalZero.Name = "rdoDecimalZero";
            this.rdoDecimalZero.Size = new System.Drawing.Size(214, 24);
            this.rdoDecimalZero.TabIndex = 0;
            this.rdoDecimalZero.TabStop = true;
            this.rdoDecimalZero.Text = "Zero (1%)";
            this.rdoDecimalZero.UseVisualStyleBackColor = true;
            this.rdoDecimalZero.CheckedChanged += new System.EventHandler(this.rdoDecimalZero_CheckedChanged);
            // 
            // rdoDecimalOne
            // 
            this.rdoDecimalOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoDecimalOne.AutoSize = true;
            this.rdoDecimalOne.Location = new System.Drawing.Point(226, 19);
            this.rdoDecimalOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDecimalOne.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoDecimalOne.Name = "rdoDecimalOne";
            this.rdoDecimalOne.Size = new System.Drawing.Size(214, 24);
            this.rdoDecimalOne.TabIndex = 1;
            this.rdoDecimalOne.TabStop = true;
            this.rdoDecimalOne.Text = "One (1.1%)";
            this.rdoDecimalOne.UseVisualStyleBackColor = true;
            this.rdoDecimalOne.CheckedChanged += new System.EventHandler(this.rdoDecimalOne_CheckedChanged);
            // 
            // rdoDecimalTwo
            // 
            this.rdoDecimalTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoDecimalTwo.AutoSize = true;
            this.rdoDecimalTwo.Location = new System.Drawing.Point(448, 19);
            this.rdoDecimalTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoDecimalTwo.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoDecimalTwo.Name = "rdoDecimalTwo";
            this.rdoDecimalTwo.Size = new System.Drawing.Size(214, 24);
            this.rdoDecimalTwo.TabIndex = 2;
            this.rdoDecimalTwo.TabStop = true;
            this.rdoDecimalTwo.Text = "Two (1.11%)";
            this.rdoDecimalTwo.UseVisualStyleBackColor = true;
            this.rdoDecimalTwo.CheckedChanged += new System.EventHandler(this.rdoDecimalTwo_CheckedChanged);
            // 
            // chkTrailingZeroes
            // 
            this.chkTrailingZeroes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTrailingZeroes.AutoSize = true;
            this.chkTrailingZeroes.Location = new System.Drawing.Point(10, 81);
            this.chkTrailingZeroes.Margin = new System.Windows.Forms.Padding(10, 5, 4, 5);
            this.chkTrailingZeroes.Name = "chkTrailingZeroes";
            this.chkTrailingZeroes.Size = new System.Drawing.Size(208, 24);
            this.chkTrailingZeroes.TabIndex = 3;
            this.chkTrailingZeroes.Text = "Show Trailing Zeroes";
            this.chkTrailingZeroes.UseVisualStyleBackColor = true;
            // 
            // resetClrGroupBox
            // 
            this.resetClrGroupBox.Controls.Add(this.resetClrLayoutPanel);
            this.resetClrGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetClrGroupBox.Location = new System.Drawing.Point(4, 5);
            this.resetClrGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetClrGroupBox.Name = "resetClrGroupBox";
            this.resetClrGroupBox.Size = new System.Drawing.Size(672, 118);
            this.resetClrGroupBox.TabIndex = 2;
            this.resetClrGroupBox.TabStop = false;
            this.resetClrGroupBox.Text = "Color";
            // 
            // resetClrLayoutPanel
            // 
            this.resetClrLayoutPanel.ColumnCount = 2;
            this.resetClrLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.resetClrLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resetClrLayoutPanel.Controls.Add(this.chkOverrideResetColor, 0, 0);
            this.resetClrLayoutPanel.Controls.Add(this.resetColorLabel, 0, 1);
            this.resetClrLayoutPanel.Controls.Add(this.btnResetColor, 1, 1);
            this.resetClrLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetClrLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.resetClrLayoutPanel.Name = "resetClrLayoutPanel";
            this.resetClrLayoutPanel.RowCount = 2;
            this.resetClrLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resetClrLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.resetClrLayoutPanel.Size = new System.Drawing.Size(666, 93);
            this.resetClrLayoutPanel.TabIndex = 0;
            // 
            // chkOverrideResetColor
            // 
            this.chkOverrideResetColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverrideResetColor.AutoSize = true;
            this.chkOverrideResetColor.Location = new System.Drawing.Point(10, 11);
            this.chkOverrideResetColor.Margin = new System.Windows.Forms.Padding(10, 5, 4, 5);
            this.chkOverrideResetColor.Name = "chkOverrideResetColor";
            this.chkOverrideResetColor.Size = new System.Drawing.Size(210, 24);
            this.chkOverrideResetColor.TabIndex = 0;
            this.chkOverrideResetColor.Text = "Override Layout Settings";
            this.chkOverrideResetColor.UseVisualStyleBackColor = true;
            this.chkOverrideResetColor.CheckedChanged += new System.EventHandler(this.chkOverrideResetColor_CheckedChanged);
            // 
            // resetColorLabel
            // 
            this.resetColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetColorLabel.AutoSize = true;
            this.resetColorLabel.Location = new System.Drawing.Point(3, 59);
            this.resetColorLabel.Name = "resetColorLabel";
            this.resetColorLabel.Size = new System.Drawing.Size(218, 20);
            this.resetColorLabel.TabIndex = 1;
            this.resetColorLabel.Text = "Color:";
            // 
            // btnResetColor
            // 
            this.btnResetColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetColor.Location = new System.Drawing.Point(228, 51);
            this.btnResetColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetColor.Name = "btnResetColor";
            this.btnResetColor.Size = new System.Drawing.Size(36, 37);
            this.btnResetColor.TabIndex = 2;
            this.btnResetColor.UseVisualStyleBackColor = true;
            this.btnResetColor.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // basisGroupBox
            // 
            this.basisGroupBox.Controls.Add(this.basisTableLayoutPanel);
            this.basisGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.basisGroupBox.Location = new System.Drawing.Point(3, 291);
            this.basisGroupBox.Name = "basisGroupBox";
            this.basisGroupBox.Size = new System.Drawing.Size(674, 209);
            this.basisGroupBox.TabIndex = 3;
            this.basisGroupBox.TabStop = false;
            this.basisGroupBox.Text = "Basis";
            // 
            // basisTableLayoutPanel
            // 
            this.basisTableLayoutPanel.ColumnCount = 3;
            this.basisTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.basisTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.basisTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.basisTableLayoutPanel.Controls.Add(this.rdoBasisAllRuns, 0, 0);
            this.basisTableLayoutPanel.Controls.Add(this.rdoBasisSubset, 0, 1);
            this.basisTableLayoutPanel.Controls.Add(this.basisNumericUpDown, 1, 1);
            this.basisTableLayoutPanel.Controls.Add(this.basisSubsetLabel, 2, 1);
            this.basisTableLayoutPanel.Controls.Add(this.rdoBasisSubsetSplits, 0, 2);
            this.basisTableLayoutPanel.Controls.Add(this.basisSplitsNumericUpDown, 1, 2);
            this.basisTableLayoutPanel.Controls.Add(this.basisSubsetSplitsLabel, 2, 2);
            this.basisTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basisTableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.basisTableLayoutPanel.Name = "basisTableLayoutPanel";
            this.basisTableLayoutPanel.RowCount = 3;
            this.basisTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basisTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basisTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.basisTableLayoutPanel.Size = new System.Drawing.Size(668, 184);
            this.basisTableLayoutPanel.TabIndex = 0;
            // 
            // rdoBasisAllRuns
            // 
            this.rdoBasisAllRuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoBasisAllRuns.AutoSize = true;
            this.basisTableLayoutPanel.SetColumnSpan(this.rdoBasisAllRuns, 3);
            this.rdoBasisAllRuns.Location = new System.Drawing.Point(4, 18);
            this.rdoBasisAllRuns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBasisAllRuns.Name = "rdoBasisAllRuns";
            this.rdoBasisAllRuns.Size = new System.Drawing.Size(660, 24);
            this.rdoBasisAllRuns.TabIndex = 0;
            this.rdoBasisAllRuns.TabStop = true;
            this.rdoBasisAllRuns.Text = "Base reset chance on all runs";
            this.rdoBasisAllRuns.UseVisualStyleBackColor = true;
            this.rdoBasisAllRuns.CheckedChanged += new System.EventHandler(this.rdoBasisAllRuns_CheckedChanged);
            // 
            // rdoBasisSubset
            // 
            this.rdoBasisSubset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoBasisSubset.AutoSize = true;
            this.rdoBasisSubset.Location = new System.Drawing.Point(4, 79);
            this.rdoBasisSubset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBasisSubset.Name = "rdoBasisSubset";
            this.rdoBasisSubset.Size = new System.Drawing.Size(235, 24);
            this.rdoBasisSubset.TabIndex = 1;
            this.rdoBasisSubset.TabStop = true;
            this.rdoBasisSubset.Text = "Base reset chance on past";
            this.rdoBasisSubset.UseVisualStyleBackColor = true;
            this.rdoBasisSubset.CheckedChanged += new System.EventHandler(this.rdoBasisSubset_CheckedChanged);
            // 
            // basisNumericUpDown
            // 
            this.basisNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.basisNumericUpDown.Location = new System.Drawing.Point(246, 78);
            this.basisNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.basisNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.basisNumericUpDown.Name = "basisNumericUpDown";
            this.basisNumericUpDown.Size = new System.Drawing.Size(89, 26);
            this.basisNumericUpDown.TabIndex = 2;
            this.basisNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // basisSubsetLabel
            // 
            this.basisSubsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.basisSubsetLabel.AutoSize = true;
            this.basisSubsetLabel.Location = new System.Drawing.Point(341, 81);
            this.basisSubsetLabel.Name = "basisSubsetLabel";
            this.basisSubsetLabel.Size = new System.Drawing.Size(324, 20);
            this.basisSubsetLabel.TabIndex = 3;
            this.basisSubsetLabel.Text = "runs";
            // 
            // chkTwoRows
            // 
            this.chkTwoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwoRows.AutoSize = true;
            this.chkTwoRows.Location = new System.Drawing.Point(10, 55);
            this.chkTwoRows.Margin = new System.Windows.Forms.Padding(10, 5, 4, 5);
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.Size = new System.Drawing.Size(224, 24);
            this.chkTwoRows.TabIndex = 0;
            this.chkTwoRows.Text = "Display 2 Rows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // bgColorLabel
            // 
            this.bgColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgColorLabel.AutoSize = true;
            this.bgColorLabel.Location = new System.Drawing.Point(4, 12);
            this.bgColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bgColorLabel.Name = "bgColorLabel";
            this.bgColorLabel.Size = new System.Drawing.Size(230, 20);
            this.bgColorLabel.TabIndex = 4;
            this.bgColorLabel.Text = "Background Color:";
            // 
            // btnColor1
            // 
            this.btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor1.Location = new System.Drawing.Point(242, 5);
            this.btnColor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(36, 35);
            this.btnColor1.TabIndex = 5;
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // btnColor2
            // 
            this.btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor2.Location = new System.Drawing.Point(286, 5);
            this.btnColor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(36, 35);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // cmbGradientType
            // 
            this.cmbGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradientType.FormattingEnabled = true;
            this.cmbGradientType.Items.AddRange(new object[] {
            "Plain",
            "Vertical",
            "Horizontal"});
            this.cmbGradientType.Location = new System.Drawing.Point(330, 8);
            this.cmbGradientType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGradientType.Name = "cmbGradientType";
            this.cmbGradientType.Size = new System.Drawing.Size(360, 28);
            this.cmbGradientType.TabIndex = 7;
            this.cmbGradientType.SelectedIndexChanged += new System.EventHandler(this.cmbGradientType_SelectedIndexChanged);
            // 
            // rdoBasisSubsetSplits
            // 
            this.rdoBasisSubsetSplits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoBasisSubsetSplits.AutoSize = true;
            this.rdoBasisSubsetSplits.Location = new System.Drawing.Point(4, 141);
            this.rdoBasisSubsetSplits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBasisSubsetSplits.Name = "rdoBasisSubsetSplits";
            this.rdoBasisSubsetSplits.Size = new System.Drawing.Size(235, 24);
            this.rdoBasisSubsetSplits.TabIndex = 4;
            this.rdoBasisSubsetSplits.TabStop = true;
            this.rdoBasisSubsetSplits.Text = "Base reset chance on past";
            this.rdoBasisSubsetSplits.UseVisualStyleBackColor = true;
            this.rdoBasisSubsetSplits.CheckedChanged += new System.EventHandler(this.rdoBasisSubsetSplits_CheckedChanged);
            // 
            // basisSplitsNumericUpDown
            // 
            this.basisSplitsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.basisSplitsNumericUpDown.Location = new System.Drawing.Point(246, 140);
            this.basisSplitsNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.basisSplitsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.basisSplitsNumericUpDown.Name = "basisSplitsNumericUpDown";
            this.basisSplitsNumericUpDown.Size = new System.Drawing.Size(89, 26);
            this.basisSplitsNumericUpDown.TabIndex = 5;
            this.basisSplitsNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // basisSubsetSplitsLabel
            // 
            this.basisSubsetSplitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.basisSubsetSplitsLabel.AutoSize = true;
            this.basisSubsetSplitsLabel.Location = new System.Drawing.Point(341, 143);
            this.basisSubsetSplitsLabel.Name = "basisSubsetSplitsLabel";
            this.basisSubsetSplitsLabel.Size = new System.Drawing.Size(324, 20);
            this.basisSubsetSplitsLabel.TabIndex = 6;
            this.basisSubsetSplitsLabel.Text = "attempts at current split";
            // 
            // ResetChanceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResetChanceSettings";
            this.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Size = new System.Drawing.Size(714, 774);
            this.Load += new System.EventHandler(this.ResetChanceSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.textGroupBox.ResumeLayout(false);
            this.textTableLayoutPanel.ResumeLayout(false);
            this.textTableLayoutPanel.PerformLayout();
            this.resetChanceGroupBox.ResumeLayout(false);
            this.resetChanceTableLayoutPanel.ResumeLayout(false);
            this.resetChanceTableLayoutPanel.PerformLayout();
            this.decimalGroupBox.ResumeLayout(false);
            this.decimalGroupBox.PerformLayout();
            this.decimalLayoutPanel.ResumeLayout(false);
            this.decimalLayoutPanel.PerformLayout();
            this.resetClrGroupBox.ResumeLayout(false);
            this.resetClrLayoutPanel.ResumeLayout(false);
            this.resetClrLayoutPanel.PerformLayout();
            this.basisGroupBox.ResumeLayout(false);
            this.basisTableLayoutPanel.ResumeLayout(false);
            this.basisTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basisNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisSplitsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;
        private System.Windows.Forms.CheckBox chkTwoRows;
        private System.Windows.Forms.GroupBox decimalGroupBox;
        private System.Windows.Forms.TableLayoutPanel decimalLayoutPanel;
        private System.Windows.Forms.RadioButton rdoDecimalZero;
        private System.Windows.Forms.RadioButton rdoDecimalOne;
        private System.Windows.Forms.RadioButton rdoDecimalTwo;
        private System.Windows.Forms.GroupBox textGroupBox;
        private System.Windows.Forms.TableLayoutPanel textTableLayoutPanel;
        private System.Windows.Forms.GroupBox resetChanceGroupBox;
        private System.Windows.Forms.TableLayoutPanel resetChanceTableLayoutPanel;
        private System.Windows.Forms.Label bgColorLabel;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.ComboBox cmbGradientType;
        private System.Windows.Forms.CheckBox chkOverrideTextColor;
        private System.Windows.Forms.CheckBox chkTrailingZeroes;
        private System.Windows.Forms.GroupBox resetClrGroupBox;
        private System.Windows.Forms.TableLayoutPanel resetClrLayoutPanel;
        private System.Windows.Forms.Label textColorLabel;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.CheckBox chkOverrideResetColor;
        private System.Windows.Forms.Label resetColorLabel;
        private System.Windows.Forms.Button btnResetColor;
        private System.Windows.Forms.GroupBox basisGroupBox;
        private System.Windows.Forms.TableLayoutPanel basisTableLayoutPanel;
        private System.Windows.Forms.RadioButton rdoBasisAllRuns;
        private System.Windows.Forms.RadioButton rdoBasisSubset;
        private System.Windows.Forms.NumericUpDown basisNumericUpDown;
        private System.Windows.Forms.Label basisSubsetLabel;
        private System.Windows.Forms.RadioButton rdoBasisSubsetSplits;
        private System.Windows.Forms.NumericUpDown basisSplitsNumericUpDown;
        private System.Windows.Forms.Label basisSubsetSplitsLabel;
    }
}
