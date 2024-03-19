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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            IntValueLabel = new Label();
            ValueTextBox = new TextBox();
            ChooseValueLabel = new Label();
            ValuesListBox = new ListBox();
            ChooseEnumLabel = new Label();
            EnumerationListBox = new ListBox();
            tabControl1 = new TabControl();
            ClasssesTabPage = new TabPage();
            movieGroupBox = new GroupBox();
            movieRatingLabel = new Label();
            movieRatingTextBox = new TextBox();
            movieGenreLabel = new Label();
            movieGenreTextBox = new TextBox();
            movieFindButton = new Button();
            movieReleaseYearLabel = new Label();
            movieReleaseYearTextBox = new TextBox();
            movieDurationLabel = new Label();
            movieDurationTextBox = new TextBox();
            movieNameLabel = new Label();
            movieNameTextBox = new TextBox();
            MovieListBox = new ListBox();
            rectanglesGroupBox = new GroupBox();
            IdLabel = new Label();
            idTextBox = new TextBox();
            labelCenterY = new Label();
            textBoxCenterY = new TextBox();
            labelCenterX = new Label();
            textBoxCenterX = new TextBox();
            findRectangleButton = new Button();
            colourLabel = new Label();
            colourTextBox = new TextBox();
            wideLabel = new Label();
            wideTextBox = new TextBox();
            lengthButton = new Label();
            lengthTextBox = new TextBox();
            rectanglesListBox = new ListBox();
            RectanglesTabPage = new TabPage();
            RectanglesHeigthTextBox = new TextBox();
            RectanglesWidthTextBox = new TextBox();
            RectanglesYTextBox = new TextBox();
            RectanglesXTextBox = new TextBox();
            RectanglesSelctedRectLabel = new Label();
            RectanglesIDTextBox = new TextBox();
            DelRectPictBox = new PictureBox();
            AddRectPictBox = new PictureBox();
            ReactanglesCollisionLabel = new Label();
            RectanglesCollisionListBox = new ListBox();
            RectanglesPanel = new Panel();
            RectanglesWidthLabel = new Label();
            RectanglesHeigthLabel = new Label();
            RectanglesYLabel = new Label();
            RectanglesXLabel = new Label();
            RectanglesIDLabel = new Label();
            EnumsTabPage.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seasonPictureBox).BeginInit();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            ClasssesTabPage.SuspendLayout();
            movieGroupBox.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DelRectPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddRectPictBox).BeginInit();
            SuspendLayout();
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(SeasonHandleGroupBox);
            EnumsTabPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsTabPage.Controls.Add(EnumsGroupBox);
            EnumsTabPage.Location = new Point(4, 24);
            EnumsTabPage.Margin = new Padding(3, 2, 3, 2);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3, 2, 3, 2);
            EnumsTabPage.Size = new Size(717, 380);
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
            SeasonHandleGroupBox.Location = new Point(412, 252);
            SeasonHandleGroupBox.Margin = new Padding(3, 2, 3, 2);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Padding = new Padding(3, 2, 3, 2);
            SeasonHandleGroupBox.Size = new Size(301, 125);
            SeasonHandleGroupBox.TabIndex = 4;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonPictureBox
            // 
            seasonPictureBox.Location = new Point(5, 74);
            seasonPictureBox.Margin = new Padding(3, 2, 3, 2);
            seasonPictureBox.Name = "seasonPictureBox";
            seasonPictureBox.Size = new Size(60, 46);
            seasonPictureBox.TabIndex = 10;
            seasonPictureBox.TabStop = false;
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.Location = new Point(5, 41);
            seasonComboBox.Margin = new Padding(3, 2, 3, 2);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(139, 23);
            seasonComboBox.TabIndex = 7;
            // 
            // goButton
            // 
            goButton.Location = new Point(149, 41);
            goButton.Margin = new Padding(3, 2, 3, 2);
            goButton.Name = "goButton";
            goButton.Size = new Size(82, 22);
            goButton.TabIndex = 6;
            goButton.Text = "Go!";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // chooseSeasonLabel
            // 
            chooseSeasonLabel.AutoSize = true;
            chooseSeasonLabel.Location = new Point(5, 26);
            chooseSeasonLabel.Name = "chooseSeasonLabel";
            chooseSeasonLabel.Size = new Size(86, 15);
            chooseSeasonLabel.TabIndex = 4;
            chooseSeasonLabel.Text = "Choose season";
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(ParseFinishLabel);
            WeekdayParsingGroupBox.Controls.Add(buttonParse);
            WeekdayParsingGroupBox.Controls.Add(ParseTextBox);
            WeekdayParsingGroupBox.Controls.Add(TypeLabel);
            WeekdayParsingGroupBox.Location = new Point(7, 252);
            WeekdayParsingGroupBox.Margin = new Padding(3, 2, 3, 2);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Padding = new Padding(3, 2, 3, 2);
            WeekdayParsingGroupBox.Size = new Size(400, 127);
            WeekdayParsingGroupBox.TabIndex = 9;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseFinishLabel
            // 
            ParseFinishLabel.AutoSize = true;
            ParseFinishLabel.Location = new Point(5, 64);
            ParseFinishLabel.Name = "ParseFinishLabel";
            ParseFinishLabel.Size = new Size(108, 15);
            ParseFinishLabel.TabIndex = 3;
            ParseFinishLabel.Text = "Write weekday ^_^";
            // 
            // buttonParse
            // 
            buttonParse.Location = new Point(195, 42);
            buttonParse.Margin = new Padding(3, 2, 3, 2);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(82, 22);
            buttonParse.TabIndex = 2;
            buttonParse.Text = "Parse";
            buttonParse.UseVisualStyleBackColor = true;
            buttonParse.Click += buttonParse_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(6, 42);
            ParseTextBox.Margin = new Padding(3, 2, 3, 2);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(184, 23);
            ParseTextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(6, 25);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(125, 15);
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
            EnumsGroupBox.Location = new Point(7, 2);
            EnumsGroupBox.Margin = new Padding(3, 2, 3, 2);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Padding = new Padding(3, 2, 3, 2);
            EnumsGroupBox.Size = new Size(706, 245);
            EnumsGroupBox.TabIndex = 2;
            EnumsGroupBox.TabStop = false;
            EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(426, 26);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 8;
            IntValueLabel.Text = "Int Value:";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(426, 43);
            ValueTextBox.Margin = new Padding(3, 2, 3, 2);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(110, 23);
            ValueTextBox.TabIndex = 7;
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(216, 26);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(81, 15);
            ChooseValueLabel.TabIndex = 6;
            ChooseValueLabel.Text = "Choose Value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(216, 43);
            ValuesListBox.Margin = new Padding(3, 2, 3, 2);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(184, 199);
            ValuesListBox.TabIndex = 5;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ChooseEnumLabel
            // 
            ChooseEnumLabel.AutoSize = true;
            ChooseEnumLabel.Location = new Point(6, 26);
            ChooseEnumLabel.Name = "ChooseEnumLabel";
            ChooseEnumLabel.Size = new Size(121, 15);
            ChooseEnumLabel.TabIndex = 4;
            ChooseEnumLabel.Text = "Choose Enumeration:";
            // 
            // EnumerationListBox
            // 
            EnumerationListBox.FormattingEnabled = true;
            EnumerationListBox.ItemHeight = 15;
            EnumerationListBox.Location = new Point(6, 43);
            EnumerationListBox.Margin = new Padding(3, 2, 3, 2);
            EnumerationListBox.Name = "EnumerationListBox";
            EnumerationListBox.Size = new Size(184, 199);
            EnumerationListBox.TabIndex = 3;
            EnumerationListBox.SelectedIndexChanged += EnumerationListBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Controls.Add(ClasssesTabPage);
            tabControl1.Controls.Add(RectanglesTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 408);
            tabControl1.TabIndex = 0;
            // 
            // ClasssesTabPage
            // 
            ClasssesTabPage.Controls.Add(movieGroupBox);
            ClasssesTabPage.Controls.Add(rectanglesGroupBox);
            ClasssesTabPage.Location = new Point(4, 24);
            ClasssesTabPage.Margin = new Padding(3, 2, 3, 2);
            ClasssesTabPage.Name = "ClasssesTabPage";
            ClasssesTabPage.Padding = new Padding(3, 2, 3, 2);
            ClasssesTabPage.Size = new Size(717, 380);
            ClasssesTabPage.TabIndex = 1;
            ClasssesTabPage.Text = "Classes";
            ClasssesTabPage.UseVisualStyleBackColor = true;
            // 
            // movieGroupBox
            // 
            movieGroupBox.Controls.Add(movieRatingLabel);
            movieGroupBox.Controls.Add(movieRatingTextBox);
            movieGroupBox.Controls.Add(movieGenreLabel);
            movieGroupBox.Controls.Add(movieGenreTextBox);
            movieGroupBox.Controls.Add(movieFindButton);
            movieGroupBox.Controls.Add(movieReleaseYearLabel);
            movieGroupBox.Controls.Add(movieReleaseYearTextBox);
            movieGroupBox.Controls.Add(movieDurationLabel);
            movieGroupBox.Controls.Add(movieDurationTextBox);
            movieGroupBox.Controls.Add(movieNameLabel);
            movieGroupBox.Controls.Add(movieNameTextBox);
            movieGroupBox.Controls.Add(MovieListBox);
            movieGroupBox.Location = new Point(253, 6);
            movieGroupBox.Margin = new Padding(3, 2, 3, 2);
            movieGroupBox.Name = "movieGroupBox";
            movieGroupBox.Padding = new Padding(3, 2, 3, 2);
            movieGroupBox.Size = new Size(458, 219);
            movieGroupBox.TabIndex = 8;
            movieGroupBox.TabStop = false;
            movieGroupBox.Text = "Movies";
            // 
            // movieRatingLabel
            // 
            movieRatingLabel.AutoSize = true;
            movieRatingLabel.Location = new Point(267, 59);
            movieRatingLabel.Name = "movieRatingLabel";
            movieRatingLabel.Size = new Size(44, 15);
            movieRatingLabel.TabIndex = 11;
            movieRatingLabel.Text = "Rating:";
            // 
            // movieRatingTextBox
            // 
            movieRatingTextBox.Location = new Point(267, 76);
            movieRatingTextBox.Margin = new Padding(3, 2, 3, 2);
            movieRatingTextBox.Name = "movieRatingTextBox";
            movieRatingTextBox.Size = new Size(120, 23);
            movieRatingTextBox.TabIndex = 10;
            movieRatingTextBox.TextChanged += movieRatingTextBox_TextChanged;
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.AutoSize = true;
            movieGenreLabel.Location = new Point(267, 20);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new Size(41, 15);
            movieGenreLabel.TabIndex = 9;
            movieGenreLabel.Text = "Genre:";
            // 
            // movieGenreTextBox
            // 
            movieGenreTextBox.Location = new Point(267, 37);
            movieGenreTextBox.Margin = new Padding(3, 2, 3, 2);
            movieGenreTextBox.Name = "movieGenreTextBox";
            movieGenreTextBox.ReadOnly = true;
            movieGenreTextBox.Size = new Size(120, 23);
            movieGenreTextBox.TabIndex = 8;
            // 
            // movieFindButton
            // 
            movieFindButton.Location = new Point(142, 151);
            movieFindButton.Margin = new Padding(3, 2, 3, 2);
            movieFindButton.Name = "movieFindButton";
            movieFindButton.Size = new Size(82, 22);
            movieFindButton.TabIndex = 7;
            movieFindButton.Text = "Find";
            movieFindButton.UseVisualStyleBackColor = true;
            movieFindButton.Click += movieFindButton_Click;
            // 
            // movieReleaseYearLabel
            // 
            movieReleaseYearLabel.AutoSize = true;
            movieReleaseYearLabel.Location = new Point(142, 99);
            movieReleaseYearLabel.Name = "movieReleaseYearLabel";
            movieReleaseYearLabel.Size = new Size(74, 15);
            movieReleaseYearLabel.TabIndex = 6;
            movieReleaseYearLabel.Text = "Release Year:";
            // 
            // movieReleaseYearTextBox
            // 
            movieReleaseYearTextBox.Location = new Point(142, 116);
            movieReleaseYearTextBox.Margin = new Padding(3, 2, 3, 2);
            movieReleaseYearTextBox.Name = "movieReleaseYearTextBox";
            movieReleaseYearTextBox.ReadOnly = true;
            movieReleaseYearTextBox.Size = new Size(120, 23);
            movieReleaseYearTextBox.TabIndex = 5;
            // 
            // movieDurationLabel
            // 
            movieDurationLabel.AutoSize = true;
            movieDurationLabel.Location = new Point(142, 59);
            movieDurationLabel.Name = "movieDurationLabel";
            movieDurationLabel.Size = new Size(110, 15);
            movieDurationLabel.TabIndex = 4;
            movieDurationLabel.Text = "Duration (minutes):";
            // 
            // movieDurationTextBox
            // 
            movieDurationTextBox.Location = new Point(142, 76);
            movieDurationTextBox.Margin = new Padding(3, 2, 3, 2);
            movieDurationTextBox.Name = "movieDurationTextBox";
            movieDurationTextBox.ReadOnly = true;
            movieDurationTextBox.Size = new Size(120, 23);
            movieDurationTextBox.TabIndex = 3;
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new Point(142, 20);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(42, 15);
            movieNameLabel.TabIndex = 2;
            movieNameLabel.Text = "Name:";
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.Location = new Point(142, 37);
            movieNameTextBox.Margin = new Padding(3, 2, 3, 2);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.ReadOnly = true;
            movieNameTextBox.Size = new Size(120, 23);
            movieNameTextBox.TabIndex = 1;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 15;
            MovieListBox.Location = new Point(5, 20);
            MovieListBox.Margin = new Padding(3, 2, 3, 2);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(132, 154);
            MovieListBox.TabIndex = 0;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // rectanglesGroupBox
            // 
            rectanglesGroupBox.Controls.Add(IdLabel);
            rectanglesGroupBox.Controls.Add(idTextBox);
            rectanglesGroupBox.Controls.Add(labelCenterY);
            rectanglesGroupBox.Controls.Add(textBoxCenterY);
            rectanglesGroupBox.Controls.Add(labelCenterX);
            rectanglesGroupBox.Controls.Add(textBoxCenterX);
            rectanglesGroupBox.Controls.Add(findRectangleButton);
            rectanglesGroupBox.Controls.Add(colourLabel);
            rectanglesGroupBox.Controls.Add(colourTextBox);
            rectanglesGroupBox.Controls.Add(wideLabel);
            rectanglesGroupBox.Controls.Add(wideTextBox);
            rectanglesGroupBox.Controls.Add(lengthButton);
            rectanglesGroupBox.Controls.Add(lengthTextBox);
            rectanglesGroupBox.Controls.Add(rectanglesListBox);
            rectanglesGroupBox.Location = new Point(7, 6);
            rectanglesGroupBox.Margin = new Padding(3, 2, 3, 2);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Padding = new Padding(3, 2, 3, 2);
            rectanglesGroupBox.Size = new Size(241, 219);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(168, 177);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 13;
            IdLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(168, 194);
            idTextBox.Margin = new Padding(3, 2, 3, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(68, 23);
            idTextBox.TabIndex = 12;
            // 
            // labelCenterY
            // 
            labelCenterY.AutoSize = true;
            labelCenterY.Location = new Point(87, 177);
            labelCenterY.Name = "labelCenterY";
            labelCenterY.Size = new Size(55, 15);
            labelCenterY.TabIndex = 11;
            labelCenterY.Text = "Center Y:";
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(87, 194);
            textBoxCenterY.Margin = new Padding(3, 2, 3, 2);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.ReadOnly = true;
            textBoxCenterY.Size = new Size(77, 23);
            textBoxCenterY.TabIndex = 10;
            // 
            // labelCenterX
            // 
            labelCenterX.AutoSize = true;
            labelCenterX.Location = new Point(5, 177);
            labelCenterX.Name = "labelCenterX";
            labelCenterX.Size = new Size(55, 15);
            labelCenterX.TabIndex = 9;
            labelCenterX.Text = "Center X:";
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(5, 194);
            textBoxCenterX.Margin = new Padding(3, 2, 3, 2);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.ReadOnly = true;
            textBoxCenterX.Size = new Size(77, 23);
            textBoxCenterX.TabIndex = 8;
            // 
            // findRectangleButton
            // 
            findRectangleButton.Location = new Point(142, 151);
            findRectangleButton.Margin = new Padding(3, 2, 3, 2);
            findRectangleButton.Name = "findRectangleButton";
            findRectangleButton.Size = new Size(82, 22);
            findRectangleButton.TabIndex = 7;
            findRectangleButton.Text = "Find";
            findRectangleButton.UseVisualStyleBackColor = true;
            findRectangleButton.Click += findRectangleButton_Click;
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new Point(142, 99);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new Size(46, 15);
            colourLabel.TabIndex = 6;
            colourLabel.Text = "Colour:";
            // 
            // colourTextBox
            // 
            colourTextBox.Location = new Point(142, 116);
            colourTextBox.Margin = new Padding(3, 2, 3, 2);
            colourTextBox.Name = "colourTextBox";
            colourTextBox.Size = new Size(77, 23);
            colourTextBox.TabIndex = 5;
            colourTextBox.TextChanged += colourTextBox_TextChanged;
            // 
            // wideLabel
            // 
            wideLabel.AutoSize = true;
            wideLabel.Location = new Point(142, 59);
            wideLabel.Name = "wideLabel";
            wideLabel.Size = new Size(37, 15);
            wideLabel.TabIndex = 4;
            wideLabel.Text = "Wide:";
            // 
            // wideTextBox
            // 
            wideTextBox.Location = new Point(142, 76);
            wideTextBox.Margin = new Padding(3, 2, 3, 2);
            wideTextBox.Name = "wideTextBox";
            wideTextBox.Size = new Size(77, 23);
            wideTextBox.TabIndex = 3;
            wideTextBox.TextChanged += wideTextBox_TextChanged;
            // 
            // lengthButton
            // 
            lengthButton.AutoSize = true;
            lengthButton.Location = new Point(142, 20);
            lengthButton.Name = "lengthButton";
            lengthButton.Size = new Size(47, 15);
            lengthButton.TabIndex = 2;
            lengthButton.Text = "Length:";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(142, 37);
            lengthTextBox.Margin = new Padding(3, 2, 3, 2);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(77, 23);
            lengthTextBox.TabIndex = 1;
            lengthTextBox.TextChanged += lengthTextBox_TextChanged;
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.FormattingEnabled = true;
            rectanglesListBox.ItemHeight = 15;
            rectanglesListBox.Location = new Point(5, 20);
            rectanglesListBox.Margin = new Padding(3, 2, 3, 2);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(132, 154);
            rectanglesListBox.TabIndex = 0;
            rectanglesListBox.SelectedIndexChanged += rectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(RectanglesHeigthTextBox);
            RectanglesTabPage.Controls.Add(RectanglesWidthTextBox);
            RectanglesTabPage.Controls.Add(RectanglesYTextBox);
            RectanglesTabPage.Controls.Add(RectanglesXTextBox);
            RectanglesTabPage.Controls.Add(RectanglesSelctedRectLabel);
            RectanglesTabPage.Controls.Add(RectanglesIDTextBox);
            RectanglesTabPage.Controls.Add(DelRectPictBox);
            RectanglesTabPage.Controls.Add(AddRectPictBox);
            RectanglesTabPage.Controls.Add(ReactanglesCollisionLabel);
            RectanglesTabPage.Controls.Add(RectanglesCollisionListBox);
            RectanglesTabPage.Controls.Add(RectanglesPanel);
            RectanglesTabPage.Controls.Add(RectanglesWidthLabel);
            RectanglesTabPage.Controls.Add(RectanglesHeigthLabel);
            RectanglesTabPage.Controls.Add(RectanglesYLabel);
            RectanglesTabPage.Controls.Add(RectanglesXLabel);
            RectanglesTabPage.Controls.Add(RectanglesIDLabel);
            RectanglesTabPage.Location = new Point(4, 24);
            RectanglesTabPage.Margin = new Padding(3, 2, 3, 2);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Size = new Size(717, 380);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesHeigthTextBox
            // 
            RectanglesHeigthTextBox.Location = new Point(88, 299);
            RectanglesHeigthTextBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesHeigthTextBox.Name = "RectanglesHeigthTextBox";
            RectanglesHeigthTextBox.Size = new Size(89, 23);
            RectanglesHeigthTextBox.TabIndex = 13;
            RectanglesHeigthTextBox.TextChanged += RectanglesHeigthTextBox_TextChanged;
            // 
            // RectanglesWidthTextBox
            // 
            RectanglesWidthTextBox.Location = new Point(88, 274);
            RectanglesWidthTextBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            RectanglesWidthTextBox.Size = new Size(89, 23);
            RectanglesWidthTextBox.TabIndex = 11;
            RectanglesWidthTextBox.TextChanged += RectanglesWidthTextBox_TextChanged;
            // 
            // RectanglesYTextBox
            // 
            RectanglesYTextBox.Location = new Point(88, 250);
            RectanglesYTextBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesYTextBox.Name = "RectanglesYTextBox";
            RectanglesYTextBox.Size = new Size(89, 23);
            RectanglesYTextBox.TabIndex = 9;
            RectanglesYTextBox.TextChanged += RectanglesYTextBox_TextChanged;
            // 
            // RectanglesXTextBox
            // 
            RectanglesXTextBox.Location = new Point(88, 225);
            RectanglesXTextBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesXTextBox.Name = "RectanglesXTextBox";
            RectanglesXTextBox.Size = new Size(89, 23);
            RectanglesXTextBox.TabIndex = 7;
            RectanglesXTextBox.TextChanged += RectanglesXTextBox_TextChanged;
            // 
            // RectanglesSelctedRectLabel
            // 
            RectanglesSelctedRectLabel.AutoSize = true;
            RectanglesSelctedRectLabel.Location = new Point(47, 183);
            RectanglesSelctedRectLabel.Name = "RectanglesSelctedRectLabel";
            RectanglesSelctedRectLabel.Size = new Size(115, 15);
            RectanglesSelctedRectLabel.TabIndex = 5;
            RectanglesSelctedRectLabel.Text = "Selected Reactangle:";
            // 
            // RectanglesIDTextBox
            // 
            RectanglesIDTextBox.Location = new Point(88, 200);
            RectanglesIDTextBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesIDTextBox.Name = "RectanglesIDTextBox";
            RectanglesIDTextBox.ReadOnly = true;
            RectanglesIDTextBox.Size = new Size(89, 23);
            RectanglesIDTextBox.TabIndex = 4;
            // 
            // DelRectPictBox
            // 
            DelRectPictBox.Image = (Image)resources.GetObject("DelRectPictBox.Image");
            DelRectPictBox.Location = new Point(47, 151);
            DelRectPictBox.Margin = new Padding(3, 2, 3, 2);
            DelRectPictBox.Name = "DelRectPictBox";
            DelRectPictBox.Size = new Size(35, 30);
            DelRectPictBox.SizeMode = PictureBoxSizeMode.Zoom;
            DelRectPictBox.TabIndex = 3;
            DelRectPictBox.TabStop = false;
            DelRectPictBox.Click += DelRectPictBox_Click;
            DelRectPictBox.MouseLeave += DelRectPictBox_MouseLeave;
            DelRectPictBox.MouseMove += DelRectPictBox_MouseMove;
            // 
            // AddRectPictBox
            // 
            AddRectPictBox.Image = (Image)resources.GetObject("AddRectPictBox.Image");
            AddRectPictBox.Location = new Point(7, 151);
            AddRectPictBox.Margin = new Padding(3, 2, 3, 2);
            AddRectPictBox.Name = "AddRectPictBox";
            AddRectPictBox.Size = new Size(35, 30);
            AddRectPictBox.SizeMode = PictureBoxSizeMode.Zoom;
            AddRectPictBox.TabIndex = 2;
            AddRectPictBox.TabStop = false;
            AddRectPictBox.Click += AddRectPictBox_Click;
            AddRectPictBox.MouseLeave += AddRectPictBox_MouseLeave;
            AddRectPictBox.MouseMove += AddRectPictBox_MouseMove;
            // 
            // ReactanglesCollisionLabel
            // 
            ReactanglesCollisionLabel.AutoSize = true;
            ReactanglesCollisionLabel.Location = new Point(7, 6);
            ReactanglesCollisionLabel.Name = "ReactanglesCollisionLabel";
            ReactanglesCollisionLabel.Size = new Size(73, 15);
            ReactanglesCollisionLabel.TabIndex = 1;
            ReactanglesCollisionLabel.Text = "Reactangles:";
            // 
            // RectanglesCollisionListBox
            // 
            RectanglesCollisionListBox.FormattingEnabled = true;
            RectanglesCollisionListBox.ItemHeight = 15;
            RectanglesCollisionListBox.Location = new Point(7, 23);
            RectanglesCollisionListBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesCollisionListBox.Name = "RectanglesCollisionListBox";
            RectanglesCollisionListBox.Size = new Size(302, 124);
            RectanglesCollisionListBox.TabIndex = 0;
            RectanglesCollisionListBox.SelectedIndexChanged += RectanglesCollisionListBox_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(313, 6);
            RectanglesPanel.Margin = new Padding(3, 2, 3, 2);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(398, 372);
            RectanglesPanel.TabIndex = 0;
            // 
            // RectanglesWidthLabel
            // 
            RectanglesWidthLabel.AutoSize = true;
            RectanglesWidthLabel.Location = new Point(37, 277);
            RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            RectanglesWidthLabel.Size = new Size(42, 15);
            RectanglesWidthLabel.TabIndex = 12;
            RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesHeigthLabel
            // 
            RectanglesHeigthLabel.AutoSize = true;
            RectanglesHeigthLabel.Location = new Point(33, 302);
            RectanglesHeigthLabel.Name = "RectanglesHeigthLabel";
            RectanglesHeigthLabel.Size = new Size(46, 15);
            RectanglesHeigthLabel.TabIndex = 14;
            RectanglesHeigthLabel.Text = "Height:";
            // 
            // RectanglesYLabel
            // 
            RectanglesYLabel.AutoSize = true;
            RectanglesYLabel.Location = new Point(65, 252);
            RectanglesYLabel.Name = "RectanglesYLabel";
            RectanglesYLabel.Size = new Size(17, 15);
            RectanglesYLabel.TabIndex = 10;
            RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesXLabel
            // 
            RectanglesXLabel.AutoSize = true;
            RectanglesXLabel.Location = new Point(65, 225);
            RectanglesXLabel.Name = "RectanglesXLabel";
            RectanglesXLabel.Size = new Size(17, 15);
            RectanglesXLabel.TabIndex = 8;
            RectanglesXLabel.Text = "X:";
            // 
            // RectanglesIDLabel
            // 
            RectanglesIDLabel.AutoSize = true;
            RectanglesIDLabel.Location = new Point(60, 202);
            RectanglesIDLabel.Name = "RectanglesIDLabel";
            RectanglesIDLabel.Size = new Size(21, 15);
            RectanglesIDLabel.TabIndex = 6;
            RectanglesIDLabel.Text = "ID:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 408);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programming Demo";
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
            ClasssesTabPage.ResumeLayout(false);
            movieGroupBox.ResumeLayout(false);
            movieGroupBox.PerformLayout();
            rectanglesGroupBox.ResumeLayout(false);
            rectanglesGroupBox.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            RectanglesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DelRectPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddRectPictBox).EndInit();
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
        private Label IntValueLabel;
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
        private TabPage ClasssesTabPage;
        private GroupBox rectanglesGroupBox;
        private Button findRectangleButton;
        private Label colourLabel;
        private TextBox colourTextBox;
        private Label wideLabel;
        private TextBox wideTextBox;
        private Label lengthButton;
        private TextBox lengthTextBox;
        private ListBox rectanglesListBox;
        private GroupBox movieGroupBox;
        private Button movieFindButton;
        private Label movieReleaseYearLabel;
        private TextBox movieReleaseYearTextBox;
        private Label movieDurationLabel;
        private TextBox movieDurationTextBox;
        private Label movieNameLabel;
        private TextBox movieNameTextBox;
        private ListBox MovieListBox;
        private Label movieRatingLabel;
        private TextBox movieRatingTextBox;
        private Label movieGenreLabel;
        private TextBox movieGenreTextBox;
        private Label labelCenterY;
        private TextBox textBoxCenterY;
        private Label labelCenterX;
        private TextBox textBoxCenterX;
        private Label IdLabel;
        private TextBox idTextBox;
        private TabPage RectanglesTabPage;
        private Panel RectanglesPanel;
        private ListBox RectanglesCollisionListBox;
        private Label ReactanglesCollisionLabel;
        private PictureBox AddRectPictBox;
        private PictureBox DelRectPictBox;
        private Label RectanglesHeigthLabel;
        private TextBox RectanglesHeigthTextBox;
        private Label RectanglesWidthLabel;
        private TextBox RectanglesWidthTextBox;
        private Label RectanglesYLabel;
        private TextBox RectanglesYTextBox;
        private Label RectanglesXLabel;
        private TextBox RectanglesXTextBox;
        private Label RectanglesIDLabel;
        private Label RectanglesSelctedRectLabel;
        private TextBox RectanglesIDTextBox;
    }
}
