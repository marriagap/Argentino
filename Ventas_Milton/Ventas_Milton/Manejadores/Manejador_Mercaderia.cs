using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Mercaderia
    {
        static dMercaderia dmercaderia = new dMercaderia();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMercaderia(string parametro, csMercaderia mercaderia) 
        {
            int opcion=0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("CodigoInterno", 2);
            parametros.Add("Nombre", 3);
            parametros.Add("Proveedor", 4);
            parametros.Add("Stock", 5);
            parametros.Add("PrecioVenta", 6);
            parametros.Add("FechaAquisicion_Produccion", 7);
            parametros.Add("PrecioCompra", 8);
            parametros.Add("Lote", 9);
            parametros.Add("FechaVencimiento", 10);
            parametros.Add("Ubicacion", 11);
            parametros.Add("Estado", 12);
            parametros.Add("UnidadMedida", 13);
            parametros.Add("MercaderiaIntegra", 14);
            parametros.Add("GrupoFamilia", 15);

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
                case 1: dt = dmercaderia.ConsultarMercaderiaXCodigo(mercaderia);
                    break;
                case 2: dt = dmercaderia.ConsultarMercaderiaXCodInterno(mercaderia);
                    break;
                case 3: dt = dmercaderia.ConsultarMercaderiaXNombre(mercaderia);
                    break;
                case 4: dt = dmercaderia.ConsultarMercaderiaXProveedor(mercaderia);
                    break;
                case 5: dt = dmercaderia.ConsultarMercaderiaXStock(mercaderia);
                    break;
                case 6: dt = dmercaderia.ConsultarMercaderiaXPrecioVenta(mercaderia);
                    break;
                /*case 7: dt = dmercaderia.ConsultarMercaderiaXFechaAdqProd(mercaderia.FchAdquisicionProduccion.ToShortDateString());
                    break;*/
                case 8: dt = dmercaderia.ConsultarMercaderiaXPrecioCompra(mercaderia);
                    break;
                case 9: dt = dmercaderia.ConsultarMercaderiaXLote(mercaderia);
                    break;
                /*case 10: dmercaderia.ConsultarMercaderiaXFechaVencimiento
                    break;*/
                case 11: dt = dmercaderia.ConsultarMercaderiaXUbicacion(mercaderia);
                    break;
                case 12: dt = dmercaderia.ConsultarMercaderiaXEstado(mercaderia);
                    break;
                /*case 13: dt = dmercaderia.ConsultarMercaderiaXUnidadMedida(mercaderia);
                    break;*/
                /*case 14: dt = dmercaderia.ConsultarMercaderiaXMercaderiaFamilia();
                    break;*/
                /*case 15: dt = dmercaderia.ConsultarMercaderiaXMercaderiaIntegra();
                    break;*/
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csMercaderia mercaderia) 
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Nombre", 1);
            parametros.Add("Descripcion", 2);
            parametros.Add("Proveedor", 3);
            parametros.Add("Stock", 4);
            parametros.Add("PrecioVenta", 5);
            parametros.Add("FechaAdquisicionProduccion", 6);
            parametros.Add("Lote", 7);
            parametros.Add("TipoLote", 8);
            parametros.Add("Minimo", 9);
            parametros.Add("Fechavencimiento", 10);
            parametros.Add("Estado", 11);
            parametros.Add("UnidadMedida", 12);
            parametros.Add("MercaderiaIntegra", 13);
            parametros.Add("GrupoFamilia", 14);
            parametros.Add("Eliminado", 15);

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
                case 1: dmercaderia.ModificarNombre(mercaderia);
                    break;
                case 2: dmercaderia.ModificarDescripcion(mercaderia);
                    break;
                case 3: dmercaderia.ModificarProveedor(mercaderia);
                    break;
                case 4: dmercaderia.ModificarStock(mercaderia);
                    break;
                case 5: dmercaderia.ModificarPrecioVenta(mercaderia);
                    break;
                case 6: dmercaderia.ModificarFechaAdquisicionProduccion(mercaderia);
                    break;
                case 7: dmercaderia.ModificarLote(mercaderia);
                    break;
                case 8: dmercaderia.ModificarTipoLote(mercaderia);
                    break;
                case 9: dmercaderia.ModificarMinimo(mercaderia);
                    break;
                case 10: dmercaderia.ModificarFechaVencimiento(mercaderia);
                    break;
                case 11: dmercaderia.ModificarEstado(mercaderia);
                    break;
                case 12: dmercaderia.ModificarMedida(mercaderia);
                    break;
                /*case 13: dmercaderia.ConsultarMercaderiaXMercaderiaFamilia();
                    break;*/
                /*case 14: dmercaderia.ConsultarMercaderiaXMercaderiaIntegra();
                    break;*/
                case 15: dmercaderia.EliminarMercaderia(mercaderia);
                    break;
            }
        }

    }
}
