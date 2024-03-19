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
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3, 3, 3, 3);
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
            EnumsGroupBox.Location = new Point(8, 3);
            EnumsGroupBox.Name = "EnumsGroupBox";
            EnumsGroupBox.Size = new Size(807, 327);
            EnumsGroupBox.TabIndex = 2;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Controls.Add(ClasssesTabPage);
            tabControl1.Controls.Add(RectanglesTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(829, 544);
            tabControl1.TabIndex = 0;
            // 
            // ClasssesTabPage
            // 
            ClasssesTabPage.Controls.Add(movieGroupBox);
            ClasssesTabPage.Controls.Add(rectanglesGroupBox);
            ClasssesTabPage.Location = new Point(4, 29);
            ClasssesTabPage.Name = "ClasssesTabPage";
            ClasssesTabPage.Padding = new Padding(3, 3, 3, 3);
            ClasssesTabPage.Size = new Size(821, 511);
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
            movieGroupBox.Location = new Point(289, 8);
            movieGroupBox.Name = "movieGroupBox";
            movieGroupBox.Size = new Size(523, 292);
            movieGroupBox.TabIndex = 8;
            movieGroupBox.TabStop = false;
            movieGroupBox.Text = "Movies";
            // 
            // movieRatingLabel
            // 
            movieRatingLabel.AutoSize = true;
            movieRatingLabel.Location = new Point(305, 79);
            movieRatingLabel.Name = "movieRatingLabel";
            movieRatingLabel.Size = new Size(55, 20);
            movieRatingLabel.TabIndex = 11;
            movieRatingLabel.Text = "Rating:";
            // 
            // movieRatingTextBox
            // 
            movieRatingTextBox.Location = new Point(305, 101);
            movieRatingTextBox.Name = "movieRatingTextBox";
            movieRatingTextBox.Size = new Size(137, 27);
            movieRatingTextBox.TabIndex = 10;
            movieRatingTextBox.TextChanged += movieRatingTextBox_TextChanged;
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.AutoSize = true;
            movieGenreLabel.Location = new Point(305, 27);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new Size(51, 20);
            movieGenreLabel.TabIndex = 9;
            movieGenreLabel.Text = "Genre:";
            // 
            // movieGenreTextBox
            // 
            movieGenreTextBox.Location = new Point(305, 49);
            movieGenreTextBox.Name = "movieGenreTextBox";
            movieGenreTextBox.ReadOnly = true;
            movieGenreTextBox.Size = new Size(137, 27);
            movieGenreTextBox.TabIndex = 8;
            // 
            // movieFindButton
            // 
            movieFindButton.Location = new Point(162, 201);
            movieFindButton.Name = "movieFindButton";
            movieFindButton.Size = new Size(94, 29);
            movieFindButton.TabIndex = 7;
            movieFindButton.Text = "Find";
            movieFindButton.UseVisualStyleBackColor = true;
            movieFindButton.Click += movieFindButton_Click;
            // 
            // movieReleaseYearLabel
            // 
            movieReleaseYearLabel.AutoSize = true;
            movieReleaseYearLabel.Location = new Point(162, 132);
            movieReleaseYearLabel.Name = "movieReleaseYearLabel";
            movieReleaseYearLabel.Size = new Size(95, 20);
            movieReleaseYearLabel.TabIndex = 6;
            movieReleaseYearLabel.Text = "Release Year:";
            // 
            // movieReleaseYearTextBox
            // 
            movieReleaseYearTextBox.Location = new Point(162, 155);
            movieReleaseYearTextBox.Name = "movieReleaseYearTextBox";
            movieReleaseYearTextBox.ReadOnly = true;
            movieReleaseYearTextBox.Size = new Size(137, 27);
            movieReleaseYearTextBox.TabIndex = 5;
            // 
            // movieDurationLabel
            // 
            movieDurationLabel.AutoSize = true;
            movieDurationLabel.Location = new Point(162, 79);
            movieDurationLabel.Name = "movieDurationLabel";
            movieDurationLabel.Size = new Size(136, 20);
            movieDurationLabel.TabIndex = 4;
            movieDurationLabel.Text = "Duration (minutes):";
            // 
            // movieDurationTextBox
            // 
            movieDurationTextBox.Location = new Point(162, 101);
            movieDurationTextBox.Name = "movieDurationTextBox";
            movieDurationTextBox.ReadOnly = true;
            movieDurationTextBox.Size = new Size(137, 27);
            movieDurationTextBox.TabIndex = 3;
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Location = new Point(162, 27);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(52, 20);
            movieNameLabel.TabIndex = 2;
            movieNameLabel.Text = "Name:";
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.Location = new Point(162, 49);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.ReadOnly = true;
            movieNameTextBox.Size = new Size(137, 27);
            movieNameTextBox.TabIndex = 1;
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.Location = new Point(6, 27);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(150, 204);
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
            rectanglesGroupBox.Location = new Point(8, 8);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(275, 292);
            rectanglesGroupBox.TabIndex = 0;
            rectanglesGroupBox.TabStop = false;
            rectanglesGroupBox.Text = "Rectangles";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(192, 236);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 13;
            IdLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(192, 259);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(77, 27);
            idTextBox.TabIndex = 12;
            // 
            // labelCenterY
            // 
            labelCenterY.AutoSize = true;
            labelCenterY.Location = new Point(99, 236);
            labelCenterY.Name = "labelCenterY";
            labelCenterY.Size = new Size(67, 20);
            labelCenterY.TabIndex = 11;
            labelCenterY.Text = "Center Y:";
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(99, 259);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.ReadOnly = true;
            textBoxCenterY.Size = new Size(87, 27);
            textBoxCenterY.TabIndex = 10;
            // 
            // labelCenterX
            // 
            labelCenterX.AutoSize = true;
            labelCenterX.Location = new Point(6, 236);
            labelCenterX.Name = "labelCenterX";
            labelCenterX.Size = new Size(68, 20);
            labelCenterX.TabIndex = 9;
            labelCenterX.Text = "Center X:";
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(6, 259);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.ReadOnly = true;
            textBoxCenterX.Size = new Size(87, 27);
            textBoxCenterX.TabIndex = 8;
            // 
            // findRectangleButton
            // 
            findRectangleButton.Location = new Point(162, 201);
            findRectangleButton.Name = "findRectangleButton";
            findRectangleButton.Size = new Size(94, 29);
            findRectangleButton.TabIndex = 7;
            findRectangleButton.Text = "Find";
            findRectangleButton.UseVisualStyleBackColor = true;
            findRectangleButton.Click += findRectangleButton_Click;
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new Point(162, 132);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new Size(56, 20);
            colourLabel.TabIndex = 6;
            colourLabel.Text = "Colour:";
            // 
            // colourTextBox
            // 
            colourTextBox.Location = new Point(162, 155);
            colourTextBox.Name = "colourTextBox";
            colourTextBox.Size = new Size(87, 27);
            colourTextBox.TabIndex = 5;
            colourTextBox.TextChanged += colourTextBox_TextChanged;
            // 
            // wideLabel
            // 
            wideLabel.AutoSize = true;
            wideLabel.Location = new Point(162, 79);
            wideLabel.Name = "wideLabel";
            wideLabel.Size = new Size(47, 20);
            wideLabel.TabIndex = 4;
            wideLabel.Text = "Wide:";
            // 
            // wideTextBox
            // 
            wideTextBox.Location = new Point(162, 101);
            wideTextBox.Name = "wideTextBox";
            wideTextBox.Size = new Size(87, 27);
            wideTextBox.TabIndex = 3;
            wideTextBox.TextChanged += wideTextBox_TextChanged;
            // 
            // lengthButton
            // 
            lengthButton.AutoSize = true;
            lengthButton.Location = new Point(162, 27);
            lengthButton.Name = "lengthButton";
            lengthButton.Size = new Size(57, 20);
            lengthButton.TabIndex = 2;
            lengthButton.Text = "Length:";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(162, 49);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(87, 27);
            lengthTextBox.TabIndex = 1;
            lengthTextBox.TextChanged += lengthTextBox_TextChanged;
            // 
            // rectanglesListBox
            // 
            rectanglesListBox.FormattingEnabled = true;
            rectanglesListBox.Location = new Point(6, 27);
            rectanglesListBox.Name = "rectanglesListBox";
            rectanglesListBox.Size = new Size(150, 204);
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
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Size = new Size(821, 511);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesHeigthTextBox
            // 
            RectanglesHeigthTextBox.Location = new Point(101, 399);
            RectanglesHeigthTextBox.Name = "RectanglesHeigthTextBox";
            RectanglesHeigthTextBox.Size = new Size(101, 27);
            RectanglesHeigthTextBox.TabIndex = 13;
            RectanglesHeigthTextBox.TextChanged += RectanglesHeigthTextBox_TextChanged;
            // 
            // RectanglesWidthTextBox
            // 
            RectanglesWidthTextBox.Location = new Point(101, 365);
            RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            RectanglesWidthTextBox.Size = new Size(101, 27);
            RectanglesWidthTextBox.TabIndex = 11;
            RectanglesWidthTextBox.TextChanged += RectanglesWidthTextBox_TextChanged;
            // 
            // RectanglesYTextBox
            // 
            RectanglesYTextBox.Location = new Point(101, 333);
            RectanglesYTextBox.Name = "RectanglesYTextBox";
            RectanglesYTextBox.Size = new Size(101, 27);
            RectanglesYTextBox.TabIndex = 9;
            RectanglesYTextBox.TextChanged += RectanglesYTextBox_TextChanged;
            // 
            // RectanglesXTextBox
            // 
            RectanglesXTextBox.Location = new Point(101, 300);
            RectanglesXTextBox.Name = "RectanglesXTextBox";
            RectanglesXTextBox.Size = new Size(101, 27);
            RectanglesXTextBox.TabIndex = 7;
            RectanglesXTextBox.TextChanged += RectanglesXTextBox_TextChanged;
            // 
            // RectanglesSelctedRectLabel
            // 
            RectanglesSelctedRectLabel.AutoSize = true;
            RectanglesSelctedRectLabel.Location = new Point(54, 244);
            RectanglesSelctedRectLabel.Name = "RectanglesSelctedRectLabel";
            RectanglesSelctedRectLabel.Size = new Size(147, 20);
            RectanglesSelctedRectLabel.TabIndex = 5;
            RectanglesSelctedRectLabel.Text = "Selected Reactangle:";
            // 
            // RectanglesIDTextBox
            // 
            RectanglesIDTextBox.Location = new Point(101, 267);
            RectanglesIDTextBox.Name = "RectanglesIDTextBox";
            RectanglesIDTextBox.ReadOnly = true;
            RectanglesIDTextBox.Size = new Size(101, 27);
            RectanglesIDTextBox.TabIndex = 4;
            // 
            // DelRectPictBox
            // 
            DelRectPictBox.Image = (Image)resources.GetObject("DelRectPictBox.Image");
            DelRectPictBox.Location = new Point(54, 201);
            DelRectPictBox.Name = "DelRectPictBox";
            DelRectPictBox.Size = new Size(40, 40);
            DelRectPictBox.SizeMode = PictureBoxSizeMode.Zoom;
            DelRectPictBox.TabIndex = 3;
            DelRectPictBox.TabStop = false;
            DelRectPictBox.Click += DelRectPictBox_Click;
            DelRectPictBox.MouseLeave += DelRectPictBox_MouseLeave;
            DelRectPictBox.MouseMove += DelRectPictBox_MouseMove;
            // 
            // AddRectPictBox
            // 
            AddRectPictBox.Image = Properties.Resources.add_rectandle_button;
            AddRectPictBox.Location = new Point(8, 201);
            AddRectPictBox.Name = "AddRectPictBox";
            AddRectPictBox.Size = new Size(40, 40);
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
            ReactanglesCollisionLabel.Location = new Point(8, 8);
            ReactanglesCollisionLabel.Name = "ReactanglesCollisionLabel";
            ReactanglesCollisionLabel.Size = new Size(92, 20);
            ReactanglesCollisionLabel.TabIndex = 1;
            ReactanglesCollisionLabel.Text = "Reactangles:";
            // 
            // RectanglesCollisionListBox
            // 
            RectanglesCollisionListBox.FormattingEnabled = true;
            RectanglesCollisionListBox.Location = new Point(8, 31);
            RectanglesCollisionListBox.Name = "RectanglesCollisionListBox";
            RectanglesCollisionListBox.Size = new Size(345, 164);
            RectanglesCollisionListBox.TabIndex = 0;
            RectanglesCollisionListBox.SelectedIndexChanged += RectanglesCollisionListBox_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(358, 8);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(455, 495);
            RectanglesPanel.TabIndex = 0;
            // 
            // RectanglesWidthLabel
            // 
            RectanglesWidthLabel.AutoSize = true;
            RectanglesWidthLabel.Location = new Point(42, 369);
            RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            RectanglesWidthLabel.Size = new Size(52, 20);
            RectanglesWidthLabel.TabIndex = 12;
            RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesHeigthLabel
            // 
            RectanglesHeigthLabel.AutoSize = true;
            RectanglesHeigthLabel.Location = new Point(38, 403);
            RectanglesHeigthLabel.Name = "RectanglesHeigthLabel";
            RectanglesHeigthLabel.Size = new Size(57, 20);
            RectanglesHeigthLabel.TabIndex = 14;
            RectanglesHeigthLabel.Text = "Height:";
            // 
            // RectanglesYLabel
            // 
            RectanglesYLabel.AutoSize = true;
            RectanglesYLabel.Location = new Point(74, 336);
            RectanglesYLabel.Name = "RectanglesYLabel";
            RectanglesYLabel.Size = new Size(20, 20);
            RectanglesYLabel.TabIndex = 10;
            RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesXLabel
            // 
            RectanglesXLabel.AutoSize = true;
            RectanglesXLabel.Location = new Point(74, 300);
            RectanglesXLabel.Name = "RectanglesXLabel";
            RectanglesXLabel.Size = new Size(21, 20);
            RectanglesXLabel.TabIndex = 8;
            RectanglesXLabel.Text = "X:";
            // 
            // RectanglesIDLabel
            // 
            RectanglesIDLabel.AutoSize = true;
            RectanglesIDLabel.Location = new Point(69, 269);
            RectanglesIDLabel.Name = "RectanglesIDLabel";
            RectanglesIDLabel.Size = new Size(27, 20);
            RectanglesIDLabel.TabIndex = 6;
            RectanglesIDLabel.Text = "ID:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 544);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
