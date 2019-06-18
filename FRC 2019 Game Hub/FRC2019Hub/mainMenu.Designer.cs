namespace FRC2019Hub
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.webPicBtn = new System.Windows.Forms.PictureBox();
            this.simBox = new System.Windows.Forms.PictureBox();
            this.mafiaBox = new System.Windows.Forms.PictureBox();
            this.invaderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.webPicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // webPicBtn
            // 
            this.webPicBtn.Image = ((System.Drawing.Image)(resources.GetObject("webPicBtn.Image")));
            this.webPicBtn.Location = new System.Drawing.Point(-3, 286);
            this.webPicBtn.Name = "webPicBtn";
            this.webPicBtn.Size = new System.Drawing.Size(800, 100);
            this.webPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.webPicBtn.TabIndex = 6;
            this.webPicBtn.TabStop = false;
            this.webPicBtn.Click += new System.EventHandler(this.WebPicBtn_Click);
            // 
            // simBox
            // 
            this.simBox.Image = global::FRC2019Hub.Properties.Resources.sim;
            this.simBox.Location = new System.Drawing.Point(-3, 189);
            this.simBox.Name = "simBox";
            this.simBox.Size = new System.Drawing.Size(800, 100);
            this.simBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.simBox.TabIndex = 4;
            this.simBox.TabStop = false;
            this.simBox.Click += new System.EventHandler(this.simBox_Click);
            // 
            // mafiaBox
            // 
            this.mafiaBox.Image = global::FRC2019Hub.Properties.Resources.mafia;
            this.mafiaBox.Location = new System.Drawing.Point(-3, 93);
            this.mafiaBox.Name = "mafiaBox";
            this.mafiaBox.Size = new System.Drawing.Size(800, 100);
            this.mafiaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mafiaBox.TabIndex = 1;
            this.mafiaBox.TabStop = false;
            this.mafiaBox.Click += new System.EventHandler(this.mafiaBox_Click);
            // 
            // invaderBox
            // 
            this.invaderBox.Image = global::FRC2019Hub.Properties.Resources.smith;
            this.invaderBox.Location = new System.Drawing.Point(-3, -1);
            this.invaderBox.Name = "invaderBox";
            this.invaderBox.Size = new System.Drawing.Size(800, 100);
            this.invaderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.invaderBox.TabIndex = 0;
            this.invaderBox.TabStop = false;
            this.invaderBox.Click += new System.EventHandler(this.invaderBox_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 385);
            this.Controls.Add(this.webPicBtn);
            this.Controls.Add(this.simBox);
            this.Controls.Add(this.mafiaBox);
            this.Controls.Add(this.invaderBox);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webPicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox invaderBox;
        private System.Windows.Forms.PictureBox mafiaBox;
        private System.Windows.Forms.PictureBox simBox;
        private System.Windows.Forms.PictureBox webPicBtn;
    }
}