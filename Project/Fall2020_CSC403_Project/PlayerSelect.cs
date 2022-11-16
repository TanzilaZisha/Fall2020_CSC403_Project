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

        int lvl;


        public PlayerSelect(int difficulty)
        {
            InitializeComponent();
            lvl = difficulty;
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
            
            if(lvl == 1)
            {
                FrmLevel stage_1 = new FrmLevel();
                stage_1.picPlayer.BackgroundImage = PbNut.BackgroundImage;
                stage_1.Show();
            }
            else if (lvl == 2)
            {
                FrmLevelMedium stage_2 = new FrmLevelMedium();
                stage_2.picPlayer.BackgroundImage = PbNut.BackgroundImage;
                stage_2.Show();
            }
            else if (lvl == 3)
                {
                    FrmLevelDifficult stage_3 = new FrmLevelDifficult();
                    stage_3.picPlayer.BackgroundImage = PbNut.BackgroundImage;
                    stage_3.Show();
                }



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (lvl == 1)
            {
                FrmLevel stage_1 = new FrmLevel();
                stage_1.picPlayer.BackgroundImage = PbKid.BackgroundImage;
                stage_1.Show();
            }
            else if (lvl == 2)
            {
                FrmLevelMedium stage_2 = new FrmLevelMedium();
                stage_2.picPlayer.BackgroundImage = PbKid.BackgroundImage;
                stage_2.Show();
            }
            else if (lvl == 3)
            {
                FrmLevelDifficult stage_3 = new FrmLevelDifficult();
                stage_3.picPlayer.BackgroundImage = PbKid.BackgroundImage;
                stage_3.Show();
            }
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
            if (lvl == 1)
            {
                FrmLevel stage_1 = new FrmLevel();
                stage_1.picPlayer.BackgroundImage = PbSonic.BackgroundImage;
                stage_1.Show();
            }
            else if (lvl == 2)
            {
                FrmLevelMedium stage_2 = new FrmLevelMedium();
                stage_2.picPlayer.BackgroundImage = PbSonic.BackgroundImage;
                stage_2.Show();
            }
            else if (lvl == 3)
            {
                FrmLevelDifficult stage_3 = new FrmLevelDifficult();
                stage_3.picPlayer.BackgroundImage = PbSonic.BackgroundImage;
                stage_3.Show();
            }

        }
    }
}
