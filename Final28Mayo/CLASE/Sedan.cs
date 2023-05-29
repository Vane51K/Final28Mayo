using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASE
{
    class Sedan : VehiculoBase
    {
        public bool Estado { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int Anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }

        public int VelocidadMaxima { get; set; }

        public int VelocidadACtual { get; set; }

        //Propiedades nuevas

        public string Polarizado { get; set; }
        public string PortaVasos { get; set; }
        public string Ventanas { get; set; }
        public void acelerar(int cuando)
        {
            Console.WriteLine($"Acelerando un {cuando}%mas");
        }

        public void apagar()
        {
            Console.WriteLine("Su carro se ha apagado");
        }

        public void bocina()
        {
            Console.WriteLine("Beep");
            Console.Beep();
        }

        public void encender()
        {
            Console.WriteLine("Su carro se ha encendido");
        }

        public void frenar(int cuando)
        {
            Console.WriteLine($"Su carro ha frenado un {cuando}%");
        }
        //metodo nuevo
        public void volar()
        {
            Console.WriteLine("Su carro esta volando :O");
        }

    }
}
