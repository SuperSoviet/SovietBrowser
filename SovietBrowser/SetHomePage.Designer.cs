﻿using System.ComponentModel;

namespace EzClapsBrowser
{
    partial class SetHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(SetHomePage));
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.btnSaveHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(12, 12);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(433, 23);
            this.txtHomePage.TabIndex = 0;
            this.txtHomePage.TextChanged += new System.EventHandler(this.txtHomePage_TextChanged);
            // 
            // btnSaveHome
            // 
            this.btnSaveHome.Location = new System.Drawing.Point(469, 12);
            this.btnSaveHome.Name = "btnSaveHome";
            this.btnSaveHome.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHome.TabIndex = 1;
            this.btnSaveHome.Text = "Save";
            this.btnSaveHome.UseVisualStyleBackColor = true;
            this.btnSaveHome.Click += new System.EventHandler(this.btnSaveHome_Click);
            // 
            // SetHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 52);
            this.Controls.Add(this.btnSaveHome);
            this.Controls.Add(this.txtHomePage);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SetHomePage";
            this.Text = "SetHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Button btnSaveHome;
    }
}