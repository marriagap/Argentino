using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dMercaderia
    {
        static csConexion con = new csConexion();

        /********************CONSULTAS************************/
        public DataTable ConsultarMercaderiaXCodigo(int cod){
            using (MySqlCommand cmd = new MySqlCommand())
            {
                int capacidad = 0;
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", cod.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Codigo");
                    cmd.Parameters.AddWithValue("cod", -1);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.getConexion().Close();
                }
            }
        }
        public DataTable ConsultarMercaderiaXCodInterno(string codInterno) 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", codInterno.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Cod_Interno");
                    cmd.Parameters.AddWithValue("cod", -1);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);                   

                    return dt; 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.getConexion().Close();
                }
            }
        }
    }
}
