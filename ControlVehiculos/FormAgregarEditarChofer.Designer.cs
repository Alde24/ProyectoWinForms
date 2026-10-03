namespace ControlVehiculos
{
    partial class FormAgregarEditarChofer
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
            labelNumeroChofer = new Label();
            txtNumeroChofer = new TextBox();
            labelNombre = new Label();
            txtNombreChofer = new TextBox();
            labelFechaIngreso = new Label();
            dateTimeFechaIngreso = new DateTimePicker();
            labelSueldo = new Label();
            labelSignoPesos = new Label();
            txtSueldo = new TextBox();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // labelNumeroChofer
            // 
            labelNumeroChofer.AutoSize = true;
            labelNumeroChofer.Location = new Point(34, 24);
            labelNumeroChofer.Name = "labelNumeroChofer";
            labelNumeroChofer.Size = new Size(130, 20);
            labelNumeroChofer.TabIndex = 0;
            labelNumeroChofer.Text = "Numero de chofer";
            labelNumeroChofer.Click += label1_Click;
            // 
            // txtNumeroChofer
            // 
            txtNumeroChofer.Location = new Point(34, 47);
            txtNumeroChofer.MaxLength = 2;
            txtNumeroChofer.Name = "txtNumeroChofer";
            txtNumeroChofer.PlaceholderText = "Ej. 10";
            txtNumeroChofer.Size = new Size(212, 27);
            txtNumeroChofer.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(34, 93);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(135, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre del chofer";
            // 
            // txtNombreChofer
            // 
            txtNombreChofer.Location = new Point(34, 116);
            txtNombreChofer.MaxLength = 50;
            txtNombreChofer.Name = "txtNombreChofer";
            txtNombreChofer.PlaceholderText = "Ej. Jose Hernan Hernadez";
            txtNombreChofer.Size = new Size(212, 27);
            txtNombreChofer.TabIndex = 3;
            // 
            // labelFechaIngreso
            // 
            labelFechaIngreso.AutoSize = true;
            labelFechaIngreso.Location = new Point(34, 162);
            labelFechaIngreso.Name = "labelFechaIngreso";
            labelFechaIngreso.Size = new Size(121, 20);
            labelFechaIngreso.TabIndex = 4;
            labelFechaIngreso.Text = "Fecha de ingreso";
            // 
            // dateTimeFechaIngreso
            // 
            dateTimeFechaIngreso.Location = new Point(34, 185);
            dateTimeFechaIngreso.Name = "dateTimeFechaIngreso";
            dateTimeFechaIngreso.Size = new Size(301, 27);
            dateTimeFechaIngreso.TabIndex = 5;
            // 
            // labelSueldo
            // 
            labelSueldo.AutoSize = true;
            labelSueldo.Location = new Point(34, 233);
            labelSueldo.Name = "labelSueldo";
            labelSueldo.Size = new Size(55, 20);
            labelSueldo.TabIndex = 6;
            labelSueldo.Text = "Sueldo";
            labelSueldo.Click += label1_Click_1;
            // 
            // labelSignoPesos
            // 
            labelSignoPesos.AutoSize = true;
            labelSignoPesos.Location = new Point(34, 253);
            labelSignoPesos.Name = "labelSignoPesos";
            labelSignoPesos.Size = new Size(17, 20);
            labelSignoPesos.TabIndex = 7;
            labelSignoPesos.Text = "$";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(57, 250);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.PlaceholderText = "Ej. 10000.00";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(316, 321);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 9;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // FormAgregarEditarChofer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuardar);
            Controls.Add(txtSueldo);
            Controls.Add(labelSignoPesos);
            Controls.Add(labelSueldo);
            Controls.Add(dateTimeFechaIngreso);
            Controls.Add(labelFechaIngreso);
            Controls.Add(txtNombreChofer);
            Controls.Add(labelNombre);
            Controls.Add(txtNumeroChofer);
            Controls.Add(labelNumeroChofer);
            Name = "FormAgregarEditarChofer";
            Text = "Agregar chofer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumeroChofer;
        private TextBox txtNumeroChofer;
        private Label labelNombre;
        private TextBox txtNombreChofer;
        private Label labelFechaIngreso;
        private DateTimePicker dateTimeFechaIngreso;
        private Label labelSueldo;
        private Label labelSignoPesos;
        private TextBox txtSueldo;
        private Button buttonGuardar;
    }
}