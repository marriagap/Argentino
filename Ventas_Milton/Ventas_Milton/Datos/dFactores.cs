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
        static int e;

        /***************************CONSULTAS***************************/
        public DataTable ConsultarXCodigo(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.IdFactores);
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
        public DataTable ConsultarXTabla(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Tabla);
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
        public DataTable ConsultarXConcepto(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Concepto);
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
        public DataTable ConsultarXMonto(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Monto);
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
        public void ModificarTabla(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Tabla);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Tabla");
                    cmd.Parameters.AddWithValue("cod", f.IdFactores);

                    con.getConexion().Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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
        public void ModificarConcepto(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Concepto);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Concepto");
                    cmd.Parameters.AddWithValue("cod", f.IdFactores);

                    con.getConexion().Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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
        public void ModificarMonto(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Monto);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Monto");
                    cmd.Parameters.AddWithValue("cod", f.IdFactores);

                    con.getConexion().Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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
        public void EliminarFactores(csFactores f)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "factores");
                    cmd.Parameters.AddWithValue("parm", f.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "E");
                    cmd.Parameters.AddWithValue("att", " ");
                    cmd.Parameters.AddWithValue("cod", f.IdFactores);

                    con.getConexion().Open();
                    e = cmd.ExecuteNonQuery();
                    if (e == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Modificación, ERROR!");
                    }
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
