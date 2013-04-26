using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_UnidadMedida
    {
        dUnidadMedida undmed = new dUnidadMedida();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMovimiento(string parametro, csUnidadMedida um)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("Descripcion", 2);
            parametros.Add("Valor", 3);
            parametros.Add("Padre", 4);
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
                case 1: dt = undmed.ConsultarXCodigo(um);
                    break;
                case 2: dt = undmed.ConsultarXDescripcion(um);
                    break;
                case 3: dt = undmed.ConsultarXValor(um);
                    break;
                case 4: dt = undmed.ConsultarXPadre(um);
                    break;
                /*case 5: dt = undmed.ConsultarTodos();
                    break;*/
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csUnidadMedida um)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Descripcion", 1);
            parametros.Add("Valor", 2);
            parametros.Add("Padre", 3);
            parametros.Add("Eliminar", 4);

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
                case 1: undmed.ModificarDescripcion(um);
                    break;
                case 2: undmed.ModificarValor(um);
                    break;
                case 3: undmed.ModificarPadre(um);
                    break;
                case 4: undmed.EliminarUnidadMedida(um);
                    break;
            }
        }
    }
}
