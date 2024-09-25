﻿namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(98, 13);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "DeliveryAddress";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 25);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(60, 13);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(4, 51);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 77);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 103);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(69, 22);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(70, 20);
            this.PostIndexTextBox.TabIndex = 5;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(69, 48);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(110, 20);
            this.CountryTextBox.TabIndex = 6;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(69, 74);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(254, 20);
            this.StreetTextBox.TabIndex = 7;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(69, 100);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(70, 20);
            this.BuildingTextBox.TabIndex = 8;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(209, 100);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(70, 20);
            this.ApartmentTextBox.TabIndex = 10;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(145, 103);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.ApartmentLabel.TabIndex = 9;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(215, 48);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(108, 20);
            this.CityTextBox.TabIndex = 12;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(185, 51);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 11;
            this.CityLabel.Text = "City:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PostIndexTextBox);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PostIndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(325, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
    }
}
