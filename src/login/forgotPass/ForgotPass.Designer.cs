
namespace Loqui.src.login.forgotPass
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.password_txt = new System.Windows.Forms.TextBox();
            this.passwordRepeat_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.newPassword_lbl = new System.Windows.Forms.Label();
            this.newPassword2_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(218, 89);
            this.password_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(164, 23);
            this.password_txt.TabIndex = 0;
            // 
            // passwordRepeat_txt
            // 
            this.passwordRepeat_txt.Location = new System.Drawing.Point(218, 126);
            this.passwordRepeat_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passwordRepeat_txt.Name = "passwordRepeat_txt";
            this.passwordRepeat_txt.Size = new System.Drawing.Size(164, 23);
            this.passwordRepeat_txt.TabIndex = 1;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(218, 52);
            this.username_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(164, 23);
            this.username_txt.TabIndex = 2;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(97, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(252, 27);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "Forgot Password";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(59, 55);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(148, 16);
            this.username_lbl.TabIndex = 4;
            this.username_lbl.Text = "Enter Userame:";
            // 
            // newPassword_lbl
            // 
            this.newPassword_lbl.AutoSize = true;
            this.newPassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.newPassword_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword_lbl.Location = new System.Drawing.Point(59, 92);
            this.newPassword_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.newPassword_lbl.Name = "newPassword_lbl";
            this.newPassword_lbl.Size = new System.Drawing.Size(138, 16);
            this.newPassword_lbl.TabIndex = 5;
            this.newPassword_lbl.Text = "New Password:";
            // 
            // newPassword2_lbl
            // 
            this.newPassword2_lbl.AutoSize = true;
            this.newPassword2_lbl.BackColor = System.Drawing.Color.Transparent;
            this.newPassword2_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword2_lbl.Location = new System.Drawing.Point(59, 129);
            this.newPassword2_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.newPassword2_lbl.Name = "newPassword2_lbl";
            this.newPassword2_lbl.Size = new System.Drawing.Size(138, 16);
            this.newPassword2_lbl.TabIndex = 6;
            this.newPassword2_lbl.Text = "New Password:";
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(176, 168);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(125, 28);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::Loqui.Properties.Resources.white_background;
            this.ClientSize = new System.Drawing.Size(463, 230);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.newPassword2_lbl);
            this.Controls.Add(this.newPassword_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.passwordRepeat_txt);
            this.Controls.Add(this.password_txt);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ForgotPass";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox passwordRepeat_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label newPassword_lbl;
        private System.Windows.Forms.Label newPassword2_lbl;
        private System.Windows.Forms.Button submit_btn;
    }
}