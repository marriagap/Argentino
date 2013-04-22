using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csUnidadMedida
    {
        private int _idUndMedida;
        private string _descripcion;
        private int _valor;
        private int _idUndMedidaPadre; /*idUndMedida => para poder manejar los valores mínimos para las conversiones*/

        public csUnidadMedida(int idUndMedida, string descripcion, int valor, int idUndMedidaPadre)
        {
            this.IdUndMedida = idUndMedida;
            this.Descripcion = descripcion;
            this.Valor = valor;
            this.IdUndMedidaPadre = idUndMedidaPadre;
        }

        public int IdUndMedida
        {
            get { return _idUndMedida; }
            set { _idUndMedida = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public int IdUndMedidaPadre
        {
            get { return _idUndMedidaPadre; }
            set { _idUndMedidaPadre = value; }
        }
    }
}
