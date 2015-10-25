using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{

        public class Estudios : ClaseMaestra
        {
            public int EstudiosId { get; set; }
            public string Nombre { get; set; }

            public Estudios()
            {
                this.EstudiosId = 0;
                this.Nombre = "";
            }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno=conexion.Ejecutar(String.Format("Insert Into Estudios (Nombre) Values('{0}')", this.Nombre));
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
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Estudios Where EstudiosId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.EstudiosId = (int)dt.Rows[0]["EstudiosId"];
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
