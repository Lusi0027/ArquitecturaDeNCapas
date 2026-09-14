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
    public partial class RegistroDeCategorias : Form
    {
        CapaNegocio.NegocioCategoria servicioDB = new CapaNegocio.NegocioCategoria();
        private string? id = null;
        private bool editar = false;

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

        private void RegistroDeCategorias_Load_1(object sender, EventArgs e)
        {
            MostrarCategorias();
        }

        //Metodo para mostrar las categorias en el DataGridView
        public void MostrarCategorias()
        {
            try
            {
                var dt = servicioDB.MostrarCategorias();
                dataGridView1.DataSource = dt;
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

                id = fila.Cells["IdCategoria"].Value?.ToString();
                textBoxNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                textBoxDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? string.Empty;

                editar = true;
            }
        }

        //Metodo para insertar una categoria
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    servicioDB.InsertData(
                      textBoxNombre.Text,
                      textBoxDescripcion.Text
                    );
                    MessageBox.Show("Categoría agregada correctamente");
                    LimpiarCampos();
                    MostrarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Metodo para modificar una categoria existente
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (editar == true && id != null)
            {
                try
                {
                    servicioDB.UpdateData(
                      int.Parse(id),
                      textBoxNombre.Text,
                      textBoxDescripcion.Text
                    );
                    MessageBox.Show("Categoría modificada correctamente");
                    LimpiarCampos();
                    MostrarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoría de la lista para modificar");
            }
        }

        //Metodo para eliminar una categoria existente
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de eliminar esta categoría?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        servicioDB.DeleteData(int.Parse(id));
                        MessageBox.Show("Categoría eliminada correctamente");
                        LimpiarCampos();
                        MostrarCategorias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoría de la lista para eliminar");
            }
        }
        //Metodo para descargar el reporte de todas las categorias en PDF
        private void buttonDescargarPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dt = servicioDB.MostrarCategorias();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay categorías registradas");
                    return;
                }

                SaveFileDialog guardarDialogo = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    FileName = "Reporte_Categorias.pdf"
                };

                if (guardarDialogo.ShowDialog() == DialogResult.OK)
                {
                    GenerarPDF(dt, guardarDialogo.FileName);
                    MessageBox.Show("Reporte generado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para armar el documento PDF con QuestPDF
        private void GenerarPDF(DataTable dt, string rutaArchivo)
        {
            Document.Create(documento =>
            {
                documento.Page(pagina =>
                {
                    pagina.Margin(30);

                    pagina.Header()
                        .Text("Reporte de Categorías")
                        .FontSize(16)
                        .Bold();

                    pagina.Content().Table(tabla =>
                    {
                        tabla.ColumnsDefinition(columnas =>
                        {
                            columnas.RelativeColumn();
                            columnas.RelativeColumn(2);
                            columnas.RelativeColumn(3);
                        });

                        tabla.Header(encabezado =>
                        {
                            encabezado.Cell().Text("Id").Bold();
                            encabezado.Cell().Text("Nombre").Bold();
                            encabezado.Cell().Text("Descripción").Bold();
                        });

                        foreach (DataRow fila in dt.Rows)
                        {
                            tabla.Cell().Text(fila["IdCategoria"].ToString());
                            tabla.Cell().Text(fila["Nombre"].ToString());
                            tabla.Cell().Text(fila["Descripcion"].ToString());
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
            textBoxDescripcion.Clear();
            id = null;
            editar = false;
        }

        
    }
}