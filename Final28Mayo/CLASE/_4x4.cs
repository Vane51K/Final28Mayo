using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASE
{
    class _4x4
    {
        public bool Estado { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int Anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }

        public int VelocidadMaxima { get; }

        public int VelocidadActual { get; }

        //Propiedades agregadas

        public string suspension { get; set; }

        public string amortiguadores { get; set; }

        public string defensa { get; set; }



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
        //metodo nuevo
        public void amplificadores()
        {
            Console.WriteLine("Que te escuche todo el barrio");
        }

    }
}
