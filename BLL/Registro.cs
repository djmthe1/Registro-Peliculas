using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Registro
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }

        public Registro()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
        }

        public Registro(int peliculaId, string titulo, int descripcion,int ano, int calificacion, int imdb, int categoriaId)
        {
            this.PeliculaId = peliculaId;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Ano = ano;
            this.Calificacion = calificacion;
            this.IMDB = imdb;
            this.CategoriaId = categoriaId;

        }


        public bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            conexion.Ejecutar(String.Format("Insert Into Registro (Descripcion) Values('{0}')", this.Descripcion));

            return retorno;

        }


    }

}
