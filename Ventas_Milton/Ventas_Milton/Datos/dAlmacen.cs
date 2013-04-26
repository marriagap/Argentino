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
        public DataTable ConsultarXCapAlmacen(csAlmacen a) {
            using (MySqlCommand cmd = new MySqlCommand()) 
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", a.CapMaxLotes);
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
        public DataTable ConsultarAlmacenXCodigo(csAlmacen a) 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", a.IdAlmacen);
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
        public void ModificarCapacidad(csAlmacen a) 
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", a.CapMaxLotes);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Capacidad");
                    cmd.Parameters.AddWithValue("cod", a.IdAlmacen);

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
        public void EliminarAlmacen(csAlmacen a)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "almacen");
                    cmd.Parameters.AddWithValue("parm", a.Eliminado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Estado");
                    cmd.Parameters.AddWithValue("cod", a.IdAlmacen);

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

        /*******************INSERCIONES*********************/
        public void InsertarNuevoAlmacen(csAlmacen a) 
        {
            string sqlquery = "INSERT INTO ALMACEN(capacidadMaxDeLotes,eliminado) VALUES(@capacidadMaxDeLotes,@Eliminado)";
            MySqlConnection cn = con.getConexion();
            cn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlquery, con.getConexion());
                cmd.Parameters.Add("@capacidadMaxDeLote", a.CapMaxLotes);
                cmd.Parameters.Add("@Eliminado", a.Eliminado);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@IDENTITY";

                int ID_Insertado = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                cmd = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally 
            {
                cn.Close();
            }
            MessageBox.Show("La Inserción se realizó Existosamente!");
        }
    }
}
