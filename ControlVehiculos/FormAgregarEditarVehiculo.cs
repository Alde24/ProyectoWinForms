using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControlVehiculos.Models;
using ControlVehiculos.Repositories;

namespace ControlVehiculos
{
    public partial class FormAgregarEditarVehiculo : Form
    {
        private VehiculoRepositorio vehiculoRepo = new VehiculoRepositorio();
        private bool esEdicion = false;
        private string placaOriginal = "";

        // Constructor para AGREGAR un nuevo vehículo
        public FormAgregarEditarVehiculo()
        {
            InitializeComponent();
            esEdicion = false;
            this.Text = "Agregar vehículo";
            buttonGuardar.Text = "Guardar";
        }

        // Constructor para EDITAR un vehículo existente (recibe la placa)
        public FormAgregarEditarVehiculo(string placas)
        {
            InitializeComponent();
            esEdicion = true;
            placaOriginal = placas;
            this.Text = "Editar vehículo";
            buttonGuardar.Text = "Actualizar";

            // Cargamos los datos actuales en los controles
            cargarDatos(placas);
        }

        private void cargarDatos(string placas)
        {
            try
            {
                // Buscamos el auto por las placas
                Vehiculo vehiculo = vehiculoRepo.obtenerPorPlacas(placas);

                if (vehiculo != null)
                {
                    txtPlaca.Text = vehiculo.placa;
                    txtPlaca.Enabled = false; // Bloqueamos la placa para no alterar la llave primaria
                    txtNoChofer.Text = vehiculo.numChofer.ToString();
                    txtModelo.Text = vehiculo.modelo.ToString();
                    txtMarca.Text = vehiculo.marca;

                    // Convertimos DateOnly a DateTime para el DateTimePicker
                    dateTimeFechaCompra.Value = vehiculo.fechaCompra.ToDateTime(TimeOnly.MinValue);

                    txtCosto.Text = vehiculo.costo.ToString();
                    txtKilometraje.Text = vehiculo.kilometraje.ToString();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del vehículo para editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar campos vacíos y validar datos
                if (string.IsNullOrWhiteSpace(txtPlaca.Text))
                {
                    MessageBox.Show("Por favor, ingrese la placa del vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    return;
                }

                if (!int.TryParse(txtNoChofer.Text, out int numChofer))
                {
                    MessageBox.Show("El número de chofer debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoChofer.Focus();
                    return;
                }

                if (!int.TryParse(txtModelo.Text, out int modelo))
                {
                    MessageBox.Show("El modelo debe ser un año numérico válido (ej. 2023).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModelo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show("Por favor, ingrese la marca del vehículo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarca.Focus();
                    return;
                }

                if (!decimal.TryParse(txtCosto.Text, out decimal costo))
                {
                    MessageBox.Show("Por favor, ingrese un costo de compra válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCosto.Focus();
                    return;
                }

                if (!decimal.TryParse(txtKilometraje.Text, out decimal km))
                {
                    MessageBox.Show("Por favor, ingrese un kilometraje actual válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKilometraje.Focus();
                    return;
                }

                // Obtener fecha del DateTimePicker
                DateOnly fechaCompra = DateOnly.FromDateTime(dateTimeFechaCompra.Value);

                bool resultado = false;

                if (esEdicion)
                {
                    //Metodo de actualizar (UPDATE)
                    resultado = vehiculoRepo.Actualizar(
                        placaOriginal,
                        modelo,
                        txtMarca.Text.Trim(),
                        fechaCompra,
                        costo,
                        numChofer,
                        km
                    );
                }
                else
                {
                    // Metodo de agregar (INSERT)
                    resultado = vehiculoRepo.Agregar(
                        txtPlaca.Text.Trim(),
                        modelo,
                        txtMarca.Text.Trim(),
                        fechaCompra,
                        costo,
                        numChofer,
                        km
                    );
                }

                if (resultado)
                {
                    string mensaje = esEdicion ? "Vehículo actualizado exitosamente." : "Vehículo registrado exitosamente.";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar formulario y regresar a la tabla
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //Verificamos si es un error de clave primaria duplicada
                if(ex.Message.Contains("duplicate key") || ex.Message.Contains("UNIQUE constraint failed") || ex.Message.Contains("PRIMARY KEY constraint failed") || ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("Ya existe un vehículo con la misma placa. Por favor, ingrese una placa diferente.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el vehículo: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        // Handlers auxiliares para el diseñador
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_3(object sender, EventArgs e) { }
        private void label1_Click_4(object sender, EventArgs e) { }
        private void label1_Click_5(object sender, EventArgs e) { }
    }
}