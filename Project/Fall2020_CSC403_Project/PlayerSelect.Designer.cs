namespace Fall2020_CSC403_Project
{
    partial class PlayerSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerSelect));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select your player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rage Italic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "The Kid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonic";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mr. Peanut";
            // 
            // picPlayer3
            // 
            this.picPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayer3.BackgroundImage")));
            this.picPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlayer3.Location = new System.Drawing.Point(882, 367);
            this.picPlayer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(127, 167);
            this.picPlayer3.TabIndex = 6;
            this.picPlayer3.TabStop = false;
            this.picPlayer3.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlayer1.Location = new System.Drawing.Point(204, 371);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(81, 163);
            this.picPlayer1.TabIndex = 4;
            this.picPlayer1.TabStop = false;
            this.picPlayer1.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayer2.BackgroundImage")));
            this.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlayer2.Location = new System.Drawing.Point(567, 367);
            this.picPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(127, 167);
            this.picPlayer2.TabIndex = 11;
            this.picPlayer2.TabStop = false;
            this.picPlayer2.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // PlayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 896);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPlayer3);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "PlayerSelect";
            this.Text = "PlayerSelect";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPlayer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
    }
}