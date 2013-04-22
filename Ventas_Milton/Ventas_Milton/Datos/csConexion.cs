using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml;

namespace Ventas_Milton.Datos
{
    class csConexion        
    {
        private string cdCon;
        private MySqlConnection con = new MySqlConnection();
        funciones funciones = new funciones();

        public MySqlConnection getConexion() {
            try {
                XmlNodeList parametros = funciones.LeeXML("Configuracion.xml", "configuracion", "conexion");
                foreach (XmlElement nodo in parametros)
                {
                    XmlNodeList servidor = nodo.GetElementsByTagName("servidor");
                    XmlNodeList basedatos = nodo.GetElementsByTagName("basedatos");
                    XmlNodeList usuario = nodo.GetElementsByTagName("usuario");
                    XmlNodeList password = nodo.GetElementsByTagName("password");
                    con.ConnectionString = "Server=" + servidor[0].InnerText + ";Port=3306;Database=" + basedatos[0].InnerText + ";Uid=" + usuario[0].InnerText + " ;pwd=" + password[0].InnerText+"";
                    //Cn.ConnectionString = "Server=localhost;Port=3306;Database=" + basedatos[0].InnerText + ";Uid=Ruben;pwd=123456*";
                }
                con.Open();
                return con;
            }
            catch(MySqlException)
            {
                MessageBox.Show("Error de conexión","ERROR!");
                return con;
            }
        }

        //Es una prueba para el GitHub muy a lo Melissa asdlaksdlskafolsdbvisdf jsd fjsd cjsd j
    }
}
