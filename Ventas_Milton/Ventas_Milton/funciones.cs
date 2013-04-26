using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Ventas_Milton.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Ventas_Milton
{
    class funciones
    {
        public XmlNodeList LeeXML(String RutaXmlSinApp, String NombreGeneralXml, String NombreNodo)
        {
            XmlDocument xDoc = new XmlDocument();
            //la ubicación del archivo XML 
            xDoc.Load(Application.StartupPath + "\\" + RutaXmlSinApp);

            XmlNodeList GeneralXml = xDoc.GetElementsByTagName(NombreGeneralXml);
            //obtenemos una lista con los datos de los nodos que se encuentran dentro del nodo datos
            XmlNodeList listaDatos = ((XmlElement)GeneralXml[0]).GetElementsByTagName(NombreNodo);
            return listaDatos;
        }

        public void Query(string c)
        {
            csConexion cn = new csConexion();
            string q = c;
            try
            {
                MySqlCommand cmd = new MySqlCommand(q, cn.getConexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception e)
            {
                MostrarMensaje("Se encontró el siguente problema " + e.Message);
            }
        }

        public int QueryReturnInt(string c)
        {
            csConexion cn = new csConexion();
            string q = c;
            int i = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand(q, cn.getConexion());
                cmd.CommandType = CommandType.Text;
                i = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
            catch (Exception e)
            {
                i = 0;
                MostrarMensaje("Se encontró el siguente problema " + e.Message);
            }
            return i;
        }


        public DialogResult MostrarMensajeConfirmacion(String Titulo)
        {
            DialogResult result;
            result = MessageBox.Show(Titulo, "CONSERSA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }

        public void Mensaje_Advertencia(String Titulo)
        {
            MessageBox.Show(Titulo, "CONSERSA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void MostrarMensaje(String Titulo)
        {
            MessageBox.Show(Titulo, "CONSERSA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void CargarComboBox(DataTable Registro, System.Windows.Forms.ComboBox MyCombo, int indiceCadena)
        {
            Registro.DefaultView.Sort = (Registro.Columns[indiceCadena].ColumnName.ToString() + " ASC");
            MyCombo.DataSource = Registro;
            MyCombo.DisplayMember = Registro.Columns[indiceCadena].ColumnName.ToString();
            MyCombo.ValueMember = Registro.Columns[0].ColumnName.ToString();
        }

        public void CargarComboBox(DataTable Registro, System.Windows.Forms.ComboBox MyCombo)
        {
            Registro.DefaultView.Sort = (Registro.Columns[1].ColumnName.ToString() + " ASC");
            MyCombo.DataSource = Registro;
            MyCombo.DisplayMember = Registro.Columns[1].ColumnName.ToString();
            MyCombo.ValueMember = Registro.Columns[0].ColumnName.ToString();
        }

        public void CargarDataGrid(DataTable dt, System.Windows.Forms.DataGridView MyDataGridView)
        {
            MyDataGridView.DataSource = dt;
        }

        public Boolean ElementoObligatorio(TextBox t, string l)
        {
            Boolean b = true;
            if (t.Text.Trim().Length == 0)
            {
                Mensaje_Advertencia("Campo " + l + " es obligatorio");
                b = false;
            }
            return b;
        }

        public Boolean ElementoObligatorio(ComboBox b, string l)
        {
            Boolean c = true;
            if (b.SelectedIndex == -1)
            {
                Mensaje_Advertencia("Campo " + l + " es obligatorio");
                c = false;
            }
            return c;
        }

        public void Validacion_SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != 8 && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        public void Validacion_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != 8 && !char.IsNumber(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        public void Validacion_Precio(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != 8 && !char.IsNumber(e.KeyChar) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        public void Validacion_LetrasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != 8 && !char.IsNumber(e.KeyChar) && e.KeyChar != 32 && !char.IsPunctuation(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string ConvertMysqlDateTime(DateTime paramDateTime)
        {

            string time; int year; int month; int day;

            time = paramDateTime.TimeOfDay.ToString();
            year = paramDateTime.Year;
            month = paramDateTime.Month;
            day = paramDateTime.Day;
            string dateTime;

            try
            {
                string hour = time.Substring(0, 2);
                int hourInt = int.Parse(hour);
                if (hourInt >= 24)
                {
                    throw new ArgumentOutOfRangeException("Invalid hour");
                }

                string minute = time.Substring(3, 2);
                int minuteInt = int.Parse(minute);
                if (minuteInt >= 60)
                {
                    throw new ArgumentOutOfRangeException("Invalid minute");
                }
                dateTime = year + "-" + month + "-" + day + " " + hour + ":" + minute;
            }
            catch { return null; }

            return dateTime;

        }

        public string ConvertMysqlDate(DateTime paramDateTime)
        {

            string time; int year; int month; int day;

            time = paramDateTime.TimeOfDay.ToString();
            year = paramDateTime.Year;
            month = paramDateTime.Month;
            day = paramDateTime.Day;
            string dateTime;

            try
            {
                string hour = time.Substring(0, 2);
                int hourInt = int.Parse(hour);
                if (hourInt >= 24)
                {
                    throw new ArgumentOutOfRangeException("Invalid hour");
                }

                string minute = time.Substring(3, 2);
                int minuteInt = int.Parse(minute);
                if (minuteInt >= 60)
                {
                    throw new ArgumentOutOfRangeException("Invalid minute");
                }
                dateTime = year + "-0" + month + "-0" + day;
            }
            catch { return null; }

            return dateTime;

        }

        public string ConvertMysqlTime(DateTime paramDateTime)
        {
            string time; int year; int month; int day;

            time = paramDateTime.TimeOfDay.ToString();
            year = paramDateTime.Year;
            month = paramDateTime.Month;
            day = paramDateTime.Day;
            string dateTime;

            try
            {
                string hour = time.Substring(0, 2);
                int hourInt = int.Parse(hour);
                if (hourInt >= 24)
                {
                    throw new ArgumentOutOfRangeException("Invalid hour");
                }

                string minute = time.Substring(3, 2);
                int minuteInt = int.Parse(minute);
                if (minuteInt >= 60)
                {
                    throw new ArgumentOutOfRangeException("Invalid minute");
                }
                dateTime = hour + ":" + minute;
            }
            catch { return null; }

            return dateTime;
        }

        public void cursorBoton(Control c, int estado)
        {
            if (estado == 1)
            {
                c.BackColor = Color.LightCyan;
            }
            else
            {
                c.BackColor = Color.White;
            }
        }

        public void textBoxFocus(TextBox txt, int estado)
        {
            if (estado == 1)
            {
                txt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption; ;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

        public bool EsEntero(System.Windows.Forms.TextBox miTextBox)
        {
            int aux;

            if (int.TryParse(miTextBox.Text, out aux))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Este Campo Solo Admite Numeros", "Mensaje Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                miTextBox.Focus();

                return false;
            }
        }

        public bool EsDouble(System.Windows.Forms.TextBox mitextBox)
        {
            string a = mitextBox.Text;
            double aux;
            if (double.TryParse(a, out aux))
            {

                return true;
            }
            else
            {
                MessageBox.Show("Este Campo Solo Admite Numeros", "Mensaje Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mitextBox.Focus();
                return false;
            }

        }

        public bool EsDouble(System.Windows.Forms.Label milabel)
        {
            double aux;
            if (double.TryParse(milabel.Text, out aux))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Este Campo Solo Admite Numeros", "Mensaje Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                milabel.Focus();
                return false;
            }

        }

        public bool EsDouble(string micadena)
        {
            double aux;
            if (double.TryParse(micadena, out aux))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Este Campo Solo Admite Numeros", "Mensaje Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

        }

        public bool EsCadena(System.Windows.Forms.TextBox miTextBox)
        {
            int aux;

            if (int.TryParse(miTextBox.Text, out aux))
            {
                MessageBox.Show("Este Campo Solo Admite Lestras", "Mensaje Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                miTextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public String NumeroALetras(String num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private String NumeroALetras(Double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }

            return Num2Text;
        }

        public String ObtenerHashCode(string str)
        {
            string rethash = "";
            try
            {
                System.Security.Cryptography.SHA1 hash = System.Security.Cryptography.SHA1.Create();
                System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
                byte[] combined = encoder.GetBytes(str);
                hash.ComputeHash(combined);
                rethash = Convert.ToBase64String(hash.Hash);
            }
            catch (Exception ex)
            {
                string strerr = "Error in HashCode : " + ex.Message;
            }
            return rethash;
        }

        public void AccionFrm(System.Windows.Forms.Form Frm, String Titulo, String Accion)
        {
            Frm.Text = Titulo + " * Acción: " + Accion;
        }

        public Boolean VerificarItem(DataTable dt, String fila, String Caracter)
        {
            for (int i = 0; i < Convert.ToInt32(dt.Rows.Count); i++)
            {
                if (Caracter == Convert.ToString(dt.Rows[i][fila]))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean ValidarTexto(System.Windows.Forms.TextBox NombreTextBox, String Titulo)
        {
            if (NombreTextBox.Text.Trim() == "")
            {
                MessageBox.Show(Titulo, "COPROVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTextBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean ValidarTexto(System.Windows.Forms.TextBox NombreTextBox, String Titulo, System.Windows.Forms.TextBox TextBoxFocus)
        {
            if (NombreTextBox.Text.Trim() == "")
            {
                MessageBox.Show(Titulo, "COPROVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxFocus.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean ValidarComboBox(System.Windows.Forms.ComboBox NombreComboBox, String Titulo)
        {
            if (Convert.ToInt32(NombreComboBox.SelectedValue) == 0)
            {
                MessageBox.Show(Titulo, "COPROVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreComboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CargarListView(DataTable dt, ListView Lv)
        {
            Lv.Items.Clear();
            Lv.Columns.Clear();

            foreach (DataColumn col in dt.Columns)
            {
                Lv.Columns.Add(col.ColumnName, col.ColumnName);
            }

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem LstElemento = new ListViewItem();
                LstElemento.Text = row[0].ToString();

                for (int i = 1; i <= dt.Columns.Count - 1; i++)
                {
                    LstElemento.SubItems.Add(row[i].ToString());
                }
                Lv.Items.Add(LstElemento);
            }
        }

        public void validarnumeroscajatexto(System.Windows.Forms.TextBox micajatexto, System.Windows.Forms.ErrorProvider mierrorprovider, System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar) != 32)
            {
                e.Handled = true;
                mierrorprovider.SetError(micajatexto, "En este Campo solo se Admiten Números");

            }
            else
            {
                mierrorprovider.SetError(micajatexto, null);
            }
        }

        public void validarletrascajatexto(System.Windows.Forms.TextBox micajatexto, System.Windows.Forms.ErrorProvider mierrorprovider, System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 32))
            {
                e.Handled = true;
                mierrorprovider.SetError(micajatexto, "En este campo solo se Admiten Letras");
            }
            else
            {
                mierrorprovider.SetError(micajatexto, null);
            }

        }

        public void AnimarButtonHorizontal(Button miBoton, Int32 indice, Control Control, string Mensaje)
        {
            int x = miBoton.Location.Y;
            if (indice == 1)
            {
                miBoton.Size = new System.Drawing.Size(61, 61);
                miBoton.Location = new System.Drawing.Point(1, x - 2);
                miBoton.BackColor = System.Drawing.Color.MediumAquamarine;
            }
            else
            {
                miBoton.Size = new System.Drawing.Size(60, 60);
                miBoton.Location = new System.Drawing.Point(3, x + 2);
                miBoton.BackColor = System.Drawing.Color.White;
            }
            Control.Text = Mensaje;
        }

        public void AnimarButtonHorizontal(Button miBoton, Int32 indice, ToolStripLabel Control, string Mensaje)
        {
            int x = miBoton.Location.Y;
            if (indice == 1)
            {
                miBoton.Size = new System.Drawing.Size(61, 61);
                miBoton.Location = new System.Drawing.Point(1, x - 2);
                miBoton.BackColor = System.Drawing.Color.MediumAquamarine;
            }
            else
            {
                miBoton.Size = new System.Drawing.Size(60, 60);
                miBoton.Location = new System.Drawing.Point(3, x + 2);
                miBoton.BackColor = System.Drawing.Color.White;
            }
            Control.Text = Mensaje;
        }














    }
}
