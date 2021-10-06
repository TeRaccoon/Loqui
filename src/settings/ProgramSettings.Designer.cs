
namespace Loqui.src.settings
{
    partial class ProgramSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramSettings));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.changeBackground_btn = new System.Windows.Forms.Button();
            this.darkMode_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "LightBackground";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // changeBackground_btn
            // 
            this.changeBackground_btn.BackColor = System.Drawing.Color.White;
            this.changeBackground_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeBackground_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBackground_btn.Location = new System.Drawing.Point(12, 336);
            this.changeBackground_btn.Name = "changeBackground_btn";
            this.changeBackground_btn.Size = new System.Drawing.Size(136, 33);
            this.changeBackground_btn.TabIndex = 0;
            this.changeBackground_btn.Text = "Change Background";
            this.changeBackground_btn.UseVisualStyleBackColor = false;
            this.changeBackground_btn.Click += new System.EventHandler(this.changeBackground_btn_Click);
            // 
            // darkMode_check
            // 
            this.darkMode_check.AutoSize = true;
            this.darkMode_check.BackColor = System.Drawing.Color.Transparent;
            this.darkMode_check.Location = new System.Drawing.Point(503, 354);
            this.darkMode_check.Name = "darkMode_check";
            this.darkMode_check.Size = new System.Drawing.Size(87, 15);
            this.darkMode_check.TabIndex = 1;
            this.darkMode_check.Text = "Dark Mode";
            this.darkMode_check.UseVisualStyleBackColor = false;
            this.darkMode_check.CheckedChanged += new System.EventHandler(this.darkMode_check_CheckedChanged);
            // 
            // ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 381);
            this.Controls.Add(this.darkMode_check);
            this.Controls.Add(this.changeBackground_btn);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button changeBackground_btn;
        private System.Windows.Forms.CheckBox darkMode_check;
    }
}