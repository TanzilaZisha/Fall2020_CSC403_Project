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
    public partial class DifficulyLevel : Form
    {
        
        
        public DifficulyLevel()
        {
            InitializeComponent();
        }

        private void btneasy_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel();
            frmLevel.Show();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {

        }
    }
}
