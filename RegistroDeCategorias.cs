using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistroDeCategorias : Form
    {
        public RegistroDeCategorias()
        {
            InitializeComponent();
        }

        //Boton salir
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton para ir al form productos
        private void buttonIrProducto_Click(object sender, EventArgs e)
        {
            RegistroDeProductos productos = new RegistroDeProductos();
            this.Hide();
            productos.Show();
        }
    }
}
