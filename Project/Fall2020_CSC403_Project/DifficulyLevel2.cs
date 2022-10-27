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
    public partial class DifficulyLevel2 : Form
    {
        public DifficulyLevel2()
        {
            InitializeComponent();
        }

      

        private void btnEasy_Click(object sender, EventArgs e)
        {
            new FrmLevel().Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new StartScreenMenu().Show();
        }
    }
}
