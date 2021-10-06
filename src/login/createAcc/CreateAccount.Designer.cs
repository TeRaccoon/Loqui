
namespace Loqui.src.login.createAcc
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.createAccount_btn = new System.Windows.Forms.Button();
            this.showPassword_check = new System.Windows.Forms.CheckBox();
            this.passwordFeedback_lbl = new System.Windows.Forms.Label();
            this.pointScore_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.Location = new System.Drawing.Point(117, 65);
            this.username_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.username_txt.Multiline = true;
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(164, 23);
            this.username_txt.TabIndex = 15;
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(117, 113);
            this.password_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(164, 23);
            this.password_txt.TabIndex = 14;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lbl.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(5, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(415, 32);
            this.title_lbl.TabIndex = 13;
            this.title_lbl.Text = "Loqui Create Account";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.password_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(17, 116);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(98, 16);
            this.password_lbl.TabIndex = 12;
            this.password_lbl.Text = "Password:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(17, 69);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(98, 16);
            this.username_lbl.TabIndex = 11;
            this.username_lbl.Text = "Username:";
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.BackColor = System.Drawing.Color.White;
            this.createAccount_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount_btn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount_btn.Location = new System.Drawing.Point(148, 223);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(118, 24);
            this.createAccount_btn.TabIndex = 17;
            this.createAccount_btn.Text = "Create Account";
            this.createAccount_btn.UseVisualStyleBackColor = false;
            this.createAccount_btn.Click += new System.EventHandler(this.createAccount_btn_Click);
            // 
            // showPassword_check
            // 
            this.showPassword_check.AutoSize = true;
            this.showPassword_check.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_check.Location = new System.Drawing.Point(289, 115);
            this.showPassword_check.Name = "showPassword_check";
            this.showPassword_check.Size = new System.Drawing.Size(102, 17);
            this.showPassword_check.TabIndex = 18;
            this.showPassword_check.Text = "Show Password";
            this.showPassword_check.UseVisualStyleBackColor = false;
            this.showPassword_check.CheckedChanged += new System.EventHandler(this.showPassword_check_CheckedChanged);
            // 
            // passwordFeedback_lbl
            // 
            this.passwordFeedback_lbl.AutoSize = true;
            this.passwordFeedback_lbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordFeedback_lbl.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFeedback_lbl.Location = new System.Drawing.Point(12, 175);
            this.passwordFeedback_lbl.MaximumSize = new System.Drawing.Size(411, 135);
            this.passwordFeedback_lbl.Name = "passwordFeedback_lbl";
            this.passwordFeedback_lbl.Size = new System.Drawing.Size(0, 11);
            this.passwordFeedback_lbl.TabIndex = 19;
            // 
            // pointScore_lbl
            // 
            this.pointScore_lbl.AutoSize = true;
            this.pointScore_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pointScore_lbl.Location = new System.Drawing.Point(115, 140);
            this.pointScore_lbl.Name = "pointScore_lbl";
            this.pointScore_lbl.Size = new System.Drawing.Size(0, 13);
            this.pointScore_lbl.TabIndex = 20;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loqui.Properties.Resources.white_background;
            this.ClientSize = new System.Drawing.Size(425, 259);
            this.Controls.Add(this.pointScore_lbl);
            this.Controls.Add(this.passwordFeedback_lbl);
            this.Controls.Add(this.showPassword_check);
            this.Controls.Add(this.createAccount_btn);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.Text = "Create Loqui Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button createAccount_btn;
        private System.Windows.Forms.CheckBox showPassword_check;
        private System.Windows.Forms.Label passwordFeedback_lbl;
        private System.Windows.Forms.Label pointScore_lbl;
    }
}