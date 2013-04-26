using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Factores
    {
        dFactores dfactores = new dFactores();
        /***********************************CONSULTAS*****************************/
        public DataTable BuscarFactor(string parametro, csFactores factor) 
        {
            DataTable dt = new DataTable();
            int opcion = 0;

            Hashtable parametros = new Hashtable();
            parametros.Add("Codigo", 1);
            parametros.Add("Tabla", 1);
            parametros.Add("Concepto", 1);
            parametros.Add("Monto", 1);
            parametros.Add("Todos", 1);

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
                case 1: dt = dfactores.ConsultarXCodigo(factor.IdFactores);
                    break;
                case 2: dt = dfactores.ConsultarXTabla(factor.Tabla);
                    break;
                case 3: dt = dfactores.ConsultarXConcepto(factor.Concepto);
                    break;
                case 4: dt = dfactores.ConsultarXMonto(factor.Monto);
                    break;
                case 5: dt = dfactores.ConsultaTodos();
                    break;
                default: dt = dfactores.ConsultaTodos();
                    break;
            }
            return dt;
        }

        /************************ACTUALIZACIONES Y ELIMINACIONES******************/
        public void ActualizarRegistro_Factores(string parametro, csFactores factor) 
        {
            int opcion;
            if (parametro == "Tabla")
            {
                opcion = 1;
            }
            else
            {
                if (parametro == "Concepto")
                {
                    opcion = 2;
                }
                else 
                {
                    if (parametro == "Monto")
                    {
                        opcion = 3;
                    }
                    else 
                    {
                        opcion = 4;
                    }
                }
            }

            switch(opcion)
            {
                case 1: dfactores.ModificarTabla(factor.IdFactores, factor.Tabla);
                    break;
                case 2: dfactores.ModificarConcepto(factor.IdFactores, factor.Concepto);
                    break;
                case 3: dfactores.ModificarMonto(factor.IdFactores, factor.Monto);
                    break;
                case 4: dfactores.EliminarFactores(factor.IdFactores, factor.Eliminado);
                    break;
            }
        }
    }
}
