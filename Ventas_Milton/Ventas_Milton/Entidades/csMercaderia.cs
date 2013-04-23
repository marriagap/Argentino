using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csMercaderia
    {
        /*Inicio Datos Mercaderia*/
        private int _idMercaderia;
        private string _codInternoMercaderia; /*Codigo compuesto => 3 primeros digitos determinan la familia, 3 siguientes determinados por el codigo de barras del producto, 2 siguientes por el lote de adquisicion/produccion,2 siguientes para determinar el almacen y X siguientes para la Ubicación en Almacen*/
        private string _nomMercaderia;
        private string _descripcionMercaderia;
        private string _proveedor;
        private int _stockDisponible;
        private double _precioXUndMedida;
        private DateTime _fchAdquisicionProduccion;
        private double _precioAdquisicion;
        private string _estadoMercaderia; /*Estado: Vendido,En produccion,Disponible,...*/
        private int _codUndMedida; /*para obtener la familia de medicion del producto*/
        private int _codFamMercaderia /*idMercaderia_Padre => para obtener el grupo de tipo de producto al que pertenece*/;
        private int _codMercaderiaIntegral /*idMercaderia_Padre => para obtener de donde se ha derivado el producto*/;
        private int _eliminado;

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public csMercaderia(int idMercaderia, string codInternoMercaderia, string nomMercaderia,string descripcionMercaderia, string proveedor, int stockDisponible,double precioAdquisicion, double precioXUndMedida, DateTime fAP, string estadoMercaderia,int codUndMedida, int codFamMercaderia, int codMercaderiaIntegral, string cdLote,string tipoLote,int minXLote, DateTime FV, string ubicacionLote)
        {
            this.IdMercaderia = idMercaderia;
            this.CodInternoMercaderia = codInternoMercaderia;
            this.NomMercaderia = nomMercaderia;
            this.DescripcionMercaderia = descripcionMercaderia;
            this.Proveedor = proveedor;
            this.StockDisponible = stockDisponible;
            this.PrecioAdquisicion = precioAdquisicion;
            this.FchAdquisicionProduccion = fAP;
            this.PrecioXUndMedida = precioXUndMedida;
            this.EstadoMercaderia = estadoMercaderia;
            this.CodUndMedida = codUndMedida;
            this.CodFamMercaderia = codFamMercaderia;
            this.CodMercaderiaIntegral = codMercaderiaIntegral;
            this.CodLote = cdLote;
            this.TipoLote = tipoLote;
            this.MinXLote = minXLote;
            this.FchVencimiento = FV;
            this.UbicacionLote = ubicacionLote;

        }

        public int IdMercaderia
        {
            get { return _idMercaderia; }
            set { _idMercaderia = value; }
        }

        public string CodInternoMercaderia
        {
            get { return _codInternoMercaderia; }
            set { _codInternoMercaderia = value; }
        }

        public string NomMercaderia
        {
            get { return _nomMercaderia; }
            set { _nomMercaderia = value; }
        }

        public string DescripcionMercaderia
        {
            get { return _descripcionMercaderia; }
            set { _descripcionMercaderia = value; }
        }

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public int StockDisponible
        {
            get { return _stockDisponible; }
            set { _stockDisponible = value; }
        }

        public double PrecioXUndMedida
        {
            get { return _precioXUndMedida; }
            set { _precioXUndMedida = value; }
        }

        public DateTime FchAdquisicionProduccion
        {
            get { return _fchAdquisicionProduccion; }
            set { _fchAdquisicionProduccion = value; }
        }

        public double PrecioAdquisicion
        {
            get { return _precioAdquisicion; }
            set { _precioAdquisicion = value; }
        }

        public string EstadoMercaderia
        {
            get { return _estadoMercaderia; }
            set { _estadoMercaderia = value; }
        }

        public int CodUndMedida
        {
            get { return _codUndMedida; }
            set { _codUndMedida = value; }
        }

        public int CodFamMercaderia
        {
            get { return _codFamMercaderia; }
            set { _codFamMercaderia = value; }
        }


        public int CodMercaderiaIntegral
        {
            get { return _codMercaderiaIntegral; }
            set { _codMercaderiaIntegral = value; }
        }
        /*Fin Datos Mercaderia*/

        /*Inicio Datos Lote*/
        private string _codLote;
        private string _tipoLote;
        private int _minXLote;
        private DateTime _fchVencimiento;
        private string _ubicacionLote;

        public string CodLote
        {
            get { return _codLote; }
            set { _codLote = value; }
        }

        public string TipoLote
        {
            get { return _tipoLote; }
            set { _tipoLote = value; }
        }

        public int MinXLote
        {
            get { return _minXLote; }
            set { _minXLote = value; }
        }

        public DateTime FchVencimiento
        {
            get { return _fchVencimiento; }
            set { _fchVencimiento = value; }
        }

        public string UbicacionLote
        {
            get { return _ubicacionLote; }
            set { _ubicacionLote = value; }
        }
        /*Fin Datos Lote*/

    }
}
