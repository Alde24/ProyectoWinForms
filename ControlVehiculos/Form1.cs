using ControlVehiculos.Models;
using ControlVehiculos.Repositories;
using System;
using System.Data;
using System.Text;
using ClosedXML.Excel;
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

                //Validar que el chofer no tiene vehiculos asignados
                if (vehiculoRepo.choferConVehiculos(choferSeleccionado.numChofer))
                {
                    MessageBox.Show("No se puede eliminar el chofer '" + choferSeleccionado.nombre + "' porque actualmente tiene vehículos asignados.\n\n" +
                                    "Debe editar los vehículos correspondientes para cambiar o desasignar el chofer antes de poder eliminarlo.",
                                    "Restricción de integridad",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Detenemos el proceso de eliminación
                }
                DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar el chofer '{choferSeleccionado.nombre}'?",
                                                             "Confirmación de Baja",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Eliminar chofer usando el repositorio de choferes
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
                FormAgregarEditarChofer formEditar = new FormAgregarEditarChofer(choferSeleccionado.numChofer);
                formEditar.ShowDialog();
                RefrescarTabla();

            }
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos los datos del reporte
                DataTable dtReporte = vehiculoRepo.obtenerReporteConChoferes();

                if (dtReporte.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros de vehículos para generar el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Se elige donde guarda el archivo
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
                saveDialog.Title = "Guardar Reporte de Vehículos y Choferes";
                saveDialog.FileName = "ReporteVehiculosChoferes_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear el libro de excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Añadimos una hoja con nombre
                        var worksheet = workbook.Worksheets.Add("Vehículos y Choferes");

                        // Insertamos el DataTable completo
                        worksheet.Cell(1, 1).InsertTable(dtReporte);

                        // Ajustar el ancho de las columnas
                        worksheet.Columns().AdjustToContents();


                        //Guardamos el archivo en la ruta seleccionada
                        workbook.SaveAs(saveDialog.FileName);
                    }

                    MessageBox.Show("Reporte generado correctamente", "Reporte Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageChoferes_Click(object sender, EventArgs e)
        {

        }
    }
}
