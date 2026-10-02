using ControlVehiculos.Data;
using ControlVehiculos.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ControlVehiculos.Repositories
{
    public class ChoferRepositorio
    {
        // agregar chofer
        public bool Agregar(int numChofer, string nombre, DateOnly fechaIngreso, decimal sueldo)
        {
            string query = "INSERT INTO Choferes (numChofer, nombre, fechaIngreso, sueldo) VALUES (@numero, @nombre, @fecha, @sueldo)";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@numero", numChofer);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@fecha", fechaIngreso.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@sueldo", sueldo);

                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar chofer: " + ex.Message);
            }
        }

        //editar chofer
        public bool Actualizar(int numChoferOriginal, string nombre, DateOnly fechaIngreso, decimal sueldo)
        {
            string query = "UPDATE Choferes SET nombre = @nombre, fechaIngreso = @fecha, sueldo = @sueldo WHERE numChofer = @numero";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@numero", numChoferOriginal);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@fecha", fechaIngreso.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@sueldo", sueldo);

                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar chofer: " + ex.Message);
            }
        }

        // eliminar chofer
        public bool Eliminar(int numChofer)
        {
            string query = "DELETE FROM Choferes WHERE numChofer = @numero";

            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@numero", numChofer);
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar chofer: " + ex.Message);
            }
        }

        // obtener todos los choferes
        public List<Chofer> obtenerTodos()
        {
            List<Chofer> choferes = new List<Chofer>();
            string query = "SELECT * FROM Choferes";
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
                                int numChofer = reader.GetInt32("numChofer");
                                string nombre = reader.GetString("nombre");
                                DateOnly fechaIngreso = DateOnly.Parse(reader.GetDateTime("fechaIngreso").ToString("yyyy-MM-dd"));
                                decimal sueldo = reader.GetDecimal("sueldo");
                                choferes.Add(new Chofer(numChofer, nombre, fechaIngreso, sueldo));
                            }
                        }
                    }
                }
                return choferes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener choferes: " + ex.Message);
            }
        }

        //Obtener un chofer por su numero
        public Chofer obtenerPorNumero(int numChofer)
        {
            string query = "SELECT * FROM Choferes WHERE numChofer = @numero";
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@numero", numChofer);
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader.GetString("nombre");
                                DateOnly fechaIngreso = DateOnly.Parse(reader.GetDateTime("fechaIngreso").ToString("yyyy-MM-dd"));
                                decimal sueldo = reader.GetDecimal("sueldo");
                                return new Chofer(numChofer, nombre, fechaIngreso, sueldo);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener chofer: " + ex.Message);
            }
        }
    }
}
