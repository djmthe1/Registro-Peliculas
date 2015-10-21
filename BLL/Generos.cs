using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class Generos : ClaseMaestra
    {

        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            this.GeneroId = 0;
            this.Descripcion = "";
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno=conexion.Ejecutar(String.Format("Insert Into Categorias (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;

        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno=conexion.Ejecutar(String.Format("Update Into Categorias (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;

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
