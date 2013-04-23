using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csAlmacen
    {
        private int _idAlmacen;
        private int _capMaxLotes;
        private int _eliminado;

        public int Eliminado
        {
            get { return _eliminado; }
            set { _eliminado = value; }
        }

        public csAlmacen(int idAlmacen, int capMAxXLotes)
        {
            this.IdAlmacen = idAlmacen;
            this.CapMaxLotes = capMAxXLotes;
        }

        public int IdAlmacen
        {
            get { return _idAlmacen; }
            set { _idAlmacen = value; }
        }

        public int CapMaxLotes
        {
            get { return _capMaxLotes; }
            set { _capMaxLotes = value; }
        }
    }
}
