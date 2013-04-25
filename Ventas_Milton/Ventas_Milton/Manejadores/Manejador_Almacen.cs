using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Almacen
    {
        static dAlmacen dalmacen = new dAlmacen();

        /********************************Consultas****************************/
        public DataTable BuscarAlmacen(string parametro,csAlmacen almacen) {
            
            int opcion;
            DataTable dt = new DataTable();

            if(parametro == "Capacidad")
            {
                opcion = 1;
            }
            else
            {
                if(parametro == "Codigo")
                {
                    opcion = 2;
                }
                else
                {
                    opcion = 3;
                }
            }

            switch (opcion)
            {
                case 1: dt = dalmacen.ConsultarXCapAlmacen(almacen.CapMaxLotes);
                    break;
                case 2: dt = dalmacen.ConsultarAlmacenXCodigo(almacen.IdAlmacen);
                    break;
                case 3: dt = dalmacen.ConsultarTodos();
                    break;
                default: dt = dalmacen.ConsultarTodos();
                    break;
            }

            return dt;
        }

        /***********************ACTUALIZACIONES Y ELIMINACIONES***************/
        public void ActualizarRegistros_Almacen(string tipoAct,csAlmacen almacen) 
        {
            int opcion;
            if (tipoAct == "Modificar")
            {
                opcion = 1;
            }
            else
            {
                opcion = 2;
            }

            switch (opcion) 
            {
                case 1: dalmacen.ModificarCapacidad(almacen.IdAlmacen, almacen.CapMaxLotes);                        
                    break;
                case 2: dalmacen.EliminarAlmacen(almacen.IdAlmacen, almacen.Eliminado);
                    break;
            }
        }
    }
}
