﻿namespace BTLyThuyet2
{
    partial class ComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngoại ngữ";
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật"});
            this.cboNgoaiNgu.Location = new System.Drawing.Point(228, 103);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(220, 28);
            this.cboNgoaiNgu.TabIndex = 1;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Controls.Add(this.label1);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNgoaiNgu;
    }
}