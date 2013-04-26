using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Movimientos
    {
        static dMovimiento movimiento = new dMovimiento();
        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMovimiento(string parametro, csMovimieto mov)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("TipoMovimiento", 2);
            parametros.Add("CantidadItems", 3);
            parametros.Add("CodigoInterno", 4);
            parametros.Add("TipoComprobante", 5);
            parametros.Add("Monto", 6);
            parametros.Add("Vendedor", 7);
            parametros.Add("Cliente", 8);
            parametros.Add("Ofertas", 9);
            parametros.Add("Todos", 10);

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
                case 1: dt = movimiento.ConsultarXCodigo(mov);
                    break;
                case 2: dt = movimiento.ConsultarXTipoMovimiento(mov);
                    break;
                case 3: dt = movimiento.ConsultarXCantidadItems(mov);
                    break;
                case 4: dt = movimiento.ConsultarXTipoComprobante(mov);
                    break;
                case 5: dt = movimiento.ConsultarXMonto(mov);
                    break;
                case 6: dt = movimiento.ConsultarXVendedor(mov);
                    break;
                case 7: dt = movimiento.ConsultarXCliente(mov);
                    break;
                case 8: dt = movimiento.ConsultarXOfertas(mov);
                    break;
                case 9: dt = movimiento.ConsultarXOfertas(mov);
                    break;
                case 10: dt = movimiento.ConsultarTodos();
                    break;
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csMovimieto mov)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("TipoMovimiento", 1);
            parametros.Add("CantidadItems", 2);
            parametros.Add("TipoComprobantes", 3);
            parametros.Add("MontoPago", 4);
            parametros.Add("Vendedor", 5);
            parametros.Add("Cliente", 6);
            parametros.Add("Ofertas", 7);
            parametros.Add("Eliminar", 8);

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
                case 1: movimiento.ModificarTipoMovimiento(mov);
                    break;
                case 2: movimiento.ModificarCantidadItems(mov);
                    break;
                case 3: movimiento.ModificarTipoComprobante(mov);
                    break;
                case 4: movimiento.ModificarMontoPago(mov);
                    break;
                case 5: movimiento.ModificarVendedor(mov);
                    break;
                case 6: movimiento.ModificarCliente(mov);
                    break;
                case 7: movimiento.ModificarOfertas(mov);
                    break;
                case 8: movimiento.EliminarMovimiento(mov);
                    break;
            }
        }
    }
}
