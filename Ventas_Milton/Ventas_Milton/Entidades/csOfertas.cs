using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csOfertas
    {
        private int _idOfertas;
        private string _factorOfertas;
        private DateTime _fchIAplicacion;
        private DateTime _fchFAplicacion;
        private string _tipoOferta;
        private int _idFactores;
        private int _eliminado;

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public csOfertas(int idOfertas, string factorOfertas, DateTime fIA, DateTime fFA, string tipoOferta, int idFactores)
        {
            this.IdFactores = idOfertas;
            this.FactorOfertas = factorOfertas;
            this.FchIAplicacion = fIA;
            this.FchFAplicacion = fFA;
            this.TipoOferta = tipoOferta;
            this.IdFactores = idFactores;
        }

        public int IdOfertas
        {
            get { return _idOfertas; }
            set { _idOfertas = value; }
        }

        public string FactorOfertas
        {
            get { return _factorOfertas; }
            set { _factorOfertas = value; }
        }

        public DateTime FchIAplicacion
        {
            get { return _fchIAplicacion; }
            set { _fchIAplicacion = value; }
        }

        public DateTime FchFAplicacion
        {
            get { return _fchFAplicacion; }
            set { _fchFAplicacion = value; }
        }

        public string TipoOferta
        {
            get { return _tipoOferta; }
            set { _tipoOferta = value; }
        }

        public int IdFactores
        {
            get { return _idFactores; }
            set { _idFactores = value; }
        }
    }
}
