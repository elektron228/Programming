namespace Programming.View.TabPages
{
    partial class RectanglesCollisionTabPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionTabPage));
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
            ((System.ComponentModel.ISupportInitialize)DelRectPictBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddRectPictBox).BeginInit();
            SuspendLayout();
            // 
            // RectanglesHeigthTextBox
            // 
            RectanglesHeigthTextBox.Location = new Point(101, 399);
            RectanglesHeigthTextBox.Name = "RectanglesHeigthTextBox";
            RectanglesHeigthTextBox.Size = new Size(101, 27);
            RectanglesHeigthTextBox.TabIndex = 29;
            RectanglesHeigthTextBox.TextChanged += RectanglesHeigthTextBox_TextChanged;
            // 
            // RectanglesWidthTextBox
            // 
            RectanglesWidthTextBox.Location = new Point(101, 365);
            RectanglesWidthTextBox.Name = "RectanglesWidthTextBox";
            RectanglesWidthTextBox.Size = new Size(101, 27);
            RectanglesWidthTextBox.TabIndex = 27;
            RectanglesWidthTextBox.TextChanged += RectanglesWidthTextBox_TextChanged;
            // 
            // RectanglesYTextBox
            // 
            RectanglesYTextBox.Location = new Point(101, 333);
            RectanglesYTextBox.Name = "RectanglesYTextBox";
            RectanglesYTextBox.Size = new Size(101, 27);
            RectanglesYTextBox.TabIndex = 25;
            RectanglesYTextBox.TextChanged += RectanglesYTextBox_TextChanged;
            // 
            // RectanglesXTextBox
            // 
            RectanglesXTextBox.Location = new Point(101, 300);
            RectanglesXTextBox.Name = "RectanglesXTextBox";
            RectanglesXTextBox.Size = new Size(101, 27);
            RectanglesXTextBox.TabIndex = 23;
            RectanglesXTextBox.TextChanged += RectanglesXTextBox_TextChanged;
            // 
            // RectanglesSelctedRectLabel
            // 
            RectanglesSelctedRectLabel.AutoSize = true;
            RectanglesSelctedRectLabel.Location = new Point(54, 244);
            RectanglesSelctedRectLabel.Name = "RectanglesSelctedRectLabel";
            RectanglesSelctedRectLabel.Size = new Size(147, 20);
            RectanglesSelctedRectLabel.TabIndex = 21;
            RectanglesSelctedRectLabel.Text = "Selected Reactangle:";
            // 
            // RectanglesIDTextBox
            // 
            RectanglesIDTextBox.Location = new Point(101, 267);
            RectanglesIDTextBox.Name = "RectanglesIDTextBox";
            RectanglesIDTextBox.ReadOnly = true;
            RectanglesIDTextBox.Size = new Size(101, 27);
            RectanglesIDTextBox.TabIndex = 20;
            // 
            // DelRectPictBox
            // 
            DelRectPictBox.Image = (Image)resources.GetObject("DelRectPictBox.Image");
            DelRectPictBox.Location = new Point(54, 201);
            DelRectPictBox.Name = "DelRectPictBox";
            DelRectPictBox.Size = new Size(40, 40);
            DelRectPictBox.SizeMode = PictureBoxSizeMode.Zoom;
            DelRectPictBox.TabIndex = 19;
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
            AddRectPictBox.TabIndex = 18;
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
            ReactanglesCollisionLabel.TabIndex = 17;
            ReactanglesCollisionLabel.Text = "Reactangles:";
            // 
            // RectanglesCollisionListBox
            // 
            RectanglesCollisionListBox.FormattingEnabled = true;
            RectanglesCollisionListBox.Location = new Point(8, 31);
            RectanglesCollisionListBox.Name = "RectanglesCollisionListBox";
            RectanglesCollisionListBox.Size = new Size(345, 164);
            RectanglesCollisionListBox.TabIndex = 15;
            RectanglesCollisionListBox.SelectedIndexChanged += RectanglesCollisionListBox_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(358, 8);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(455, 495);
            RectanglesPanel.TabIndex = 16;
            // 
            // RectanglesWidthLabel
            // 
            RectanglesWidthLabel.AutoSize = true;
            RectanglesWidthLabel.Location = new Point(42, 369);
            RectanglesWidthLabel.Name = "RectanglesWidthLabel";
            RectanglesWidthLabel.Size = new Size(52, 20);
            RectanglesWidthLabel.TabIndex = 28;
            RectanglesWidthLabel.Text = "Width:";
            // 
            // RectanglesHeigthLabel
            // 
            RectanglesHeigthLabel.AutoSize = true;
            RectanglesHeigthLabel.Location = new Point(38, 403);
            RectanglesHeigthLabel.Name = "RectanglesHeigthLabel";
            RectanglesHeigthLabel.Size = new Size(57, 20);
            RectanglesHeigthLabel.TabIndex = 30;
            RectanglesHeigthLabel.Text = "Height:";
            // 
            // RectanglesYLabel
            // 
            RectanglesYLabel.AutoSize = true;
            RectanglesYLabel.Location = new Point(74, 336);
            RectanglesYLabel.Name = "RectanglesYLabel";
            RectanglesYLabel.Size = new Size(20, 20);
            RectanglesYLabel.TabIndex = 26;
            RectanglesYLabel.Text = "Y:";
            // 
            // RectanglesXLabel
            // 
            RectanglesXLabel.AutoSize = true;
            RectanglesXLabel.Location = new Point(74, 300);
            RectanglesXLabel.Name = "RectanglesXLabel";
            RectanglesXLabel.Size = new Size(21, 20);
            RectanglesXLabel.TabIndex = 24;
            RectanglesXLabel.Text = "X:";
            // 
            // RectanglesIDLabel
            // 
            RectanglesIDLabel.AutoSize = true;
            RectanglesIDLabel.Location = new Point(69, 269);
            RectanglesIDLabel.Name = "RectanglesIDLabel";
            RectanglesIDLabel.Size = new Size(27, 20);
            RectanglesIDLabel.TabIndex = 22;
            RectanglesIDLabel.Text = "ID:";
            // 
            // RectanglesCollisionTabPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesHeigthTextBox);
            Controls.Add(RectanglesWidthTextBox);
            Controls.Add(RectanglesYTextBox);
            Controls.Add(RectanglesXTextBox);
            Controls.Add(RectanglesSelctedRectLabel);
            Controls.Add(RectanglesIDTextBox);
            Controls.Add(DelRectPictBox);
            Controls.Add(AddRectPictBox);
            Controls.Add(ReactanglesCollisionLabel);
            Controls.Add(RectanglesCollisionListBox);
            Controls.Add(RectanglesPanel);
            Controls.Add(RectanglesWidthLabel);
            Controls.Add(RectanglesHeigthLabel);
            Controls.Add(RectanglesYLabel);
            Controls.Add(RectanglesXLabel);
            Controls.Add(RectanglesIDLabel);
            Name = "RectanglesCollisionTabPage";
            Size = new Size(821, 511);
            Load += RectanglesCollisionTabPage_Load;
            ((System.ComponentModel.ISupportInitialize)DelRectPictBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddRectPictBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RectanglesHeigthTextBox;
        private TextBox RectanglesWidthTextBox;
        private TextBox RectanglesYTextBox;
        private TextBox RectanglesXTextBox;
        private Label RectanglesSelctedRectLabel;
        private TextBox RectanglesIDTextBox;
        private PictureBox DelRectPictBox;
        private PictureBox AddRectPictBox;
        private Label ReactanglesCollisionLabel;
        private ListBox RectanglesCollisionListBox;
        private Panel RectanglesPanel;
        private Label RectanglesWidthLabel;
        private Label RectanglesHeigthLabel;
        private Label RectanglesYLabel;
        private Label RectanglesXLabel;
        private Label RectanglesIDLabel;
    }
}
