
namespace Loqui.src.addUser
{
    partial class AddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriend));
            this.title_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.UID_txt = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.UIDText_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(47, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(172, 27);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Add Friend";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(202, 102);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(41, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // UID_txt
            // 
            this.UID_txt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID_txt.Location = new System.Drawing.Point(26, 102);
            this.UID_txt.Multiline = true;
            this.UID_txt.Name = "UID_txt";
            this.UID_txt.Size = new System.Drawing.Size(170, 23);
            this.UID_txt.TabIndex = 2;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(5, 152);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // UIDText_lbl
            // 
            this.UIDText_lbl.AutoSize = true;
            this.UIDText_lbl.BackColor = System.Drawing.Color.Transparent;
            this.UIDText_lbl.Location = new System.Drawing.Point(26, 83);
            this.UIDText_lbl.Name = "UIDText_lbl";
            this.UIDText_lbl.Size = new System.Drawing.Size(159, 11);
            this.UIDText_lbl.TabIndex = 4;
            this.UIDText_lbl.Text = "Enter your friends UID";
            // 
            // AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loqui.Properties.Resources.white_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 180);
            this.Controls.Add(this.UIDText_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.UID_txt);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.title_lbl);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFriend";
            this.Text = "Add Loqui Friend ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox UID_txt;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label UIDText_lbl;
    }
}