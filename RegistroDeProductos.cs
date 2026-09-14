using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class RegistroDeProductos : Form
    {
        CapaNegocio.NegocioProducto servicioDB = new CapaNegocio.NegocioProducto();
        private string? id = null;
        private bool editar = false;

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

        private void RegistroDeProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            MostrarCategorias();
            MostrarCategoriasPDF();
        }

        //Metodo para mostrar los productos del DataGridView 
        public void MostrarProductos()
        {
            try
            {
                var dt = servicioDB.MostrarProductos();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para cargar las categorias en el ComboBox
        private void MostrarCategorias()
        {
            try
            {
                CapaNegocio.NegocioCategoria servicioCategorias = new CapaNegocio.NegocioCategoria();
                var dt = servicioCategorias.MostrarCategorias();

                comboBoxCategoria.DataSource = dt;
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "IdCategoria";
                comboBoxCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para cargar los datos de la fila seleccionada en los campos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                id = fila.Cells["IdProducto"].Value?.ToString();
                textBoxNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                textBoxStock.Text = fila.Cells["Stock"].Value?.ToString() ?? string.Empty;
                textBoxPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? string.Empty;

                var categoriaValue = fila.Cells["IdCategoria"].Value;
                if (categoriaValue != null && categoriaValue != DBNull.Value)
                {
                    comboBoxCategoria.SelectedValue = categoriaValue;
                }
                else
                {
                    comboBoxCategoria.SelectedIndex = -1;
                }

                editar = true;
            }
        }

        //Metodo para insertar un producto
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (comboBoxCategoria.SelectedValue == null || comboBoxCategoria.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Selecciona una categoría antes de agregar el producto");
                    return;
                }

                try
                {
                    servicioDB.InsertData(
                      textBoxNombre.Text,
                      int.Parse(textBoxStock.Text),
                      decimal.Parse(textBoxPrecio.Text),
                      Convert.ToInt32(comboBoxCategoria.SelectedValue)
                    );
                    MessageBox.Show("Producto agregado correctamente");
                    LimpiarCampos();
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Metodo para modificar un producto existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (editar == true && id != null)
            {
                if (comboBoxCategoria.SelectedValue == null || comboBoxCategoria.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Selecciona una categoría antes de modificar el producto");
                    return;
                }

                try
                {
                    servicioDB.UpdateData(
                      int.Parse(id),
                      textBoxNombre.Text,
                      int.Parse(textBoxStock.Text),
                      decimal.Parse(textBoxPrecio.Text),
                      Convert.ToInt32(comboBoxCategoria.SelectedValue)
                    );
                    MessageBox.Show("Producto modificado correctamente");
                    LimpiarCampos();
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto de la lista para modificar");
            }
        }

        //Metodo para eliminar un producto existente
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        servicioDB.DeleteData(int.Parse(id));
                        MessageBox.Show("Producto eliminado correctamente");
                        LimpiarCampos();
                        MostrarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto de la lista para eliminar");
            }
        }

        //Metodo para cargar las categorias en el combo del reporte
        private void MostrarCategoriasPDF()
        {
            try
            {
                CapaNegocio.NegocioCategoria servicioCategorias = new CapaNegocio.NegocioCategoria();
                var dt = servicioCategorias.MostrarCategorias();

                comboBoxCategoriaPDF.DataSource = dt;
                comboBoxCategoriaPDF.DisplayMember = "Nombre";
                comboBoxCategoriaPDF.ValueMember = "IdCategoria";
                comboBoxCategoriaPDF.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para descargar el reporte de productos por categoria en PDF
        private void buttonDescargarPDF_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCategoriaPDF.SelectedValue == null || comboBoxCategoriaPDF.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Selecciona una categoría para generar el reporte");
                return;
            }

            try
            {
                int idCategoria = Convert.ToInt32(comboBoxCategoriaPDF.SelectedValue);
                string nombreCategoria = comboBoxCategoriaPDF.Text;

                var dt = servicioDB.MostrarProductosPorCategoria(idCategoria);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos registrados en esta categoría");
                    return;
                }

                SaveFileDialog guardarDialogo = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    FileName = $"Reporte_{nombreCategoria}.pdf"
                };

                if (guardarDialogo.ShowDialog() == DialogResult.OK)
                {
                    GenerarPDF(dt, nombreCategoria, guardarDialogo.FileName);
                    MessageBox.Show("Reporte generado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //Metodo para armar el documento PDF con QuestPDF
        private void GenerarPDF(DataTable dt, string nombreCategoria, string rutaArchivo)
        {
            Document.Create(documento =>
            {
                documento.Page(pagina =>
                {
                    pagina.Margin(30);

                    pagina.Header()
                        .Text($"Reporte de Productos - Categoría: {nombreCategoria}")
                        .FontSize(16)
                        .Bold();

                    pagina.Content().Table(tabla =>
                    {
                        tabla.ColumnsDefinition(columnas =>
                        {
                            columnas.RelativeColumn();
                            columnas.RelativeColumn(2);
                            columnas.RelativeColumn();
                            columnas.RelativeColumn();
                        });

                        tabla.Header(encabezado =>
                        {
                            encabezado.Cell().Text("Id").Bold();
                            encabezado.Cell().Text("Nombre").Bold();
                            encabezado.Cell().Text("Stock").Bold();
                            encabezado.Cell().Text("Precio").Bold();
                        });

                        foreach (DataRow fila in dt.Rows)
                        {
                            tabla.Cell().Text(fila["IdProducto"].ToString());
                            tabla.Cell().Text(fila["Nombre"].ToString());
                            tabla.Cell().Text(fila["Stock"].ToString());
                            tabla.Cell().Text(fila["Precio"].ToString());
                        }
                    });
                });
            })
            .GeneratePdf(rutaArchivo);
        }


        //Metodo para limpiar los campos del formulario
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxPrecio.Clear();
            textBoxStock.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            id = null;
            editar = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}