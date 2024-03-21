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
            enumsTabPage1 = new View.TabPages.EnumsTabPage();
            tabControl1 = new TabControl();
            ClasssesTabPage = new TabPage();
            classesTabPage1 = new View.TabPages.ClassesTabPage();
            RectanglesTabPage = new TabPage();
            rectanglesCollisionTabPage1 = new View.TabPages.RectanglesCollisionTabPage();
            EnumsTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            ClasssesTabPage.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(enumsTabPage1);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(821, 511);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // enumsTabPage1
            // 
            enumsTabPage1.Dock = DockStyle.Fill;
            enumsTabPage1.Location = new Point(3, 3);
            enumsTabPage1.Name = "enumsTabPage1";
            enumsTabPage1.Size = new Size(815, 505);
            enumsTabPage1.TabIndex = 0;
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
            ClasssesTabPage.Controls.Add(classesTabPage1);
            ClasssesTabPage.Location = new Point(4, 29);
            ClasssesTabPage.Name = "ClasssesTabPage";
            ClasssesTabPage.Padding = new Padding(3);
            ClasssesTabPage.Size = new Size(821, 511);
            ClasssesTabPage.TabIndex = 1;
            ClasssesTabPage.Text = "Classes";
            ClasssesTabPage.UseVisualStyleBackColor = true;
            // 
            // classesTabPage1
            // 
            classesTabPage1.Dock = DockStyle.Fill;
            classesTabPage1.Location = new Point(3, 3);
            classesTabPage1.Name = "classesTabPage1";
            classesTabPage1.Size = new Size(815, 505);
            classesTabPage1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(rectanglesCollisionTabPage1);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Size = new Size(821, 511);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionTabPage1
            // 
            rectanglesCollisionTabPage1.Dock = DockStyle.Fill;
            rectanglesCollisionTabPage1.Location = new Point(0, 0);
            rectanglesCollisionTabPage1.Name = "rectanglesCollisionTabPage1";
            rectanglesCollisionTabPage1.Size = new Size(821, 511);
            rectanglesCollisionTabPage1.TabIndex = 0;
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
            tabControl1.ResumeLayout(false);
            ClasssesTabPage.ResumeLayout(false);
            RectanglesTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage EnumsTabPage;
        private TabControl tabControl1;
        private TabPage ClasssesTabPage;
        private TabPage RectanglesTabPage;
        private View.TabPages.EnumsTabPage enumsTabPage1;
        private View.TabPages.ClassesTabPage classesTabPage1;
        private View.TabPages.RectanglesCollisionTabPage rectanglesCollisionTabPage1;
    }
}
