﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class Peliculas : ClaseMaestra

    {

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }

        public Peliculas()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
        }

        public Peliculas(int peliculaId, string titulo, string descripcion, int ano, int calificacion, int imdb, int categoriaId)
        {
            this.PeliculaId = peliculaId;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Ano = ano;
            this.Calificacion = calificacion;
            this.IMDB = imdb;
            this.CategoriaId = categoriaId;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Insert into RegistroPelicula(Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId) Values ('{0}','{1}',{2},{3},{4},{5})", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriaId));
            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
