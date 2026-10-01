using System;
using System.Collections.Generic;
using System.Text;

namespace ControlVehiculos.Models
{
    public class Chofer
    {
        public int numChofer {get;set;}
        public string nombre { get; set; }
        public DateOnly fechaIngreso { get; set; }
        public decimal sueldo { get; set; }

        public Chofer(int numChofer, string nombre, DateOnly fechaIngreso, decimal sueldo)
        {
            this.numChofer = numChofer;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.sueldo = sueldo;
        }
        
    }
}
