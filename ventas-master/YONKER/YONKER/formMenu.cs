﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace YONKER
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formdescripcion = new FormDescripcion_pieza();
            formdescripcion.MdiParent = this;
            formdescripcion.Show(); 
           
        }
    }
}
