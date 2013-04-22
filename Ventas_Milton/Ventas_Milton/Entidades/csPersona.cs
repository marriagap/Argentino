using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas_Milton.Datos
{
    class csPersona
    {
        funciones funciones = new funciones();

        private int _idPersona;
        private string _primerNombre;
        private string _segundoNombre;
        private DateTime _fchNacimiento;
        private string _direccionRasonSocial;
        private string _telefono;
        //Atributos para Identificar a Personas Naturales de Personas Juridicas
        private string _nroIdentificacion;
        private string _tipoIdentificacion; /*RUC = J; DNI = N; CodigoInterno de Empleado = E*/

        public csPersona(int p_idPersona, string p_primerNombre, string p_segundoNombre, DateTime p_fchNacimiento, string dir_Rs, string telf, string nroId, string tpoId)
        {
            this.IdPersona = p_idPersona;
            this.Nombres = p_primerNombre;
            this.Apellidos = p_segundoNombre;
            this.FchNacimiento = p_fchNacimiento;
            this.DireccionRasonSocial = dir_Rs;
            this.Telefono = telf;
            this.NroIdentificacion = nroId;
            this.TipoIdentificacion = tpoId;
        }

        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public string Nombres
        {
            get 
            { 
                return _primerNombre; 
            }
            set 
            { 
                _primerNombre = value;

            }
        }

        public string Apellidos
        {
            get{return _segundoNombre;}
            set{_segundoNombre = value;}
        }

        public DateTime FchNacimiento
        {
            get { return _fchNacimiento; }
            set { _fchNacimiento = value; }
        }

        public string DireccionRasonSocial
        {
            get { return _direccionRasonSocial; }
            set { _direccionRasonSocial = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string NroIdentificacion
        {
            get { return _nroIdentificacion; }
            set { _nroIdentificacion = value; }
        }

        public string TipoIdentificacion
        {
            get { return _tipoIdentificacion; }
            set { _tipoIdentificacion = value; }
        }

    }
}
