using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ventas_Milton.Datos;
using System.Collections;

namespace Ventas_Milton.Manejadores
{
    class Manejador_Persona
    {
        static dPersona persona = new dPersona();

        /**********************************************CONSULTAS************************************************/
        public DataTable BuscarMovimiento(string parametro, csPersona per)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Codigo", 1);
            parametros.Add("Nombre", 2);
            parametros.Add("SegundoNombre", 3);
            parametros.Add("FechaNacimiento", 4);
            parametros.Add("Direccion", 5);
            parametros.Add("Telefono", 6);
            parametros.Add("NroIdentificacion", 7);
            parametros.Add("TipoIdentificacion", 8);
            parametros.Add("FechaRegistro", 9);
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
                case 1: dt = persona.ConsultarXCodigo(per);
                    break;
                case 2: dt = persona.ConsultarXNombre(per);
                    break;
                case 3: dt = persona.ConsultarXSegundoNombre(per);
                    break;
                /*case 4: dt = persona.ConsultarXFechaNacimiento(per);
                    break;*/
                case 5: dt = persona.ConsultarXDireccion(per); 
                    break;
                case 6: dt = persona.ConsultarXTelefono(per);
                    break;
                case 7: dt = persona.ConsultarXNroId(per);
                    break;
                case 8: dt = persona.ConsultarXTipoId(per);
                    break;
                /*case 9: dt = persona.ConsultarXFechaRegistro(per);
                    break;*/
                /*case 10: dt = persona.ConsultarTodos();
                    break;*/
            }
            return dt;
        }

        /***************************************ACTUALIZACIONES Y ELIMINACIONES*********************************/
        public void ActualizarRegistro(string parametro, csPersona per)
        {
            int opcion = 0;
            DataTable dt = new DataTable();

            Hashtable parametros = new Hashtable();

            parametros.Add("Nombre", 1);
            parametros.Add("SegundoNombre", 2);
            parametros.Add("FechaNacimiento", 3);
            parametros.Add("Direccion", 4);
            parametros.Add("Telefono", 5);
            parametros.Add("NroId", 6);
            parametros.Add("TipoId", 7);
            parametros.Add("FechaRegistro", 8);
            parametros.Add("Eliminar", 9);

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
                case 1: persona.ModificarNombre(per);
                    break;
                case 2: persona.ModificarSegundoNombre(per);
                    break;
                case 3: persona.ModificarFechaNacimiento(per);
                    break;
                case 4: persona.ModificarDireccion(per);
                    break;
                case 5: persona.ModificarTelefono(per);
                    break;
                case 6: persona.ModificarNroId(per);
                    break;
                case 7: persona.ModificarTipoId(per);
                    break;
                case 8: persona.ModificarFechaRegistro(per);
                    break;
                case 9: persona.EliminarPersona(per);
                    break;
            }
        }

        /*********************************************INSERCIONES************************************************/
        public void RegistrarNuevaPersona(csPersona per) 
        {
            persona.InsertarNuevaPersona(per);
        }


    }
}
