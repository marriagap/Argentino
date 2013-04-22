using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csMovimieto
    {
        private int _idMovimiento;
        private string _tipoMovimiento; /*Tipos: EntradaXProduccion,SalidaXProduccion,EntradaXAdquisicion,SalidaXVenta,EntradaXTraspaso,SalidaXTraspaso*/
        private int _cantItems;
        private string _codInternoMovimiento;
        private string _tipoComprobante; /*Tipos: Boleta,Factura,Voucher,Ticket,GuiaDeRemision,OrdenDeProduccion*/
        private double _montoPago;
        private int _codOfertas; /*para ventas, los tipos de ofertas que se aplican en */
        private int _codVendedor; /*idPersona => codigo del empleado*/
        private int _codCliente; /*idPersona => codigo del cliente*/

        public csMovimieto(int idMovimiento, string tipoMovimiento, int cantItems, string codInternoMovimiento, string tipoComprobante, double montoPago, int codOfertas, int codVendedor, int codCliente)
        {
            this.IdMovimiento = idMovimiento;
            this.TipoComprobante = tipoComprobante;
            this.CantItems = cantItems;
            this.CodInternoMovimiento = codInternoMovimiento;
            this.MontoPago = montoPago;
            this.CodOfertas = codOfertas;
            this.CodVendedor = codVendedor;
            this.CodCliente = codCliente;
        }

        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }

        public string TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }


        public int CantItems
        {
            get { return _cantItems; }
            set { _cantItems = value; }
        }

        public string CodInternoMovimiento
        {
            get { return _codInternoMovimiento; }
            set { _codInternoMovimiento = value; }
        }

        public string TipoComprobante
        {
            get { return _tipoComprobante; }
            set { _tipoComprobante = value; }
        }

        public double MontoPago
        {
            get { return _montoPago; }
            set { _montoPago = value; }
        }

        public int CodOfertas
        {
            get { return _codOfertas; }
            set { _codOfertas = value; }
        }

        public int CodVendedor
        {
            get { return _codVendedor; }
            set { _codVendedor = value; }
        }

        public int CodCliente
        {
            get { return _codCliente; }
            set { _codCliente = value; }
        }
    }
}
