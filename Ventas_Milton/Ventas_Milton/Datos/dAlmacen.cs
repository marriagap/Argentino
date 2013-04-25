using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace Ventas_Milton.Datos
{
    class dAlmacen
    {
        static csConexion con = new csConexion();
        static int estado;

        /*********************CONSULTAS*********************/
        public DataTable ConsultarXCapAlmacen(int cap) {
            using (MySqlCommand cmd = new MySqlCommand()) 
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", cap.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Capacidad");
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
        public DataTable ConsultarTodos() {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", " " );
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
        public DataTable ConsultarAlmacenXCodigo(int cod) 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
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

        /********************ACTUALIZACION******************/        
        public void ModificarCapacidad(int cod, int cap) 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", cap.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Capacidad");
                    cmd.Parameters.AddWithValue("cod", cod.ToString());

                    con.getConexion().Open();
                    estado = cmd.ExecuteNonQuery();
                    if (estado == 0) 
                    {
                        MessageBox.Show("No se pudo realizar la modificacion, ERROR!");
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

        /**********************ELIMINAR*********************/
        public void EliminarAlmacen(int cod, int estado)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", estado.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Estado");
                    cmd.Parameters.AddWithValue("cod", cod.ToString());

                    con.getConexion().Open();

                    estado = cmd.ExecuteNonQuery();
                    if (estado == 0)
                    {
                        MessageBox.Show("No se pudo realizar la Eliminación, ERROR!");
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
