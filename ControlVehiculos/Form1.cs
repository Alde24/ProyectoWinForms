using ControlVehiculos.Models;
using ControlVehiculos.Repositories;
using System;
using System.Windows.Forms;
namespace ControlVehiculos
{
    public partial class Form1 : Form
    {
        private VehiculoRepositorio vehiculoRepo = new VehiculoRepositorio();
        private ChoferRepositorio choferRepo = new ChoferRepositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Refrescar la tabla al cargar el formulario
            RefrescarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtenemos el objeto Vehiculo de la fila seleccionada actual
            Vehiculo vehiculoSeleccionado = tableVehiculos.Rows[e.RowIndex].DataBoundItem as Vehiculo;
            if (vehiculoSeleccionado == null) return;

            string nombreColumna = tableVehiculos.Columns[e.ColumnIndex].Name;

            // ELIMINAR VEHICULO
            if (nombreColumna.Contains("Eliminar") || nombreColumna == "colBtnEliminarVehiculo")
            {
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el vehículo con placas '{vehiculoSeleccionado.placa}'?",
                                                             "Confirmación de Baja",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Asegúrate de tener tu método Eliminar en el repositorio de vehículos
                        vehiculoRepo.Eliminar(vehiculoSeleccionado.placa);
                        MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // EDITAR VEHICULO
            else if (nombreColumna.Contains("Editar") || nombreColumna == "colBtnEditarVehiculo")
            {
                // mandamos la placa al formulario en modo edición
                FormAgregarEditarVehiculo formEditar = new FormAgregarEditarVehiculo(vehiculoSeleccionado.placa);
                formEditar.ShowDialog();
                RefrescarTabla();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void RefrescarTabla()
        {
            try
            {
                tableVehiculos.AutoGenerateColumns = false;
                tableChoferes.AutoGenerateColumns = false;
                tableVehiculos.DataSource = vehiculoRepo.obtenerTodos();
                tableChoferes.DataSource = choferRepo.obtenerTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // boton para abrir el formulario de Agregar Vehículo
        private void buttonAgregarVehiculo_Click(object sender, EventArgs e)
        {
            FormAgregarEditarVehiculo formVehiculo = new FormAgregarEditarVehiculo();
            formVehiculo.ShowDialog();
            RefrescarTabla(); // Actualiza la tabla al cerrar la ventana
        }

        // boton para abrir el formulario de Agregar Chofer
        private void buttonAgregarChofer_Click(object sender, EventArgs e)
        {
            FormAgregarEditarChofer formChofer = new FormAgregarEditarChofer();
            formChofer.ShowDialog();
            RefrescarTabla(); // Actualiza la tabla al cerrar la ventana
        }

        private void buttonBuscarPlaca_Click(object sender, EventArgs e)
        {
            string placaBuscada = txtBuscarPlaca.Text.Trim();

            if (string.IsNullOrEmpty(placaBuscada))
            {
                RefrescarTabla();
                return;
            }

            try
            {
                Vehiculo v = vehiculoRepo.obtenerPorPlacas(placaBuscada);
                List<Vehiculo> resultado = new List<Vehiculo>();

                if (v != null)
                {
                    resultado.Add(v);
                }

                // El DataGridView acepta listas para mostrar el resultado único o vacío
                tableVehiculos.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tableChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtenemos el objeto Chofer de la fila seleccionada actual
            Chofer choferSeleccionado = tableChoferes.Rows[e.RowIndex].DataBoundItem as Chofer;
            if (choferSeleccionado == null) return;

            string nombreColumna = tableChoferes.Columns[e.ColumnIndex].Name;

            // ELIMINAR CHOFER
            if (nombreColumna.Contains("Eliminar") || nombreColumna == "colBtnEliminarChofer")
            {
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el chofer '{choferSeleccionado.nombre}'?",
                                                             "Confirmación de Baja",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Asegúrate de tener tu método Eliminar en el repositorio de choferes
                        choferRepo.Eliminar(choferSeleccionado.numChofer);
                        MessageBox.Show("Chofer eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // EDITAR CHOFER
            else if (nombreColumna.Contains("Editar") || nombreColumna == "colBtnEditarChofer")
            {
                // mandamos el número de chofer al formulario en modo edición
                /*FormAgregarEditarChofer formEditar = new FormAgregarEditarChofer(choferSeleccionado.numChofer);
                formEditar.ShowDialog();
                RefrescarTabla();*/

            }
        }
    }
}
