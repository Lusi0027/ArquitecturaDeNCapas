using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistroDeProductos : Form
    {
        public RegistroDeProductos()
        {
            InitializeComponent();
        }

        //Boton salir
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para ir al form de categorias
        private void buttonIrCategoria_Click(object sender, EventArgs e)
        {
            RegistroDeCategorias categorias = new RegistroDeCategorias();
            this.Hide();
            categorias.Show();
        }
















        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
