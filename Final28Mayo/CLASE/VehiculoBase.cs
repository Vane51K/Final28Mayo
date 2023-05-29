using ProyectoFinal.INTERFAZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASE
{
    internal class VehiculoBase : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; set; }
        public int VelocidadActual { get; set; }

        public void Acelerar(int cuando)
        {
            Console.WriteLine($"Acelerando un {cuando}% mas");
        }

        public void Apagar()
        {
            Console.WriteLine("Su carro se ha apagado");
        }

        public void Bocina()
        {
            Console.WriteLine("¡BEEP BEEEEEEEEEEEEP!");
            Console.Beep();
        }

        public void Encende()
        {
            Console.WriteLine("Su carro ha encendidio");
        }

        public void Frenar(int cuando)
        {
            Console.WriteLine($"Su carro ha frenado un {cuando}% ");
        }
    }
}
