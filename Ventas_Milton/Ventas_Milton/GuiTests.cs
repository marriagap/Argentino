using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ventas_Milton.Datos;

namespace Ventas_Milton
{
    public partial class GuiTests : Form
    {
        public GuiTests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csConexion con = new csConexion();
            con.getConexion();
        }
    }
}
