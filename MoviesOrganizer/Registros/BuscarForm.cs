﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesOrganizer.Registros
{
    public partial class BuscarForm : Form
    {
        public BuscarForm()
        {
            InitializeComponent();
        }

        private void BuscarForm_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
