﻿namespace MagickConvertApp
{
    partial class FrmConvert
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnSelectSourceFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMeasurement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(184, 210);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 28);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Con&vert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(12, 143);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(116, 16);
            this.lblSourceFile.TabIndex = 1;
            this.lblSourceFile.Text = "Select Source File";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(184, 140);
            this.txtSourceFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(292, 22);
            this.txtSourceFile.TabIndex = 3;
            this.txtSourceFile.TextChanged += new System.EventHandler(this.txtSourceFile_TextChanged);
            // 
            // btnSelectSourceFile
            // 
            this.btnSelectSourceFile.Location = new System.Drawing.Point(483, 140);
            this.btnSelectSourceFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectSourceFile.Name = "btnSelectSourceFile";
            this.btnSelectSourceFile.Size = new System.Drawing.Size(32, 23);
            this.btnSelectSourceFile.TabIndex = 4;
            this.btnSelectSourceFile.Text = "...";
            this.btnSelectSourceFile.UseVisualStyleBackColor = true;
            this.btnSelectSourceFile.Click += new System.EventHandler(this.btnSelectSourceFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Destination Folder";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(184, 167);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(292, 22);
            this.txtDestination.TabIndex = 3;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(483, 167);
            this.btnSelectDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(32, 23);
            this.btnSelectDestination.TabIndex = 4;
            this.btnSelectDestination.Text = "...";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(279, 210);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Quality (%)";
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(184, 23);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(65, 22);
            this.txtQuality.TabIndex = 3;
            this.txtQuality.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Output Format";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP",
            "TIFF"});
            this.cboType.Location = new System.Drawing.Point(184, 50);
            this.cboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(129, 24);
            this.cboType.TabIndex = 5;
            this.cboType.Text = "JPG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dimensions (W x H)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(184, 79);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(53, 22);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Text = "100";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(261, 79);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(52, 22);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "x";
            // 
            // cboMeasurement
            // 
            this.cboMeasurement.FormattingEnabled = true;
            this.cboMeasurement.Items.AddRange(new object[] {
            "Percent",
            "Pixels"});
            this.cboMeasurement.Location = new System.Drawing.Point(319, 78);
            this.cboMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMeasurement.Name = "cboMeasurement";
            this.cboMeasurement.Size = new System.Drawing.Size(91, 24);
            this.cboMeasurement.TabIndex = 8;
            this.cboMeasurement.Text = "Percent";
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 252);
            this.Controls.Add(this.cboMeasurement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.btnSelectSourceFile);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSourceFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmConvert";
            this.Text = "MagickConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnSelectSourceFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMeasurement;
    }
}

