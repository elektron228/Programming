namespace InfoSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.SelectedProductLabel = new System.Windows.Forms.GroupBox();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EditProductPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteProductPictureBox = new System.Windows.Forms.PictureBox();
            this.AddProductPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedProductLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(12, 12);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(290, 394);
            this.ProductsListBox.TabIndex = 0;
            this.ProductsListBox.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged);
            // 
            // SelectedProductLabel
            // 
            this.SelectedProductLabel.Controls.Add(this.ProductCountLabel);
            this.SelectedProductLabel.Controls.Add(this.CategoryLabel);
            this.SelectedProductLabel.Controls.Add(this.ManufacturerLabel);
            this.SelectedProductLabel.Controls.Add(this.ProductNameLabel);
            this.SelectedProductLabel.Controls.Add(this.CategoryComboBox);
            this.SelectedProductLabel.Controls.Add(this.CountTextBox);
            this.SelectedProductLabel.Controls.Add(this.ManufacturerTextBox);
            this.SelectedProductLabel.Controls.Add(this.NameTextBox);
            this.SelectedProductLabel.Location = new System.Drawing.Point(308, 12);
            this.SelectedProductLabel.Name = "SelectedProductLabel";
            this.SelectedProductLabel.Size = new System.Drawing.Size(480, 140);
            this.SelectedProductLabel.TabIndex = 1;
            this.SelectedProductLabel.TabStop = false;
            this.SelectedProductLabel.Text = "Выбранный товар";
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.AutoSize = true;
            this.ProductCountLabel.Location = new System.Drawing.Point(23, 101);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(66, 13);
            this.ProductCountLabel.TabIndex = 9;
            this.ProductCountLabel.Text = "Количество";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(29, 74);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Категория";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 48);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(86, 13);
            this.ManufacturerLabel.TabIndex = 7;
            this.ManufacturerLabel.Text = "Производитель";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(32, 22);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(57, 13);
            this.ProductNameLabel.TabIndex = 6;
            this.ProductNameLabel.Text = "Название";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(95, 71);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(186, 21);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(95, 98);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(186, 20);
            this.CountTextBox.TabIndex = 4;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(95, 45);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(186, 20);
            this.ManufacturerTextBox.TabIndex = 3;
            this.ManufacturerTextBox.TextChanged += new System.EventHandler(this.ManufacturerTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(379, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // EditProductPictureBox
            // 
            this.EditProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditProductPictureBox.Image = global::InfoSystem.Properties.Resources.Change;
            this.EditProductPictureBox.Location = new System.Drawing.Point(48, 412);
            this.EditProductPictureBox.Name = "EditProductPictureBox";
            this.EditProductPictureBox.Size = new System.Drawing.Size(30, 30);
            this.EditProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditProductPictureBox.TabIndex = 4;
            this.EditProductPictureBox.TabStop = false;
            this.EditProductPictureBox.Click += new System.EventHandler(this.EditProductPictureBox_Click);
            // 
            // DeleteProductPictureBox
            // 
            this.DeleteProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProductPictureBox.Image = global::InfoSystem.Properties.Resources.Delete;
            this.DeleteProductPictureBox.Location = new System.Drawing.Point(84, 412);
            this.DeleteProductPictureBox.Name = "DeleteProductPictureBox";
            this.DeleteProductPictureBox.Size = new System.Drawing.Size(30, 30);
            this.DeleteProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteProductPictureBox.TabIndex = 3;
            this.DeleteProductPictureBox.TabStop = false;
            this.DeleteProductPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteProductPictureBox_MouseClick);
            // 
            // AddProductPictureBox
            // 
            this.AddProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductPictureBox.Image = global::InfoSystem.Properties.Resources.Create;
            this.AddProductPictureBox.Location = new System.Drawing.Point(12, 412);
            this.AddProductPictureBox.Name = "AddProductPictureBox";
            this.AddProductPictureBox.Size = new System.Drawing.Size(30, 30);
            this.AddProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddProductPictureBox.TabIndex = 2;
            this.AddProductPictureBox.TabStop = false;
            this.AddProductPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProductPictureBox_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditProductPictureBox);
            this.Controls.Add(this.DeleteProductPictureBox);
            this.Controls.Add(this.AddProductPictureBox);
            this.Controls.Add(this.SelectedProductLabel);
            this.Controls.Add(this.ProductsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectedProductLabel.ResumeLayout(false);
            this.SelectedProductLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.GroupBox SelectedProductLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox AddProductPictureBox;
        private System.Windows.Forms.PictureBox DeleteProductPictureBox;
        private System.Windows.Forms.PictureBox EditProductPictureBox;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ProductNameLabel;
    }
}

