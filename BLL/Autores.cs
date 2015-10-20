using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class Autores : ClaseMaestra
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }

        public Autores()
        {
            this.AutorId = 0;
            this.Nombre = "";
        }

        public Autores(int autorId, string nombre)
        {
            this.AutorId = autorId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Insert Into Autores (Nombre) Values('{0}')", this.Nombre));
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
