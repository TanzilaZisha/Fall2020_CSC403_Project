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
            this.PbKid = new System.Windows.Forms.PictureBox();
            this.PbNut = new System.Windows.Forms.PictureBox();
            this.PbSonic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbKid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSonic)).BeginInit();
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
            // PbKid
            // 
            this.PbKid.BackColor = System.Drawing.Color.Transparent;
            this.PbKid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbKid.BackgroundImage")));
            this.PbKid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbKid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbKid.Image = global::Fall2020_CSC403_Project.Properties.Resources.player3;
            this.PbKid.Location = new System.Drawing.Point(882, 367);
            this.PbKid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbKid.Name = "PbKid";
            this.PbKid.Size = new System.Drawing.Size(127, 167);
            this.PbKid.TabIndex = 6;
            this.PbKid.TabStop = false;
            this.PbKid.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // PbNut
            // 
            this.PbNut.BackColor = System.Drawing.Color.Transparent;
            this.PbNut.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.PbNut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbNut.Location = new System.Drawing.Point(204, 371);
            this.PbNut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbNut.Name = "PbNut";
            this.PbNut.Size = new System.Drawing.Size(81, 163);
            this.PbNut.TabIndex = 4;
            this.PbNut.TabStop = false;
            this.PbNut.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // PbSonic
            // 
            this.PbSonic.BackColor = System.Drawing.Color.Transparent;
            this.PbSonic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbSonic.BackgroundImage")));
            this.PbSonic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSonic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSonic.Location = new System.Drawing.Point(547, 368);
            this.PbSonic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbSonic.Name = "PbSonic";
            this.PbSonic.Size = new System.Drawing.Size(127, 167);
            this.PbSonic.TabIndex = 11;
            this.PbSonic.TabStop = false;
            this.PbSonic.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // PlayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 896);
            this.Controls.Add(this.PbSonic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbKid);
            this.Controls.Add(this.PbNut);
            this.Controls.Add(this.label1);
            this.Name = "PlayerSelect";
            this.Text = "PlayerSelect";
            ((System.ComponentModel.ISupportInitialize)(this.PbKid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSonic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbKid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbNut;
        public System.Windows.Forms.PictureBox PbSonic;
    }
}