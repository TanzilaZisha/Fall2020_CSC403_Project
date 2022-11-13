using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class PlayerSelect : Form
    {
        public PlayerSelect()
        {
            InitializeComponent();
        }
    

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FrmLevel().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new FrmLevel().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new FrmLevel().Show();
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {
            new FrmLevel().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLevel stage_1 = new FrmLevel();

            stage_1.picPlayer.Image = picPlayer3.Image;

            stage_1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            new FrmLevel().Show();

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {
            new FrmLevel().Show();

        }
    }
}
