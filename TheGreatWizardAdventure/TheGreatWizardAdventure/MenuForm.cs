﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheGreatWizardAdventure.Container;

namespace TheGreatWizardAdventure
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }



        private void START(object sender, EventArgs e)
        {
            GameForm showForm = new GameForm();
            this.Hide();
            showForm.ShowDialog();

        }
    }
}