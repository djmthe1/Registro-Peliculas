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
    public partial class ListarForm : Form
    {
        public ListarForm()
        {
            InitializeComponent();
        }

        private void ListarForm_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListarComboBox.Text == "Genero")
            {
                GenerosForm GF = new GenerosForm();
                GF.Show();
            }
            if (ListarComboBox.Text == "Actor")
            {
                ActoresForm AF = new ActoresForm();
                AF.Show();
            }
            if (ListarComboBox.Text == "Estudio")
            {
                EstudiosForm EF = new EstudiosForm();
                EF.Show();
            }
            if (ListarComboBox.Text == "Categoría")
            {
                CategoriasForm CF = new CategoriasForm();
                CF.Show();
            }
            if (ListarComboBox.Text == "Pelicula")
            {
                PeliculasForm PF = new PeliculasForm();
                PF.Show();
            }

        }
    }
}
