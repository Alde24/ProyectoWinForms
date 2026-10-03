using ControlVehiculos.Data;
using ControlVehiculos.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace ControlVehiculos.Repositories
{
    public class VehiculoRepositorio
    {
        // Agregar vehiculo
        public bool Agregar(string placas, int modelo, string marca, DateOnly fechaCompra, decimal costo, int numChofer, decimal km)
        {
            string query = "INSERT INTO Vehiculos (placas, modelo, marca, fechaCompra, costoCompra, numChofer, kmActual) VALUES (@placas, @modelo, @marca, @fecha, @costo, @chofer, @km)";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@placas", placas);
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@fecha", fechaCompra.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@costo", costo);
                        comando.Parameters.AddWithValue("@chofer", numChofer);
                        comando.Parameters.AddWithValue("@km", km);

                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vehículo: " + ex.Message);
            }
        }

        // Actualizar vehiculo
        public bool Actualizar(string placasOriginal, int modelo, string marca, DateOnly fechaCompra, decimal costo, int numChofer, decimal km)
        {
            string query = "UPDATE Vehiculos SET modelo = @modelo, marca = @marca, fechaCompra = @fecha, costoCompra = @costo, numChofer = @chofer, kmActual = @km WHERE placas = @placas";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@placas", placasOriginal);
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@fecha", fechaCompra.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@costo", costo);
                        comando.Parameters.AddWithValue("@chofer", numChofer);
                        comando.Parameters.AddWithValue("@km", km);

                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar vehículo: " + ex.Message);
            }
        }

        // Eliminar vehiculo
        public bool Eliminar(string placas)
        {
            string query = "DELETE FROM Vehiculos WHERE placas = @placas";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@placas", placas);
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar vehículo: " + ex.Message);
            }
        }

        //Obtener todos los vehiculos
        public List<Vehiculo> obtenerTodos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            string query = "SELECT * FROM Vehiculos";
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string placas = reader.GetString("placas");
                                int modelo = reader.GetInt32("modelo");
                                string marca = reader.GetString("marca");
                                DateOnly fechaCompra = DateOnly.Parse(reader.GetDateTime("fechaCompra").ToString("yyyy-MM-dd"));
                                decimal costo = reader.GetDecimal("costoCompra");
                                int numChofer = reader.GetInt32("numChofer");
                                decimal kmActual = reader.GetDecimal("kmActual");
                                vehiculos.Add(new Vehiculo(placas, modelo, marca, fechaCompra, costo, numChofer, kmActual));
                            }
                        }
                    }
                }
                return vehiculos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículos: " + ex.Message);
            }


        }
        //Obtener un vehiculo por sus placas
        public Vehiculo obtenerPorPlacas(string placas)
        {
            string query = "SELECT * FROM Vehiculos WHERE placas = @placas";
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@placas", placas);
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int modelo = reader.GetInt32("modelo");
                                string marca = reader.GetString("marca");
                                DateOnly fechaCompra = DateOnly.Parse(reader.GetDateTime("fechaCompra").ToString("yyyy-MM-dd"));
                                decimal costo = reader.GetDecimal("costoCompra");
                                int numChofer = reader.GetInt32("numChofer");
                                decimal kmActual = reader.GetDecimal("kmActual");
                                return new Vehiculo(placas, modelo, marca, fechaCompra, costo, numChofer, kmActual);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículo: " + ex.Message);
            }
        }

        //Obtener los vehiculos y sus choferes
        public DataTable obtenerReporteConChoferes()
        {
            // Consulta SQL que une vehículos con choferes 
            string query = @"
                            SELECT v.Placas, v.Modelo, v.Marca, v.FechaCompra, v.CostoCompra, 
                                   v.KmActual AS Kilometraje, 
                                   IFNULL(CONCAT(c.NumChofer, ' - ', c.Nombre), 'Sin Asignar') AS ChoferAsignado
                            FROM Vehiculos v 
                            LEFT JOIN Choferes c ON v.NumChofer = c.NumChofer";

            DataTable dt = new DataTable();
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var adaptador = new MySqlDataAdapter(query, conexion))
                {
                    adaptador.Fill(dt);
                }
            }
            return dt;
        }

        public bool choferConVehiculos(int numChofer)
        {
            string query = "SELECT COUNT(*) FROM Vehiculos WHERE numChofer = @numChofer";
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@numChofer", numChofer);
                    long count = (long)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
