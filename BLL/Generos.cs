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

        public Generos(int generoId, string descripcion)
        {
            this.GeneroId = generoId;
            this.Descripcion = descripcion;
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
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From Generos where GeneroId={0}", this.GeneroId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Generos Where GeneroId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.GeneroId = (int)dt.Rows[0]["GeneroId"];
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
