using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesOrganizer.Registros
{
    public partial class InsertarForm : Form
    {
        public InsertarForm()
        {
            InitializeComponent();
        }

        private void SeleccionarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionarComboBox.Text == "Genero")
            {
                GenerosForm GF = new GenerosForm();
                GF.Show();
            }
            if (SeleccionarComboBox.Text == "Actor")
            {
                ActoresForm AF = new ActoresForm();
                AF.Show();
            }
            if (SeleccionarComboBox.Text == "Estudio")
            {
                EstudiosForm EF = new EstudiosForm();
                EF.Show();
            }
            if (SeleccionarComboBox.Text == "Categoría")
            {
                CategoriasForm CF = new CategoriasForm();
                CF.Show();
            }
            if (SeleccionarComboBox.Text == "Pelicula")
            {
                PeliculasForm PF = new PeliculasForm();
                PF.Show();
            }

        }

        private void InsertarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
