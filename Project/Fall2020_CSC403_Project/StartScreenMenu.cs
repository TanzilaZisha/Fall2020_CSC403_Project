﻿using System;
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
    public partial class StartScreenMenu : Form
    {


        public StartScreenMenu()
        {
            InitializeComponent();
           
        }

        private void StartScreenMenu_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new PlayerSelect(1).Show();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            //new PlayerSelect().Show();

            this.Hide();
            DifficulyLevel2 d = new DifficulyLevel2();
            d.ShowDialog();
            this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LevelSelect_Click(object sender, EventArgs e)
        {
             
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnlevel_Click(object sender, EventArgs e)
        {
          this.Hide();
         DifficulyLevel2 d= new DifficulyLevel2();
            d.ShowDialog();
            this.Close();
        }
    }
}
