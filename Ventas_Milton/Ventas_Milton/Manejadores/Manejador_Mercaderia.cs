using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Mercaderia
    {
        static dMercaderia dmercaderia = new dMercaderia();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMercaderia(string parametro, csMercaderia mercaderia, csUnidadMedida und)
        {
            int opcion = 0;
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
                case 1: dt = dmercaderia.ConsultarMercaderiaXCodigo(mercaderia.IdMercaderia);
                    break;
                case 2: dt = dmercaderia.ConsultarMercaderiaXCodInterno(mercaderia.CodInternoMercaderia);
                    break;
                case 3: dt = dmercaderia.ConsultarMercaderiaXNombre(mercaderia.NomMercaderia);
                    break;
                case 4: dt = dmercaderia.ConsultarMercaderiaXProveedor(mercaderia.Proveedor);
                    break;
                case 5: dt = dmercaderia.ConsultarMercaderiaXStock(mercaderia.StockDisponible);
                    break;
                case 6: dt = dmercaderia.ConsultarMercaderiaXPrecioVenta(mercaderia.PrecioAdquisicion);
                    break;
                /*case 7: dt = dmercaderia.ConsultarMercaderiaXFechaAdqProd(mercaderia.FchAdquisicionProduccion.ToShortDateString());
                    break;*/
                case 8: dt = dmercaderia.ConsultarMercaderiaXPrecioCompra(mercaderia.PrecioXUndMedida);
                    break;
                case 9: dt = dmercaderia.ConsultarMercaderiaXLote(mercaderia.CodLote);
                    break;
                /*case 10: dmercaderia.ConsultarMercaderiaXFechaVencimiento
                    break;*/
                case 11: dt = dmercaderia.ConsultarMercaderiaXUbicacion(mercaderia.UbicacionLote);
                    break;
                case 12: dt = dmercaderia.ConsultarMercaderiaXEstado(mercaderia.EstadoMercaderia);
                    break;
                case 13: dt = dmercaderia.ConsultarMercaderiaXUnidadMedida(und.Descripcion);
                    break;
                /*case 14: dt = dmercaderia.ConsultarMercaderiaXMercaderiaFamilia();
                    break;*/
                /*case 15: dt = dmercaderia.ConsultarMercaderiaXMercaderiaIntegra();
                    break;*/
            }
            return dt;
        }
    }
}
