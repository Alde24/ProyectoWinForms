using System;
using System.Collections.Generic;
using System.Text;

namespace ControlVehiculos.Models
{
    public class Vehiculo
    {
        public string placa { get; set; }
        public int modelo { get; set; }
        public string marca { get; set; }
        public DateOnly fechaCompra { get; set; }
        public decimal costo { get; set; }
        public int numChofer { get; set; }
        public decimal kilometraje { get; set; }

        public Vehiculo(string placa, int modelo, string marca, DateOnly fechaCompra, decimal costo, int numChofer, decimal kilometraje)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.marca = marca;
            this.fechaCompra = fechaCompra;
            this.costo = costo;
            this.numChofer = numChofer;
            this.kilometraje = kilometraje;
        }
    }
}
