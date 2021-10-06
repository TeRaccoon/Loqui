
namespace Loqui.src.menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.userChats_txt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settings_img = new System.Windows.Forms.PictureBox();
            this.addFriend_img = new System.Windows.Forms.PictureBox();
            this.notification_img = new System.Windows.Forms.PictureBox();
            this.darkMode_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settings_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFriend_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img)).BeginInit();
            this.SuspendLayout();
            // 
            // userChats_txt
            // 
            this.userChats_txt.BackColor = System.Drawing.Color.White;
            this.userChats_txt.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userChats_txt.FormattingEnabled = true;
            this.userChats_txt.Location = new System.Drawing.Point(12, 38);
            this.userChats_txt.Name = "userChats_txt";
            this.userChats_txt.Size = new System.Drawing.Size(310, 368);
            this.userChats_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Chats:";
            // 
            // settings_img
            // 
            this.settings_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_img.BackColor = System.Drawing.Color.Transparent;
            this.settings_img.BackgroundImage = global::Loqui.Properties.Resources.settingsIcon;
            this.settings_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_img.InitialImage = global::Loqui.Properties.Resources.settingsIcon;
            this.settings_img.Location = new System.Drawing.Point(276, 417);
            this.settings_img.Name = "settings_img";
            this.settings_img.Size = new System.Drawing.Size(46, 44);
            this.settings_img.TabIndex = 0;
            this.settings_img.TabStop = false;
            this.settings_img.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // addFriend_img
            // 
            this.addFriend_img.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFriend_img.BackColor = System.Drawing.Color.Transparent;
            this.addFriend_img.BackgroundImage = global::Loqui.Properties.Resources.addFriend;
            this.addFriend_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFriend_img.Location = new System.Drawing.Point(220, 417);
            this.addFriend_img.Name = "addFriend_img";
            this.addFriend_img.Size = new System.Drawing.Size(50, 44);
            this.addFriend_img.TabIndex = 3;
            this.addFriend_img.TabStop = false;
            this.addFriend_img.Click += new System.EventHandler(this.addFriend_img_Click);
            // 
            // notification_img
            // 
            this.notification_img.BackColor = System.Drawing.Color.Transparent;
            this.notification_img.BackgroundImage = global::Loqui.Properties.Resources.user;
            this.notification_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notification_img.Location = new System.Drawing.Point(297, 7);
            this.notification_img.Name = "notification_img";
            this.notification_img.Size = new System.Drawing.Size(25, 25);
            this.notification_img.TabIndex = 4;
            this.notification_img.TabStop = false;
            this.notification_img.Click += new System.EventHandler(this.notification_img_Click);
            // 
            // darkMode_check
            // 
            this.darkMode_check.AutoSize = true;
            this.darkMode_check.BackColor = System.Drawing.Color.Transparent;
            this.darkMode_check.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkMode_check.Location = new System.Drawing.Point(6, 445);
            this.darkMode_check.Name = "darkMode_check";
            this.darkMode_check.Size = new System.Drawing.Size(80, 16);
            this.darkMode_check.TabIndex = 8;
            this.darkMode_check.Text = "Darkmode";
            this.darkMode_check.UseVisualStyleBackColor = false;
            this.darkMode_check.CheckedChanged += new System.EventHandler(this.darkMode_check_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loqui.Properties.Resources.white_background;
            this.ClientSize = new System.Drawing.Size(334, 467);
            this.Controls.Add(this.darkMode_check);
            this.Controls.Add(this.notification_img);
            this.Controls.Add(this.addFriend_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userChats_txt);
            this.Controls.Add(this.settings_img);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Loqui";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settings_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFriend_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox settings_img;
        private System.Windows.Forms.ListBox userChats_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox addFriend_img;
        private System.Windows.Forms.PictureBox notification_img;
        private System.Windows.Forms.CheckBox darkMode_check;
    }
}