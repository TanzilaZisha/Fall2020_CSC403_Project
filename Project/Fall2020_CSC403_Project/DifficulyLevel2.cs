using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class DifficulyLevel2 : Form
    {
        public DifficulyLevel2()
        {
            InitializeComponent();
        } 

      

        private void btnEasy_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            PlayerSelect fl = new PlayerSelect(1);
            fl.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreenMenu ss = new StartScreenMenu();
            ss.ShowDialog();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {

            /*        this.Hide();
                    FrmLevelMedium fl = new FrmLevelMedium();
                    fl.ShowDialog();
                    this.Close();*/

            this.Hide();
            PlayerSelect fl = new PlayerSelect(2);
            fl.ShowDialog();
            this.Close();


        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*   FrmLevelDifficult fl = new FrmLevelDifficult();
               fl.ShowDialog();
               this.Close();*/
            PlayerSelect fl = new PlayerSelect(3);
            fl.ShowDialog();
            this.Close();


        }
    }
}
