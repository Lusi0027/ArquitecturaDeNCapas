namespace CapaPresentacion
{
    partial class RegistroDeCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxDescripcion = new TextBox();
            textBoxNombre = new TextBox();
            dataGridView1 = new DataGridView();
            buttonModificar = new Button();
            buttonSalir = new Button();
            buttonEliminar = new Button();
            buttonLimpiar = new Button();
            buttonAgregar = new Button();
            buttonIrProducto = new Button();
            buttonDescargarPDF = new Button();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(694, 324);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(165, 98);
            textBoxDescripcion.TabIndex = 27;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(694, 282);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(165, 31);
            textBoxNombre.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(476, 329);
            dataGridView1.TabIndex = 24;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificar.Location = new Point(756, 466);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(125, 40);
            buttonModificar.TabIndex = 22;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(694, 588);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(125, 40);
            buttonSalir.TabIndex = 21;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(756, 522);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(125, 40);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(602, 522);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(125, 40);
            buttonLimpiar.TabIndex = 19;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregar.Location = new Point(602, 466);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(125, 40);
            buttonAgregar.TabIndex = 23;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonIrProducto
            // 
            buttonIrProducto.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIrProducto.Location = new Point(770, 133);
            buttonIrProducto.Name = "buttonIrProducto";
            buttonIrProducto.Size = new Size(125, 40);
            buttonIrProducto.TabIndex = 18;
            buttonIrProducto.Text = "Producto";
            buttonIrProducto.UseVisualStyleBackColor = true;
            buttonIrProducto.Click += buttonIrProducto_Click;
            // 
            // buttonDescargarPDF
            // 
            buttonDescargarPDF.BackColor = Color.IndianRed;
            buttonDescargarPDF.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDescargarPDF.ForeColor = SystemColors.ButtonFace;
            buttonDescargarPDF.Location = new Point(513, 133);
            buttonDescargarPDF.Name = "buttonDescargarPDF";
            buttonDescargarPDF.Size = new Size(167, 41);
            buttonDescargarPDF.TabIndex = 17;
            buttonDescargarPDF.Text = "Descargar PDF";
            buttonDescargarPDF.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(610, 217);
            label4.Name = "label4";
            label4.Size = new Size(285, 23);
            label4.TabIndex = 13;
            label4.Text = "Informacion de la categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(555, 357);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 10;
            label6.Text = " Descripcion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(582, 288);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 9;
            label5.Text = " Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 217);
            label3.Name = "label3";
            label3.Size = new Size(194, 23);
            label3.TabIndex = 8;
            label3.Text = "Lista de categorias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 141);
            label2.Name = "label2";
            label2.Size = new Size(234, 23);
            label2.TabIndex = 14;
            label2.Text = "Reporte de categorias:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(184, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 65);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 12);
            label1.Name = "label1";
            label1.Size = new Size(363, 38);
            label1.TabIndex = 0;
            label1.Text = "Registro de categorias";
            // 
            // RegistroDeCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(924, 646);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(dataGridView1);
            Controls.Add(buttonModificar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonIrProducto);
            Controls.Add(buttonDescargarPDF);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RegistroDeCategorias";
            Text = "Registro de categorias";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStock;
        private TextBox textBoxDescripcion;
        private TextBox textBoxNombre;
        private ComboBox comboBoxCategoria;
        private DataGridView dataGridView1;
        private Button buttonModificar;
        private Button buttonSalir;
        private Button buttonEliminar;
        private Button buttonLimpiar;
        private Button buttonAgregar;
        private Button buttonIrProducto;
        private Button buttonDescargarPDF;
        private ComboBox comboBoxCategoriaPDF;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}