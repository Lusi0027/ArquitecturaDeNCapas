namespace CapaPresentacion
{
    partial class RegistroDeProductos
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            comboBoxCategoriaPDF = new ComboBox();
            buttonDescargarPDF = new Button();
            buttonIrCategoria = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxCategoria = new ComboBox();
            textBoxNombre = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxStock = new TextBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonLimpiar = new Button();
            buttonEliminar = new Button();
            buttonSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 12);
            label1.Name = "label1";
            label1.Size = new Size(353, 38);
            label1.TabIndex = 0;
            label1.Text = "Registro de productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(191, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 65);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(367, 23);
            label2.TabIndex = 0;
            label2.Text = "Reporte de productos por categoria:";
            // 
            // comboBoxCategoriaPDF
            // 
            comboBoxCategoriaPDF.FormattingEnabled = true;
            comboBoxCategoriaPDF.Location = new Point(385, 154);
            comboBoxCategoriaPDF.Name = "comboBoxCategoriaPDF";
            comboBoxCategoriaPDF.Size = new Size(120, 33);
            comboBoxCategoriaPDF.TabIndex = 2;
            // 
            // buttonDescargarPDF
            // 
            buttonDescargarPDF.BackColor = Color.IndianRed;
            buttonDescargarPDF.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDescargarPDF.ForeColor = SystemColors.ButtonFace;
            buttonDescargarPDF.Location = new Point(528, 149);
            buttonDescargarPDF.Name = "buttonDescargarPDF";
            buttonDescargarPDF.Size = new Size(167, 41);
            buttonDescargarPDF.TabIndex = 3;
            buttonDescargarPDF.Text = "Descargar PDF";
            buttonDescargarPDF.UseVisualStyleBackColor = false;
            buttonDescargarPDF.Click += buttonDescargarPDF_Click_1;
            // 
            // buttonIrCategoria
            // 
            buttonIrCategoria.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIrCategoria.Location = new Point(846, 128);
            buttonIrCategoria.Name = "buttonIrCategoria";
            buttonIrCategoria.Size = new Size(125, 40);
            buttonIrCategoria.TabIndex = 4;
            buttonIrCategoria.Text = "Categoria";
            buttonIrCategoria.UseVisualStyleBackColor = true;
            buttonIrCategoria.Click += buttonIrCategoria_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(476, 329);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 231);
            label3.Name = "label3";
            label3.Size = new Size(188, 23);
            label3.TabIndex = 0;
            label3.Text = "Lista de productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(661, 231);
            label4.Name = "label4";
            label4.Size = new Size(260, 23);
            label4.TabIndex = 0;
            label4.Text = "Informacion del producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(604, 288);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 0;
            label5.Text = " Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(604, 329);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 0;
            label6.Text = " Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(611, 374);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 0;
            label7.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(596, 421);
            label8.Name = "label8";
            label8.Size = new Size(114, 23);
            label8.TabIndex = 0;
            label8.Text = "Categoria:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(716, 417);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(185, 33);
            comboBoxCategoria.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(716, 282);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(165, 31);
            textBoxNombre.TabIndex = 7;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(716, 324);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(165, 31);
            textBoxPrecio.TabIndex = 7;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(716, 368);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(165, 31);
            textBoxStock.TabIndex = 7;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregar.Location = new Point(653, 480);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(125, 40);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificar.Location = new Point(807, 480);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(125, 40);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(653, 536);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(125, 40);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(807, 536);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(125, 40);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(745, 593);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(125, 40);
            buttonSalir.TabIndex = 4;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // RegistroDeProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1004, 647);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(comboBoxCategoria);
            Controls.Add(dataGridView1);
            Controls.Add(buttonModificar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonIrCategoria);
            Controls.Add(buttonDescargarPDF);
            Controls.Add(comboBoxCategoriaPDF);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RegistroDeProductos";
            Text = "Registro de productos";
            Load += RegistroDeProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private ComboBox comboBoxCategoriaPDF;
        private Button buttonDescargarPDF;
        private Button buttonIrCategoria;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxCategoria;
        private TextBox textBoxNombre;
        private TextBox textBoxPrecio;
        private TextBox textBoxStock;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonLimpiar;
        private Button buttonEliminar;
        private Button buttonSalir;
    }
}