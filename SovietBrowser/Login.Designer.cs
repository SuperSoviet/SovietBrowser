﻿namespace EzClapsBrowser {
  partial class Login {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
      this.lblUsername = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(10, 164);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(55, 13);
      this.lblUsername.TabIndex = 0;
      this.lblUsername.Text = "Username";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(12, 194);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(53, 13);
      this.lblPassword.TabIndex = 1;
      this.lblPassword.Text = "Password";
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(104, 157);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(242, 20);
      this.txtUsername.TabIndex = 2;
      this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(104, 187);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(242, 20);
      this.txtPassword.TabIndex = 3;
      this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
      this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(152, 222);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(75, 23);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::EzClapsBrowser.Properties.Resources.images;
      this.pictureBox1.InitialImage = global::EzClapsBrowser.Properties.Resources.images;
      this.pictureBox1.Location = new System.Drawing.Point(32, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(294, 136);
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 257);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblUsername);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(374, 300);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(374, 300);
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}