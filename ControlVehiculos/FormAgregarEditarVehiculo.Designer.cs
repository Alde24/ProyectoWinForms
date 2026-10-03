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
            txtPlaca = new TextBox();
            txtNoChofer = new TextBox();
            labelNumChofer = new Label();
            labelModelo = new Label();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            labelMarca = new Label();
            labelFechaCompra = new Label();
            dateTimeFechaCompra = new DateTimePicker();
            labelCosto = new Label();
            txtCosto = new TextBox();
            txtKilometraje = new TextBox();
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
            labelPlaca.Click += label1_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(38, 49);
            txtPlaca.MaxLength = 7;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PlaceholderText = "Ej. AAA-123";
            txtPlaca.Size = new Size(134, 27);
            txtPlaca.TabIndex = 1;
            // 
            // txtNoChofer
            // 
            txtNoChofer.Location = new Point(38, 114);
            txtNoChofer.MaxLength = 2;
            txtNoChofer.Name = "txtNoChofer";
            txtNoChofer.PlaceholderText = "Ej.10";
            txtNoChofer.Size = new Size(200, 27);
            txtNoChofer.TabIndex = 2;
            // 
            // labelNumChofer
            // 
            labelNumChofer.AutoSize = true;
            labelNumChofer.Location = new Point(38, 91);
            labelNumChofer.Name = "labelNumChofer";
            labelNumChofer.Size = new Size(99, 20);
            labelNumChofer.TabIndex = 3;
            labelNumChofer.Text = "No. de chofer";
            labelNumChofer.Click += label1_Click_1;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(38, 159);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(61, 20);
            labelModelo.TabIndex = 4;
            labelModelo.Text = "Modelo";
            labelModelo.Click += label1_Click_2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(38, 182);
            txtModelo.MaxLength = 4;
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Ej. 2022";
            txtModelo.Size = new Size(134, 27);
            txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(38, 251);
            txtMarca.MaxLength = 25;
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Ej. Mazda";
            txtMarca.Size = new Size(134, 27);
            txtMarca.TabIndex = 6;
            txtMarca.TextChanged += textBox1_TextChanged;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(38, 228);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(50, 20);
            labelMarca.TabIndex = 7;
            labelMarca.Text = "Marca";
            labelMarca.Click += label1_Click_3;
            // 
            // labelFechaCompra
            // 
            labelFechaCompra.AutoSize = true;
            labelFechaCompra.Location = new Point(330, 26);
            labelFechaCompra.Name = "labelFechaCompra";
            labelFechaCompra.Size = new Size(123, 20);
            labelFechaCompra.TabIndex = 8;
            labelFechaCompra.Text = "Fecha de compra";
            labelFechaCompra.Click += label1_Click_4;
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
            labelCosto.Click += label1_Click_5;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(348, 114);
            txtCosto.Name = "txtCosto";
            txtCosto.PlaceholderText = "Ej. 500000.00";
            txtCosto.Size = new Size(216, 27);
            txtCosto.TabIndex = 12;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(328, 179);
            txtKilometraje.MaxLength = 10;
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.PlaceholderText = "Ej. 150.50";
            txtKilometraje.Size = new Size(197, 27);
            txtKilometraje.TabIndex = 13;
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
            buttonGuardar.Click += buttonGuardar_Click;
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
            // FormAgregarEditarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPesos);
            Controls.Add(buttonGuardar);
            Controls.Add(labelKm);
            Controls.Add(txtKilometraje);
            Controls.Add(txtCosto);
            Controls.Add(labelCosto);
            Controls.Add(dateTimeFechaCompra);
            Controls.Add(labelFechaCompra);
            Controls.Add(labelMarca);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(labelModelo);
            Controls.Add(labelNumChofer);
            Controls.Add(txtNoChofer);
            Controls.Add(txtPlaca);
            Controls.Add(labelPlaca);
            Name = "FormAgregarEditarVehiculo";
            Text = "Agregar vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlaca;
        private TextBox txtPlaca;
        private TextBox txtNoChofer;
        private Label labelNumChofer;
        private Label labelModelo;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label labelMarca;
        private Label labelFechaCompra;
        private DateTimePicker dateTimeFechaCompra;
        private Label labelCosto;
        private TextBox txtCosto;
        private TextBox txtKilometraje;
        private Label labelKm;
        private Button buttonGuardar;
        private Label labelPesos;
    }
}
