using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ventas_Milton.Vista
{
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        int tipoGuardado = 0;


        funciones funciones = new funciones();

        #region /*********  Personalizar Ventana **********/

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnNuevo, 1, lblEstado, "Ingresar nuevo registro");
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnNuevo, 0, lblEstado, "");
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnModificar, 1, lblEstado, "Modificar registro seleccionado");
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnModificar, 0, lblEstado, "");
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnEliminar, 1, lblEstado, "Eliminar registro seleccionado");
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnEliminar, 0, lblEstado, "");
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnGuardar, 1, lblEstado, "Guardar");
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnGuardar, 0, lblEstado, "");
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnCancelar, 1, lblEstado, "Cancelar la operacion");
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnCancelar, 0, lblEstado, "");
        }

        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnImprimir, 1, lblEstado, "Imprimir registros");
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            funciones.AnimarButtonHorizontal(btnImprimir, 0, lblEstado, "");
        }

        #endregion

        void inicio()
        {
        }

        void cargarDatos() { 
        }

        void nuevo() { 
        }

        void modificar() { 
        }

        void eliminar() { 
        }

        void guardar() { 
        }

        void cancelar() { 
        }

        void imprimir() { 
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
