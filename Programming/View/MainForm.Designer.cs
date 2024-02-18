namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnumsTabPage = new TabPage();
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
            label1 = new Label();
            ValueTextBox = new TextBox();
            ChooseValueLabel = new Label();
            ValuesListBox = new ListBox();
            ChooseEnumLabel = new Label();
            EnumerationListBox = new ListBox();
            tabControl1 = new TabControl();
            EnumsTabPage.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seasonPictureBox).BeginInit();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(SeasonHandleGroupBox);
            EnumsTabPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsTabPage.Controls.Add(EnumsGroupBox);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(821, 511);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(seasonPictureBox);
            SeasonHandleGroupBox.Controls.Add(seasonComboBox);
            SeasonHandleGroupBox.Controls.Add(goButton);
            SeasonHandleGroupBox.Controls.Add(chooseSeasonLabel);
            SeasonHandleGroupBox.Location = new Point(471, 336);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(344, 167);
            SeasonHandleGroupBox.TabIndex = 4;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonPictureBox
            // 
            seasonPictureBox.Location = new Point(6, 99);
            seasonPictureBox.Name = "seasonPictureBox";
            seasonPictureBox.Size = new Size(68, 62);
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
            WeekdayParsingGroupBox.Location = new Point(8, 336);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(457, 169);
            WeekdayParsingGroupBox.TabIndex = 9;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseFinishLabel
            // 
            ParseFinishLabel.AutoSize = true;
            ParseFinishLabel.Location = new Point(6, 86);
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
            EnumsGroupBox.Controls.Add(label1);
            EnumsGroupBox.Controls.Add(ValueTextBox);
            EnumsGroupBox.Controls.Add(ChooseValueLabel);
            EnumsGroupBox.Controls.Add(ValuesListBox);
            EnumsGroupBox.Controls.Add(ChooseEnumLabel);
            EnumsGroupBox.Controls.Add(EnumerationListBox);
            EnumsGroupBox.Location = new Point(8, 3);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(807, 327);
            EnumsGroupBox.TabIndex = 2;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Int Value:";
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
            ChooseValueLabel.Location = new Point(247, 34);
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
            ChooseEnumLabel.Location = new Point(7, 34);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(829, 544);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 544);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            EnumsTabPage.ResumeLayout(false);
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seasonPictureBox).EndInit();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumsGroupBox.ResumeLayout(false);
            EnumsGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage EnumsTabPage;
        private GroupBox EnumsGroupBox;
        private ListBox EnumerationListBox;
        private TabControl tabControl1;
        private Label ChooseValueLabel;
        private ListBox ValuesListBox;
        private Label ChooseEnumLabel;
        private TextBox ValueTextBox;
        private Label label1;
        private GroupBox WeekdayParsingGroupBox;
        private Button buttonParse;
        private TextBox ParseTextBox;
        private Label TypeLabel;
        private Label ParseFinishLabel;
        private GroupBox SeasonHandleGroupBox;
        private ComboBox seasonComboBox;
        private Button goButton;
        private Label chooseSeasonLabel;
        private PictureBox seasonPictureBox;
    }
}
