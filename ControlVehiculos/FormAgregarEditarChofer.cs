using ControlVehiculos.Models;
using ControlVehiculos.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlVehiculos
{
    public partial class FormAgregarEditarChofer : Form
    {
        private bool esEdicion = false;
        private int numChoferOriginal = 0;
        private ChoferRepositorio choferRepo = new ChoferRepositorio();
        // Constructor para AGREGAR un nuevo chofer
        public FormAgregarEditarChofer()
        {
            InitializeComponent();
            esEdicion = false;
            this.Text = "Agregar chofer";
            buttonGuardar.Text = "Guardar";
        }

        // Constructor para EDITAR un chofer existente (recibe el número de chofer)
        public FormAgregarEditarChofer(int numChofer)
        {
            InitializeComponent();
            esEdicion = true;
            numChoferOriginal = numChofer;
            this.Text = "Editar chofer";
            buttonGuardar.Text = "Actualizar";

            // Cargamos los datos actuales en los controles
            cargarDatos(numChofer);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

         private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        private void cargarDatos(int numChofer)
        {
            try
            {
                // Buscamos el chofer por su numero
                Chofer chofer = choferRepo.obtenerPorNumero(numChofer);

                if (chofer != null)
                {
                    txtNumeroChofer.Text = chofer.numChofer.ToString();
                    txtNombreChofer.Text = chofer.nombre;
                    dateTimeFechaIngreso.Value = chofer.fechaIngreso.ToDateTime(new TimeOnly(0, 0));
                    txtSueldo.Text = chofer.sueldo.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del  chofer  para editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificar campos vacios y validar datos
                if (!int.TryParse(txtNumeroChofer.Text, out int numChofer))
                {
                    MessageBox.Show("El número de chofer debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroChofer.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreChofer.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre completo del chofer.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreChofer.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo))
                {
                    MessageBox.Show("Por favor, ingrese un sueldo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSueldo.Focus();
                    return;
                }

                // extraemos la fecha del DateTimePicker
                DateOnly fechaIngreso = DateOnly.FromDateTime(dateTimeFechaIngreso.Value);

                bool resultado = false;

                if (esEdicion)
                {
                    //Metodo de actualizar (UPDATE)
                    resultado = choferRepo.Actualizar(
                        numChoferOriginal, 
                        txtNombreChofer.Text.Trim(), 
                        fechaIngreso, 
                        sueldo
                        );
                }
                else
                {

                    //Metodo de insertar (INSERT)
                    resultado = choferRepo.Agregar(
                        numChofer,
                        txtNombreChofer.Text.Trim(),
                        fechaIngreso,
                        sueldo
                        );

                }

                if (resultado)
                {
                    string mensaje = esEdicion ? "Chofer actualizado exitosamente." : "Chofer registrado exitosamente.";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar formulario y regresar a la tabla
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //Verificamos si es un error de clave primaria duplicada
                if (ex.Message.Contains("duplicate key") || ex.Message.Contains("UNIQUE constraint failed") || ex.Message.Contains("PRIMARY KEY constraint failed") || ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("Ya existe un chofer con el mismo número. Por favor, ingrese un número diferente.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el chofer: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
