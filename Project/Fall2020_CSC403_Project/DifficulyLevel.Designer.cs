namespace Fall2020_CSC403_Project
{
    partial class DifficulyLevel
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
            this.btneasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btneasy
            // 
            this.btneasy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneasy.Location = new System.Drawing.Point(315, 51);
            this.btneasy.Name = "btneasy";
            this.btneasy.Size = new System.Drawing.Size(145, 47);
            this.btneasy.TabIndex = 0;
            this.btneasy.Text = "Easy";
            this.btneasy.UseVisualStyleBackColor = false;
            this.btneasy.Click += new System.EventHandler(this.btneasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(315, 139);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(145, 47);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(315, 211);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(145, 47);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.SystemColors.GrayText;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(315, 292);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(145, 47);
            this.s.TabIndex = 3;
            this.s.Text = "Cancel";
            this.s.UseVisualStyleBackColor = false;
            // 
            // DifficulyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.s);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btneasy);
            this.Name = "DifficulyLevel";
            this.Text = "DifficulyLevel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btneasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button s;
    }
}