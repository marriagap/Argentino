using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Ofertas
    {
        static dOfertas ofertas = new dOfertas();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMovimiento(string parametro, csOfertas of)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("FechaInicio", 2);
            parametros.Add("FechaFin", 3);
            parametros.Add("TipoOferta", 4);
            parametros.Add("Todos", 5);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1: dt = ofertas.ConsultarXCodigo(of);
                    break;
                /*case 2: dt = ofertas.ConsultarXFechaInicio(of);
                    break;*/
                /*case 3: dt = ofertas.ConsultarXFechaFin(of);
                    break;*/
                case 4: dt = ofertas.ConsultarXTipoOferta(of);
                    break;
                case 5: dt = ofertas.ConsultarTodos();
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csOfertas of)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("TipoOfertas", 1);
            parametros.Add("Factores", 2);
            parametros.Add("Eliminar", 3);

            for (int i = 0; i <= parametros.Count; i++)
            {
                if (parametros.Contains(parametro))
                {
                    opcion = int.Parse(parametros[parametro].ToString());
                }
                else
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1: ofertas.ModificarTipoOferta(of);
                    break;
                case 2: ofertas.ModificarFactores(of);
                    break;
                case 3: ofertas.EliminarOferta(of);
                    break;
            }
        }
    }
}
