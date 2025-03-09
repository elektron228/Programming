namespace Programming.View.TabPages
{
    partial class ClassesTabPage
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
            movieGroupBox.SuspendLayout();
            rectanglesGroupBox.SuspendLayout();
            SuspendLayout();
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
            movieGroupBox.Location = new Point(284, 3);
            movieGroupBox.Name = "movieGroupBox";
            movieGroupBox.Size = new Size(526, 292);
            movieGroupBox.TabIndex = 10;
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
            rectanglesGroupBox.Location = new Point(3, 3);
            rectanglesGroupBox.Name = "rectanglesGroupBox";
            rectanglesGroupBox.Size = new Size(275, 292);
            rectanglesGroupBox.TabIndex = 9;
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
            // ClassesTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(movieGroupBox);
            Controls.Add(rectanglesGroupBox);
            Name = "ClassesTabPage";
            Size = new Size(821, 511);
            Load += ClassesTabPage_Load;
            movieGroupBox.ResumeLayout(false);
            movieGroupBox.PerformLayout();
            rectanglesGroupBox.ResumeLayout(false);
            rectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox movieGroupBox;
        private Label movieRatingLabel;
        private TextBox movieRatingTextBox;
        private Label movieGenreLabel;
        private TextBox movieGenreTextBox;
        private Button movieFindButton;
        private Label movieReleaseYearLabel;
        private TextBox movieReleaseYearTextBox;
        private Label movieDurationLabel;
        private TextBox movieDurationTextBox;
        private Label movieNameLabel;
        private TextBox movieNameTextBox;
        private ListBox MovieListBox;
        private GroupBox rectanglesGroupBox;
        private Label IdLabel;
        private TextBox idTextBox;
        private Label labelCenterY;
        private TextBox textBoxCenterY;
        private Label labelCenterX;
        private TextBox textBoxCenterX;
        private Button findRectangleButton;
        private Label colourLabel;
        private TextBox colourTextBox;
        private Label wideLabel;
        private TextBox wideTextBox;
        private Label lengthButton;
        private TextBox lengthTextBox;
        private ListBox rectanglesListBox;
    }
}
