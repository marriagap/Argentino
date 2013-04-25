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
        public DataTable ConsultarMercaderiaXCodigo(int cod)
        {
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
        public DataTable ConsultarMercaderiaXNombre(string nombre)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", nombre);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Nombre");
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
        public DataTable ConsultarMercaderiaXProveedor(string proveedor)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", proveedor);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Proveedor");
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
        public DataTable ConsultarMercaderiaXStock(int stock)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", stock.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Stock");
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
        public DataTable ConsultarMercaderiaXPrecioVenta(double precioVenta)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", precioVenta.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "PrecioVenta");
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
        public DataTable ConsultarMercaderiaXFechaAdqProd(DateTime fch1, DateTime fch2)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechas_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("fch1", fch1);
                    cmd.Parameters.AddWithValue("att", "FechaCompra_Prod");
                    cmd.Parameters.AddWithValue("fch2", fch2);

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
        public DataTable ConsultarMercaderiaXPrecioCompra(double precioCompra)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", precioCompra.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "PrecioCompra");
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
        public DataTable ConsultarMercaderiaXLote(string lote)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", lote);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Lote");
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
        public DataTable ConsultarMercaderiaXFechaVencimiento(DateTime fch1, DateTime fch2)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechas_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("fch1", fch1);
                    cmd.Parameters.AddWithValue("att", "FechaVencimiento");
                    cmd.Parameters.AddWithValue("fch2", fch2);

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
        public DataTable ConsultarMercaderiaXUbicacion(string ub)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", ub);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Ubicacion");
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
        public DataTable ConsultarMercaderiaXEstadp(string estado)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", estado);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "Estado");
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
        public DataTable ConsultarMercaderiaXUnidadMedida(string und)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", und);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "UnidadMedida");
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
        public DataTable ConsultarMercaderiaXMercaderiaIntegra(string m_padre)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", m_padre);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "MercaderiaIntegra");
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
        public DataTable ConsultarMercaderiaXMercaderiaIntegra(string m_padre)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operaFechasr_Tabla";
                    cmd.Parameters.AddWithValue("tabla", "Mercaderia");
                    cmd.Parameters.AddWithValue("parm", m_padre);
                    cmd.Parameters.AddWithValue("t_accion", "C");
                    cmd.Parameters.AddWithValue("att", "FamiliaProducto");
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

        /*******************ACTUALIZACIONES******************/
        public void ModificarNombre(int cod, string nombre)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", nombre);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Nombre");
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
        public void ModificarDescripcion(int cod, string descripcion)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", descripcion);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Descripcion");
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
        public void ModificarProveedor(int cod, string proveedor)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", proveedor);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Proveedor");
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
        public void ModificarStock(int cod, int stock)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", stock);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Stock");
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
        public void ModificarPrecioVenta(int cod, double precioVenta)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", precioVenta);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "PrecioVenta");
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
        public void ModificarFechaAdquisicionProduccion(int cod, DateTime fch)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", fch.ToShortDateString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaAdquisicionProduccion");
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
        public void ModificarLote(int cod, string lote)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", lote);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Lote");
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
        public void ModificarTipoLote(int cod, string tipoLote)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", tipoLote);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "TipoLote");
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
        public void ModificarMinimo(int cod, int minimo)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", minimo);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Minimo");
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
        public void ModificarFechaVencimiento(int cod, DateTime fch)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", fch);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "FechaVencimiento");
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
        public void ModificarEstado(int cod, string estado)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", estado);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Estado");
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
        public void ModificarMedida(int cod, int codUndMed)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", codUndMed.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Medida");
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
        public void ModificarFamilia(int cod, int codPadre)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", codPadre.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Familia");
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
        public void ModificarMercaderiaIntegral(int cod, int codMercaderia)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", codMercaderia);
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "MercaderiaIntegral");
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

        /***************************ELIMINACIONES******************************/
        public void EliminarMercaderia(int cod, int estado)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con.getConexion();
                    cmd.CommandText = "operar_Tabla";

                    cmd.Parameters.AddWithValue("tabla", "mercaderia");
                    cmd.Parameters.AddWithValue("parm", estado.ToString());
                    cmd.Parameters.AddWithValue("t_accion", "M");
                    cmd.Parameters.AddWithValue("att", "Eliminado");
                    cmd.Parameters.AddWithValue("cod", cod.ToString());

                    con.getConexion().Open();

                    MessageBox.Show(cmd.ExecuteNonQuery().ToString());
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
