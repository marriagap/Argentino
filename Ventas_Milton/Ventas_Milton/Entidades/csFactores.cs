using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csFactores
    {
        private int _idFactores;
        private string _tabla;
        private string _concepto;
        private string _monto;

        public csFactores(int idFactores, string tabla, string concepto, string monto)
        {
            this.IdFactores = idFactores;
            this.Tabla = tabla;
            this.Concepto = concepto;
            this.Monto = monto;
        }

        public int IdFactores
        {
            get { return _idFactores; }
            set { _idFactores = value; }
        }

        public string Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; }
        }

        public string Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
    }
}
