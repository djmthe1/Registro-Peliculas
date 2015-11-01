using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Categorias : ClaseMaestra
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            this.CategoriaId = 0;
            this.Descripcion = "";
        }
        
        public Categorias(int categoriaid, string descripcion)
        {
            this.CategoriaId = categoriaid;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Insert Into Categorias (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(String.Format("Update Into Categorias (Descripcion) Values('{0}')", this.Descripcion));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From Categorias where CategoriaId={0}", this.CategoriaId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {

            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Categorias Where CategoriaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.CategoriaId = (int)dt.Rows[0]["CategoriaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
