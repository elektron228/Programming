namespace Programming.View.TabPages
{
    partial class EnumsTabPage
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
            SeasonHandleGroupBox = new GroupBox();
            seasonPictureBox = new PictureBox();
            seasonComboBox = new ComboBox();
            goButton = new Button();
            chooseSeasonLabel = new Label();
            WeekdayParsingGroupBox = new GroupBox();
            ParseFinishLabel = new Label();
            buttonParse = new Button();
            ParseTextBox = new TextBox();
            TypeLabel = new Label();
            EnumsGroupBox = new GroupBox();
            IntValueLabel = new Label();
            ValueTextBox = new TextBox();
            ChooseValueLabel = new Label();
            ValuesListBox = new ListBox();
            ChooseEnumLabel = new Label();
            EnumerationListBox = new ListBox();
            SeasonHandleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seasonPictureBox).BeginInit();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(seasonPictureBox);
            SeasonHandleGroupBox.Controls.Add(seasonComboBox);
            SeasonHandleGroupBox.Controls.Add(goButton);
            SeasonHandleGroupBox.Controls.Add(chooseSeasonLabel);
            SeasonHandleGroupBox.Location = new Point(470, 337);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(344, 171);
            SeasonHandleGroupBox.TabIndex = 11;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonPictureBox
            // 
            seasonPictureBox.Location = new Point(6, 99);
            seasonPictureBox.Name = "seasonPictureBox";
            seasonPictureBox.Size = new Size(69, 61);
            seasonPictureBox.TabIndex = 10;
            seasonPictureBox.TabStop = false;
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.Location = new Point(6, 55);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(158, 28);
            seasonComboBox.TabIndex = 7;
            // 
            // goButton
            // 
            goButton.Location = new Point(170, 55);
            goButton.Name = "goButton";
            goButton.Size = new Size(94, 29);
            goButton.TabIndex = 6;
            goButton.Text = "Go!";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // chooseSeasonLabel
            // 
            chooseSeasonLabel.AutoSize = true;
            chooseSeasonLabel.Location = new Point(6, 35);
            chooseSeasonLabel.Name = "chooseSeasonLabel";
            chooseSeasonLabel.Size = new Size(107, 20);
            chooseSeasonLabel.TabIndex = 4;
            chooseSeasonLabel.Text = "Choose season";
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(ParseFinishLabel);
            WeekdayParsingGroupBox.Controls.Add(buttonParse);
            WeekdayParsingGroupBox.Controls.Add(ParseTextBox);
            WeekdayParsingGroupBox.Controls.Add(TypeLabel);
            WeekdayParsingGroupBox.Location = new Point(7, 337);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(457, 173);
            WeekdayParsingGroupBox.TabIndex = 12;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseFinishLabel
            // 
            ParseFinishLabel.AutoSize = true;
            ParseFinishLabel.Location = new Point(6, 85);
            ParseFinishLabel.Name = "ParseFinishLabel";
            ParseFinishLabel.Size = new Size(137, 20);
            ParseFinishLabel.TabIndex = 3;
            ParseFinishLabel.Text = "Write weekday ^_^";
            // 
            // buttonParse
            // 
            buttonParse.Location = new Point(223, 56);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(94, 29);
            buttonParse.TabIndex = 2;
            buttonParse.Text = "Parse";
            buttonParse.UseVisualStyleBackColor = true;
            buttonParse.Click += buttonParse_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(7, 56);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(210, 27);
            ParseTextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(7, 33);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(158, 20);
            TypeLabel.TabIndex = 0;
            TypeLabel.Text = "Type value for parsing:";
            // 
            // EnumsGroupBox
            // 
            EnumsGroupBox.Controls.Add(IntValueLabel);
            EnumsGroupBox.Controls.Add(ValueTextBox);
            EnumsGroupBox.Controls.Add(ChooseValueLabel);
            EnumsGroupBox.Controls.Add(ValuesListBox);
            EnumsGroupBox.Controls.Add(ChooseEnumLabel);
            EnumsGroupBox.Controls.Add(EnumerationListBox);
            EnumsGroupBox.Location = new Point(7, 4);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(807, 331);
            EnumsGroupBox.TabIndex = 10;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(487, 35);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(69, 20);
            IntValueLabel.TabIndex = 8;
            IntValueLabel.Text = "Int Value:";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(487, 57);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(125, 27);
            ValueTextBox.TabIndex = 7;
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(247, 35);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(101, 20);
            ChooseValueLabel.TabIndex = 6;
            ChooseValueLabel.Text = "Choose Value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(247, 57);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(210, 264);
            ValuesListBox.TabIndex = 5;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ChooseEnumLabel
            // 
            ChooseEnumLabel.AutoSize = true;
            ChooseEnumLabel.Location = new Point(7, 35);
            ChooseEnumLabel.Name = "ChooseEnumLabel";
            ChooseEnumLabel.Size = new Size(149, 20);
            ChooseEnumLabel.TabIndex = 4;
            ChooseEnumLabel.Text = "Choose Enumeration:";
            // 
            // EnumerationListBox
            // 
            EnumerationListBox.FormattingEnabled = true;
            EnumerationListBox.Location = new Point(7, 57);
            EnumerationListBox.Name = "EnumerationListBox";
            EnumerationListBox.Size = new Size(210, 264);
            EnumerationListBox.TabIndex = 3;
            EnumerationListBox.SelectedIndexChanged += EnumerationListBox_SelectedIndexChanged;
            // 
            // EnumsTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandleGroupBox);
            Controls.Add(WeekdayParsingGroupBox);
            Controls.Add(EnumsGroupBox);
            Name = "EnumsTabPage";
            Size = new Size(821, 511);
            Load += EnumsTabPage_Load;
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seasonPictureBox).EndInit();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandleGroupBox;
        private PictureBox seasonPictureBox;
        private ComboBox seasonComboBox;
        private Button goButton;
        private Label chooseSeasonLabel;
        private GroupBox WeekdayParsingGroupBox;
        private Label ParseFinishLabel;
        private Button buttonParse;
        private TextBox ParseTextBox;
        private Label TypeLabel;
        private GroupBox EnumsGroupBox;
        private Label IntValueLabel;
        private TextBox ValueTextBox;
        private Label ChooseValueLabel;
        private ListBox ValuesListBox;
        private Label ChooseEnumLabel;
        private ListBox EnumerationListBox;
    }
}
