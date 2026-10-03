namespace ControlVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlVehiculos = new TabControl();
            tabPageVehiculos = new TabPage();
            buttonReporte = new Button();
            tableVehiculos = new DataGridView();
            colPlacas = new DataGridViewTextBoxColumn();
            colNumChofere = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colFechaCompra = new DataGridViewTextBoxColumn();
            colCostoCompra = new DataGridViewTextBoxColumn();
            colKmActual = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colEliminar = new DataGridViewButtonColumn();
            buttonAgregarVehiculo = new Button();
            buttonBuscarPlaca = new Button();
            txtBuscarPlaca = new TextBox();
            tabPageChoferes = new TabPage();
            buttonAgregarChofer = new Button();
            tableChoferes = new DataGridView();
            colNumChofer = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            colSueldo = new DataGridViewTextBoxColumn();
            colEditarChofer = new DataGridViewButtonColumn();
            colEliminarChofer = new DataGridViewButtonColumn();
            tabControlVehiculos.SuspendLayout();
            tabPageVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableVehiculos).BeginInit();
            tabPageChoferes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableChoferes).BeginInit();
            SuspendLayout();
            // 
            // tabControlVehiculos
            // 
            tabControlVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlVehiculos.Appearance = TabAppearance.Buttons;
            tabControlVehiculos.Controls.Add(tabPageVehiculos);
            tabControlVehiculos.Controls.Add(tabPageChoferes);
            tabControlVehiculos.Location = new Point(12, 12);
            tabControlVehiculos.Name = "tabControlVehiculos";
            tabControlVehiculos.SelectedIndex = 0;
            tabControlVehiculos.Size = new Size(776, 426);
            tabControlVehiculos.TabIndex = 0;
            tabControlVehiculos.Tag = "Vehiculos";
            // 
            // tabPageVehiculos
            // 
            tabPageVehiculos.Controls.Add(buttonReporte);
            tabPageVehiculos.Controls.Add(tableVehiculos);
            tabPageVehiculos.Controls.Add(buttonAgregarVehiculo);
            tabPageVehiculos.Controls.Add(buttonBuscarPlaca);
            tabPageVehiculos.Controls.Add(txtBuscarPlaca);
            tabPageVehiculos.Location = new Point(4, 32);
            tabPageVehiculos.Name = "tabPageVehiculos";
            tabPageVehiculos.Padding = new Padding(3);
            tabPageVehiculos.Size = new Size(768, 390);
            tabPageVehiculos.TabIndex = 0;
            tabPageVehiculos.Text = "Vehiculos";
            tabPageVehiculos.UseVisualStyleBackColor = true;
            tabPageVehiculos.Click += tabPage1_Click;
            // 
            // buttonReporte
            // 
            buttonReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReporte.Location = new Point(601, 19);
            buttonReporte.Name = "buttonReporte";
            buttonReporte.Size = new Size(146, 29);
            buttonReporte.TabIndex = 4;
            buttonReporte.Text = "Generar reporte";
            buttonReporte.UseVisualStyleBackColor = true;
            buttonReporte.Click += buttonReporte_Click;
            // 
            // tableVehiculos
            // 
            tableVehiculos.AllowUserToAddRows = false;
            tableVehiculos.AllowUserToDeleteRows = false;
            tableVehiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableVehiculos.Columns.AddRange(new DataGridViewColumn[] { colPlacas, colNumChofere, colModelo, colMarca, colFechaCompra, colCostoCompra, colKmActual, colEditar, colEliminar });
            tableVehiculos.Location = new Point(24, 54);
            tableVehiculos.Name = "tableVehiculos";
            tableVehiculos.ReadOnly = true;
            tableVehiculos.RowHeadersWidth = 51;
            tableVehiculos.Size = new Size(723, 295);
            tableVehiculos.TabIndex = 3;
            tableVehiculos.CellContentClick += tableVehiculos_CellContentClick;
            // 
            // colPlacas
            // 
            colPlacas.DataPropertyName = "placa";
            colPlacas.HeaderText = "Placas";
            colPlacas.MaxInputLength = 7;
            colPlacas.MinimumWidth = 6;
            colPlacas.Name = "colPlacas";
            colPlacas.ReadOnly = true;
            // 
            // colNumChofere
            // 
            colNumChofere.DataPropertyName = "numChofer";
            colNumChofere.HeaderText = "No. de chofer";
            colNumChofere.MaxInputLength = 2;
            colNumChofere.MinimumWidth = 6;
            colNumChofere.Name = "colNumChofere";
            colNumChofere.ReadOnly = true;
            // 
            // colModelo
            // 
            colModelo.DataPropertyName = "modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.MaxInputLength = 4;
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.DataPropertyName = "marca";
            colMarca.HeaderText = "Marca";
            colMarca.MaxInputLength = 25;
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            // 
            // colFechaCompra
            // 
            colFechaCompra.DataPropertyName = "fechaCompra";
            colFechaCompra.HeaderText = "Fecha de Compra";
            colFechaCompra.MinimumWidth = 6;
            colFechaCompra.Name = "colFechaCompra";
            colFechaCompra.ReadOnly = true;
            // 
            // colCostoCompra
            // 
            colCostoCompra.DataPropertyName = "costo";
            colCostoCompra.HeaderText = "Costo de Compra";
            colCostoCompra.MinimumWidth = 6;
            colCostoCompra.Name = "colCostoCompra";
            colCostoCompra.ReadOnly = true;
            // 
            // colKmActual
            // 
            colKmActual.DataPropertyName = "kilometraje";
            colKmActual.HeaderText = "Kilometraje actual";
            colKmActual.MaxInputLength = 10;
            colKmActual.MinimumWidth = 6;
            colKmActual.Name = "colKmActual";
            colKmActual.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.HeaderText = "Editar";
            colEditar.MinimumWidth = 6;
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            // 
            // buttonAgregarVehiculo
            // 
            buttonAgregarVehiculo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAgregarVehiculo.Location = new Point(24, 355);
            buttonAgregarVehiculo.Name = "buttonAgregarVehiculo";
            buttonAgregarVehiculo.Size = new Size(144, 29);
            buttonAgregarVehiculo.TabIndex = 2;
            buttonAgregarVehiculo.Text = "Agregar vehiculo";
            buttonAgregarVehiculo.UseVisualStyleBackColor = true;
            buttonAgregarVehiculo.Click += buttonAgregarVehiculo_Click;
            // 
            // buttonBuscarPlaca
            // 
            buttonBuscarPlaca.Location = new Point(342, 21);
            buttonBuscarPlaca.Name = "buttonBuscarPlaca";
            buttonBuscarPlaca.Size = new Size(60, 27);
            buttonBuscarPlaca.TabIndex = 1;
            buttonBuscarPlaca.TabStop = false;
            buttonBuscarPlaca.Text = "Buscar";
            buttonBuscarPlaca.UseMnemonic = false;
            buttonBuscarPlaca.UseVisualStyleBackColor = true;
            buttonBuscarPlaca.Click += buttonBuscarPlaca_Click;
            // 
            // txtBuscarPlaca
            // 
            txtBuscarPlaca.Location = new Point(24, 21);
            txtBuscarPlaca.MaxLength = 7;
            txtBuscarPlaca.Name = "txtBuscarPlaca";
            txtBuscarPlaca.PlaceholderText = "Ingresa la placa a buscar";
            txtBuscarPlaca.Size = new Size(297, 27);
            txtBuscarPlaca.TabIndex = 0;
            txtBuscarPlaca.TextChanged += textBox1_TextChanged;
            // 
            // tabPageChoferes
            // 
            tabPageChoferes.Controls.Add(buttonAgregarChofer);
            tabPageChoferes.Controls.Add(tableChoferes);
            tabPageChoferes.Location = new Point(4, 32);
            tabPageChoferes.Name = "tabPageChoferes";
            tabPageChoferes.Padding = new Padding(3);
            tabPageChoferes.Size = new Size(768, 390);
            tabPageChoferes.TabIndex = 1;
            tabPageChoferes.Text = "Choferes";
            tabPageChoferes.UseVisualStyleBackColor = true;
            tabPageChoferes.Click += tabPageChoferes_Click;
            // 
            // buttonAgregarChofer
            // 
            buttonAgregarChofer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAgregarChofer.Location = new Point(31, 334);
            buttonAgregarChofer.Name = "buttonAgregarChofer";
            buttonAgregarChofer.Size = new Size(122, 29);
            buttonAgregarChofer.TabIndex = 1;
            buttonAgregarChofer.Text = "Agregar chofer";
            buttonAgregarChofer.UseVisualStyleBackColor = true;
            buttonAgregarChofer.Click += buttonAgregarChofer_Click;
            // 
            // tableChoferes
            // 
            tableChoferes.AllowUserToAddRows = false;
            tableChoferes.AllowUserToDeleteRows = false;
            tableChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableChoferes.Columns.AddRange(new DataGridViewColumn[] { colNumChofer, colNombre, colFechaIngreso, colSueldo, colEditarChofer, colEliminarChofer });
            tableChoferes.Location = new Point(31, 54);
            tableChoferes.Name = "tableChoferes";
            tableChoferes.ReadOnly = true;
            tableChoferes.RowHeadersWidth = 51;
            tableChoferes.Size = new Size(718, 274);
            tableChoferes.TabIndex = 0;
            tableChoferes.CellContentClick += tableChoferes_CellContentClick;
            // 
            // colNumChofer
            // 
            colNumChofer.DataPropertyName = "numChofer";
            colNumChofer.HeaderText = "No. de chofer";
            colNumChofer.MaxInputLength = 2;
            colNumChofer.MinimumWidth = 6;
            colNumChofer.Name = "colNumChofer";
            colNumChofer.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "nombre";
            colNombre.HeaderText = "Nombre del chofer";
            colNombre.MaxInputLength = 50;
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.DataPropertyName = "fechaIngreso";
            colFechaIngreso.HeaderText = "Fecha de Ingreso";
            colFechaIngreso.MinimumWidth = 6;
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.ReadOnly = true;
            // 
            // colSueldo
            // 
            colSueldo.DataPropertyName = "sueldo";
            colSueldo.HeaderText = "Sueldo";
            colSueldo.MinimumWidth = 6;
            colSueldo.Name = "colSueldo";
            colSueldo.ReadOnly = true;
            // 
            // colEditarChofer
            // 
            colEditarChofer.HeaderText = "Editar";
            colEditarChofer.MinimumWidth = 6;
            colEditarChofer.Name = "colEditarChofer";
            colEditarChofer.ReadOnly = true;
            colEditarChofer.Text = "Editar";
            colEditarChofer.UseColumnTextForButtonValue = true;
            // 
            // colEliminarChofer
            // 
            colEliminarChofer.HeaderText = "Eliminar";
            colEliminarChofer.MinimumWidth = 6;
            colEliminarChofer.Name = "colEliminarChofer";
            colEliminarChofer.ReadOnly = true;
            colEliminarChofer.Text = "Eliminar";
            colEliminarChofer.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlVehiculos);
            Name = "Form1";
            Text = "Control de vehiculos";
            Load += Form1_Load;
            tabControlVehiculos.ResumeLayout(false);
            tabPageVehiculos.ResumeLayout(false);
            tabPageVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableVehiculos).EndInit();
            tabPageChoferes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableChoferes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlVehiculos;
        private TabPage tabPageVehiculos;
        private TabPage tabPageChoferes;
        private TextBox txtBuscarPlaca;
        private Button buttonBuscarPlaca;
        private Button buttonAgregarVehiculo;
        private DataGridView tableVehiculos;
        private Button buttonAgregarChofer;
        private DataGridView tableChoferes;
        private DataGridViewTextBoxColumn colPlacas;
        private DataGridViewTextBoxColumn colNumChofere;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colFechaCompra;
        private DataGridViewTextBoxColumn colCostoCompra;
        private DataGridViewTextBoxColumn colKmActual;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colEliminar;
        private DataGridViewTextBoxColumn colNumChofer;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colSueldo;
        private DataGridViewButtonColumn colEditarChofer;
        private DataGridViewButtonColumn colEliminarChofer;
        private Button buttonReporte;
    }
}
