using System;

namespace EAS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ForgotPassL = new System.Windows.Forms.Label();
            this.SignUpLL = new System.Windows.Forms.LinkLabel();
            this.SignInB = new System.Windows.Forms.Button();
            this.UserNameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(23, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 202);
            this.panel1.TabIndex = 0;
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(288, 129);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(218, 20);
            this.UserNameTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(288, 186);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(218, 20);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // ForgotPassL
            // 
            this.ForgotPassL.AutoSize = true;
            this.ForgotPassL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassL.Location = new System.Drawing.Point(285, 241);
            this.ForgotPassL.Name = "ForgotPassL";
            this.ForgotPassL.Size = new System.Drawing.Size(137, 16);
            this.ForgotPassL.TabIndex = 3;
            this.ForgotPassL.Text = "Forget Password ?";
            // 
            // SignUpLL
            // 
            this.SignUpLL.AutoSize = true;
            this.SignUpLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLL.Location = new System.Drawing.Point(447, 241);
            this.SignUpLL.Name = "SignUpLL";
            this.SignUpLL.Size = new System.Drawing.Size(59, 16);
            this.SignUpLL.TabIndex = 4;
            this.SignUpLL.TabStop = true;
            this.SignUpLL.Text = "SignUp";
            this.SignUpLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLL_LinkClicked);
            // 
            // SignInB
            // 
            this.SignInB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInB.Location = new System.Drawing.Point(288, 294);
            this.SignInB.Name = "SignInB";
            this.SignInB.Size = new System.Drawing.Size(218, 39);
            this.SignInB.TabIndex = 5;
            this.SignInB.Text = "Sign In";
            this.SignInB.UseVisualStyleBackColor = true;
            this.SignInB.Click += new System.EventHandler(this.SignInB_Click);
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.Location = new System.Drawing.Point(285, 110);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(86, 16);
            this.UserNameL.TabIndex = 7;
            this.UserNameL.Text = "User Name";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(285, 167);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(76, 16);
            this.PasswordL.TabIndex = 8;
            this.PasswordL.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 482);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.SignInB);
            this.Controls.Add(this.SignUpLL);
            this.Controls.Add(this.ForgotPassL);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }





        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label ForgotPassL;
        private System.Windows.Forms.LinkLabel SignUpLL;
        private System.Windows.Forms.Button SignInB;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label PasswordL;
    }
}