
namespace Loqui
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_btn = new System.Windows.Forms.Button();
            this.forgotPassword_btn = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.darkMode_check = new System.Windows.Forms.CheckBox();
            this.createAccount_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPassword_check = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_btn.BackColor = System.Drawing.Color.White;
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(292, 113);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(85, 23);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // forgotPassword_btn
            // 
            this.forgotPassword_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forgotPassword_btn.BackColor = System.Drawing.Color.White;
            this.forgotPassword_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassword_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassword_btn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword_btn.Location = new System.Drawing.Point(5, 197);
            this.forgotPassword_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.forgotPassword_btn.Name = "forgotPassword_btn";
            this.forgotPassword_btn.Size = new System.Drawing.Size(124, 24);
            this.forgotPassword_btn.TabIndex = 1;
            this.forgotPassword_btn.Text = "Forgot Password";
            this.forgotPassword_btn.UseVisualStyleBackColor = false;
            this.forgotPassword_btn.Click += new System.EventHandler(this.ForgotPasswordBtn_Click);
            // 
            // username_lbl
            // 
            this.username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(18, 69);
            this.username_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(98, 16);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            this.password_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.Transparent;
            this.password_lbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(18, 116);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(98, 16);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password:";
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lbl.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(77, 9);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(0, 32);
            this.title_lbl.TabIndex = 4;
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password_txt
            // 
            this.password_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_txt.Location = new System.Drawing.Point(118, 113);
            this.password_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(164, 23);
            this.password_txt.TabIndex = 5;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txt_KeyPress);
            // 
            // username_txt
            // 
            this.username_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_txt.Location = new System.Drawing.Point(118, 65);
            this.username_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(164, 23);
            this.username_txt.TabIndex = 6;
            this.username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyDown);
            // 
            // darkMode_check
            // 
            this.darkMode_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darkMode_check.AutoSize = true;
            this.darkMode_check.BackColor = System.Drawing.Color.Transparent;
            this.darkMode_check.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkMode_check.Location = new System.Drawing.Point(332, 205);
            this.darkMode_check.Name = "darkMode_check";
            this.darkMode_check.Size = new System.Drawing.Size(80, 16);
            this.darkMode_check.TabIndex = 7;
            this.darkMode_check.Text = "Darkmode";
            this.darkMode_check.UseVisualStyleBackColor = false;
            this.darkMode_check.CheckedChanged += new System.EventHandler(this.DarkModeCheck_CheckedChanged);
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createAccount_btn.BackColor = System.Drawing.Color.White;
            this.createAccount_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount_btn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount_btn.Location = new System.Drawing.Point(148, 197);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(118, 24);
            this.createAccount_btn.TabIndex = 8;
            this.createAccount_btn.Text = "Create Account";
            this.createAccount_btn.UseVisualStyleBackColor = false;
            this.createAccount_btn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Loqui.Properties.Resources.loquiLogo_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showPassword_check
            // 
            this.showPassword_check.AutoSize = true;
            this.showPassword_check.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_check.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword_check.Location = new System.Drawing.Point(262, 143);
            this.showPassword_check.Name = "showPassword_check";
            this.showPassword_check.Size = new System.Drawing.Size(115, 16);
            this.showPassword_check.TabIndex = 10;
            this.showPassword_check.Text = "Show Password";
            this.showPassword_check.UseVisualStyleBackColor = false;
            this.showPassword_check.CheckedChanged += new System.EventHandler(this.showPassword_check_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loqui.Properties.Resources.white_background;
            this.ClientSize = new System.Drawing.Size(424, 227);
            this.Controls.Add(this.showPassword_check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createAccount_btn);
            this.Controls.Add(this.darkMode_check);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.forgotPassword_btn);
            this.Controls.Add(this.Login_btn);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.Text = "Loqui Login ";
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button forgotPassword_btn;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.CheckBox darkMode_check;
        private System.Windows.Forms.Button createAccount_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox showPassword_check;
        private System.Windows.Forms.Timer timer;
    }
}

