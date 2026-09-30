namespace ControlVehiculos
{
    partial class FormAgregarEditarVehiculo
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
            labelPlaca = new Label();
            textBoxPlaca = new TextBox();
            textBoxNoChofer = new TextBox();
            labelNumChofer = new Label();
            labelModelo = new Label();
            textBoxModelo = new TextBox();
            textBoxMarca = new TextBox();
            labelMarca = new Label();
            labelFechaCompra = new Label();
            dateTimeFechaCompra = new DateTimePicker();
            labelCosto = new Label();
            textBoxCosto = new TextBox();
            textBox1 = new TextBox();
            labelKm = new Label();
            buttonGuardar = new Button();
            labelPesos = new Label();
            SuspendLayout();
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(38, 26);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(44, 20);
            labelPlaca.TabIndex = 0;
            labelPlaca.Text = "Placa";
            labelPlaca.Click += this.label1_Click;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(38, 49);
            textBoxPlaca.MaxLength = 7;
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.PlaceholderText = "Ingrese la placa";
            textBoxPlaca.Size = new Size(134, 27);
            textBoxPlaca.TabIndex = 1;
            // 
            // textBoxNoChofer
            // 
            textBoxNoChofer.Location = new Point(38, 114);
            textBoxNoChofer.MaxLength = 2;
            textBoxNoChofer.Name = "textBoxNoChofer";
            textBoxNoChofer.PlaceholderText = "Ingrese el número de chofer";
            textBoxNoChofer.Size = new Size(200, 27);
            textBoxNoChofer.TabIndex = 2;
            // 
            // labelNumChofer
            // 
            labelNumChofer.AutoSize = true;
            labelNumChofer.Location = new Point(38, 91);
            labelNumChofer.Name = "labelNumChofer";
            labelNumChofer.Size = new Size(99, 20);
            labelNumChofer.TabIndex = 3;
            labelNumChofer.Text = "No. de chofer";
            labelNumChofer.Click += this.label1_Click_1;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(38, 159);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(61, 20);
            labelModelo.TabIndex = 4;
            labelModelo.Text = "Modelo";
            labelModelo.Click += this.label1_Click_2;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(38, 182);
            textBoxModelo.MaxLength = 4;
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.PlaceholderText = "Ingrese el modelo";
            textBoxModelo.Size = new Size(134, 27);
            textBoxModelo.TabIndex = 5;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(38, 251);
            textBoxMarca.MaxLength = 25;
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.PlaceholderText = "Ingrese la marca";
            textBoxMarca.Size = new Size(134, 27);
            textBoxMarca.TabIndex = 6;
            textBoxMarca.TextChanged += this.textBox1_TextChanged;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(38, 228);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(50, 20);
            labelMarca.TabIndex = 7;
            labelMarca.Text = "Marca";
            labelMarca.Click += this.label1_Click_3;
            // 
            // labelFechaCompra
            // 
            labelFechaCompra.AutoSize = true;
            labelFechaCompra.Location = new Point(330, 26);
            labelFechaCompra.Name = "labelFechaCompra";
            labelFechaCompra.Size = new Size(123, 20);
            labelFechaCompra.TabIndex = 8;
            labelFechaCompra.Text = "Fecha de compra";
            labelFechaCompra.Click += this.label1_Click_4;
            // 
            // dateTimeFechaCompra
            // 
            dateTimeFechaCompra.Location = new Point(330, 49);
            dateTimeFechaCompra.Name = "dateTimeFechaCompra";
            dateTimeFechaCompra.Size = new Size(293, 27);
            dateTimeFechaCompra.TabIndex = 10;
            // 
            // labelCosto
            // 
            labelCosto.AutoSize = true;
            labelCosto.Location = new Point(330, 91);
            labelCosto.Name = "labelCosto";
            labelCosto.Size = new Size(123, 20);
            labelCosto.TabIndex = 11;
            labelCosto.Text = "Costo de compra";
            labelCosto.Click += this.label1_Click_5;
            // 
            // textBoxCosto
            // 
            textBoxCosto.Location = new Point(348, 114);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.PlaceholderText = "Ingrese el costo de compra";
            textBoxCosto.Size = new Size(216, 27);
            textBoxCosto.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 179);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese el kilometraje actual";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 13;
            // 
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Location = new Point(330, 156);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(130, 20);
            labelKm.TabIndex = 14;
            labelKm.Text = "Kilometraje actual";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(330, 340);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += this.button1_Click;
            // 
            // labelPesos
            // 
            labelPesos.AutoSize = true;
            labelPesos.Location = new Point(330, 117);
            labelPesos.Name = "labelPesos";
            labelPesos.Size = new Size(17, 20);
            labelPesos.TabIndex = 16;
            labelPesos.Text = "$";
            // 
            // FormAgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPesos);
            Controls.Add(buttonGuardar);
            Controls.Add(labelKm);
            Controls.Add(textBox1);
            Controls.Add(textBoxCosto);
            Controls.Add(labelCosto);
            Controls.Add(dateTimeFechaCompra);
            Controls.Add(labelFechaCompra);
            Controls.Add(labelMarca);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxModelo);
            Controls.Add(labelModelo);
            Controls.Add(labelNumChofer);
            Controls.Add(textBoxNoChofer);
            Controls.Add(textBoxPlaca);
            Controls.Add(labelPlaca);
            Name = "FormAgregarVehiculo";
            Text = "Agregar vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlaca;
        private TextBox textBoxPlaca;
        private TextBox textBoxNoChofer;
        private Label labelNumChofer;
        private Label labelModelo;
        private TextBox textBoxModelo;
        private TextBox textBoxMarca;
        private Label labelMarca;
        private Label labelFechaCompra;
        private DateTimePicker dateTimeFechaCompra;
        private Label labelCosto;
        private TextBox textBoxCosto;
        private TextBox textBox1;
        private Label labelKm;
        private Button buttonGuardar;
        private Label labelPesos;
    }
}
