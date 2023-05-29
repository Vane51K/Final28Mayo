using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.CLASE
{
    class PickUp : VehiculoBase
    {
        //Propiedades agregadas

        public string material { get; set; }
        public string CamRetro { get; set; }
        public string luzled { get; set; }
        public bool Estado { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int Anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }


        public int VelocidadMaxima { get; set; }

        public int VelocidadActual { get; set; }

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

        public void pilotoautometico()
        {
            Console.WriteLine("Se activo el Piloto Automatico");
        }
    }
}
