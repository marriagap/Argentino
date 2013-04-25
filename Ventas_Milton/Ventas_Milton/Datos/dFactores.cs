using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dFactores
    {
        static csConexion con = new csConexion();

        /***************************CONSULTAS***************************/
        public DataTable ConsultarXCodigo(int cod)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
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
        public DataTable ConsultarXTabla(string tabla)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", tabla);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Tabla");
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
        public DataTable ConsultarXConcepto(string tabla)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", tabla);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Tabla");
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
        public DataTable ConsultarXMonto(string monto)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", monto);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Monto");
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
        public DataTable ConsultaTodos()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", " ");
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Todos");
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


        /**************************ACTUALIZACIONES************************/
        public void ModificarTabla(int cod, string tabla)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", tabla);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Tabla");
                    cmd.Parameters.AddWithValue("cod", cod);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
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
        public void ModificarConcepto(int cod, string concepto)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", concepto);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Concepto");
                    cmd.Parameters.AddWithValue("cod", cod);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
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
        public void ModificarMonto(int cod, string monto)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", monto);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Monto");
                    cmd.Parameters.AddWithValue("cod", cod);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
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

        /*****************************ELIMINACION**************************/
        public void EliminarFactores(int cod, int estado)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", estado.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "E");
                    cmd.Parameters.AddWithValue("att", " ");
                    cmd.Parameters.AddWithValue("cod", cod);

                    con.getConexion().Open();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
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
