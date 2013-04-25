using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Factores
    {
        dFactores dfactores = new dFactores();
        /***********************************CONSULTAS*****************************/
        public DataTable BuscarFactor(string parametro, string valor) 
        {
            DataTable dt = new DataTable();
            int opcion;
            if (parametro == "Codigo")
            {
                opcion = 1;
            }
            else 
            {
                if (parametro == "Tabla")
                {
                    opcion = 2;
                }
                else
                {
                    if (parametro == "Concepto")
                    {
                        opcion = 3;
                    }
                    else
                    {
                        if (parametro == "Monto")
                        {
                            opcion = 4;
                        }
                        else
                        { 
                            opcion = 5;
                        }
                    }
                }
            }

            switch (opcion) 
            {
                case 1: dt = dfactores.ConsultarXCodigo(int.Parse(valor));
                    break;
                case 2: dt = dfactores.ConsultarXTabla(valor);
                    break;
                case 3: dt = dfactores.ConsultarXConcepto(valor);
                    break;
                case 4: dt = dfactores.ConsultarXMonto(valor);
                    break;
                case 5: dt = dfactores.ConsultaTodos();
                    break;
                default: dt = dfactores.ConsultaTodos();
                    break;
            }
            return dt;
        }

        /************************ACTUALIZACIONES Y ELIMINACIONES******************/
        public void ActualizarRegistro_Factores(string parametro, string valor, int cod) 
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
                case 1: dfactores.ModificarTabla(cod, valor);
                    break;
                case 2: dfactores.ModificarConcepto(cod, valor);
                    break;
                case 3: dfactores.ModificarMonto(cod, valor);
                    break;
                case 4: dfactores.EliminarFactores(cod, int.Parse(valor));
                    break;
            }
        }
    }
}
