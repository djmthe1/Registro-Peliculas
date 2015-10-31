using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesOrganizer
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Registros.BuscarForm buscar = new Registros.BuscarForm();
            buscar.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Registros.InsertarForm insertar = new Registros.InsertarForm();
            insertar.Show();
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            Registros.ListarForm listar = new Registros.ListarForm();
            listar.Show();
        }
    }
}
