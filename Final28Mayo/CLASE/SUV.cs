using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASE
{
    class SUV : VehiculoBase
    {
        public bool Estado { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int Anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }

        public int VelocidadMaxima { get; set; }

        public int VelocidadActual { get; set; }

        //Propiedades nuevas

        public string parabrisas { get; set; }
        public string vinilos { get; set; }
        public string altavoces { get; set; }


        public void acelerar(int cuanto)
        {
            Console.WriteLine($"Acelerando un {cuanto}%mas");
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

        public void frenar(int cuanto)
        {
            Console.WriteLine($"Su carro ha frenado un {cuanto}%");
        }

        public void SistemaantiR()
        {
            Console.WriteLine("Estamos protegidos contra tanto malechor");
        }


    }
}