using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class Actores : ClaseMaestra
    {
        public int ActoresId { get; set; }
        public string Nombre { get; set; }

        public Actores()
        {
            this.ActoresId = 0;
            this.Nombre = "";
        }

        public Actores(int actoresId, string nombre)
        {
            this.ActoresId = actoresId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno=conexion.Ejecutar(String.Format("Insert Into Actores (Nombre) Values('{0}')", this.Nombre));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno=conexion.Ejecutar(String.Format("Update Into Actores (Nombre) Values('{0}')", this.Nombre));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete From Actores where ActorId={0}", this.ActoresId));
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Actores Where ActoresId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ActoresId = (int)dt.Rows[0]["ActoresId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
