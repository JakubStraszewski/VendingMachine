﻿
namespace VendingMachineSYS
{
    partial class FrmDesserts
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
            this.btnBackDesserts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackDesserts
            // 
            this.btnBackDesserts.Location = new System.Drawing.Point(20, 20);
            this.btnBackDesserts.Name = "btnBackDesserts";
            this.btnBackDesserts.Size = new System.Drawing.Size(75, 25);
            this.btnBackDesserts.TabIndex = 0;
            this.btnBackDesserts.Text = "Back";
            this.btnBackDesserts.UseVisualStyleBackColor = true;
            this.btnBackDesserts.Click += new System.EventHandler(this.btnBackDesserts_Click);
            // 
            // FrmDesserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackDesserts);
            this.Name = "FrmDesserts";
            this.Text = "FrmDesserts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackDesserts;
    }
}