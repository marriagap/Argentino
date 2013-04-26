using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ventas_Milton.Datos
{
    class dMovimiento
    {
        static csConexion con = new csConexion();
        static int e;

        /**************************CONSULTAS****************************/
        public DataTable ConsultarXCodigo(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.IdMovimiento);
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
        public DataTable ConsultarXTipoMovimiento(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.TipoMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "TipoMov");
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
        public DataTable ConsultarXCantidadItems(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CantItems);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "CantidadItems");
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
        public DataTable ConsultarXCodInterno(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodInternoMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "CodInterno");
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
        public DataTable ConsultarXTipoComprobante(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodInternoMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "TipoComprobante");
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
        public DataTable ConsultarXMonto(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.MontoPago);
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
        public DataTable ConsultarXVendedor(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodVendedor);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Vendedor");
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
        public DataTable ConsultarXCliente(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodCliente);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Cliente");
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
        public DataTable ConsultarXOfertas(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodOfertas);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Ofertas");
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
        public DataTable ConsultarTodos()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", " ");
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", " ");
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

        /*************************ACTUALIZACIONES***********************/
        public void ModificarTipoMovimiento(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.TipoMovimiento);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "TipoMov");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarCantidadItems(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CantItems);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "CantidadItems");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarTipoComprobante(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.TipoComprobante);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "TipoComprobante");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarMontoPago(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.MontoPago);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "MontoPago");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarVendedor(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodVendedor);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Vendedor");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarCliente(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodCliente);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Cliente");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
        public void ModificarOfertas(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.CodOfertas);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Ofertas");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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

        /**************************ELIMINACION***************************/
        public void EliminarMovimiento(csMovimieto m)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "movimiento");
                    cmd.Parameters.AddWithValue("parm", m.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "E");
                    cmd.Parameters.AddWithValue("att", "eliminado");
                    cmd.Parameters.AddWithValue("cod", m.IdMovimiento);

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
