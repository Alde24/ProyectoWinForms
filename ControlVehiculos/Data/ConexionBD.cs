using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ControlVehiculos.Data
{
    public static class ConexionBD
    {
        // CambiaR los valores para la configuracion de MySQL
        private static string cadenaConexion = "Server=localhost;Database=ControlVehiculosDB;Uid=root;Pwd=123456789;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
