using ProyectoFinal.CLASE;
using ProyectoFinal.INTERFAZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            PickUp pickup = new PickUp();
            pickup.Estado = false;
            do
            {

                int ele;
                Console.WriteLine("El coche esta apagado");
                Console.WriteLine("¿Desea encender el auto?");
                Console.WriteLine("1.Si \t2.No");
                ele = Convert.ToInt32(Console.ReadLine());

                if (ele == 1)
                {
                    Console.WriteLine("Su carro se ha encendido");
                    pickup.Estado = true;

                    pickup.acelerar(100);
                    pickup.frenar(100);
                    pickup.bocina();
                    pickup.pilotoautometico();
                    pickup.apagar();
                }
                else
                {
                    pickup.Estado = false;
                }

            } while (pickup.Estado == false);


            pickup.marca = "Volkswagen";
            pickup.modelo = "Nuevo";
            pickup.color = "Azul";
            pickup.Anio = 2023;
            pickup.placa = "fps134";
            pickup.tipo = "Amarok";
            pickup.material = "Acero";
            pickup.CamRetro = "Si";
            pickup.luzled = "Doble";

            PropertyInfo[] propiedades = pickup.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                Console.WriteLine(propiedad.Name + ": " + propiedad.GetValue(pickup));
            }

            Sedan sedan = new Sedan();
            sedan.Estado = false;

            do
            {

                int ele;
                Console.WriteLine("El coche esta apagado");
                Console.WriteLine("¿Desea encender el auto?");
                Console.WriteLine("1.Si \t2.No");
                ele = Convert.ToInt32(Console.ReadLine());

                if (ele == 1)
                {
                    Console.WriteLine("Su carro se ha encendido");
                    sedan.Estado = true;

                    sedan.acelerar(100);
                    sedan.frenar(100);
                    sedan.bocina();
                    sedan.volar();
                    sedan.apagar();
                }
                else
                {
                    sedan.Estado = false;
                }

            } while (sedan.Estado == false);

            sedan.marca = "Nissan";
            sedan.modelo = "Nuevo";
            sedan.color = "Negro";
            sedan.Anio = 2023;
            sedan.placa = "423sde";
            sedan.tipo = "Sentra";
            sedan.Polarizado = "SI";
            sedan.PortaVasos = "3";
            sedan.Ventanas = "4";


            PropertyInfo[] propiedade = sedan.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propiedade)
            {
                Console.WriteLine(propiedad.Name + ": " + propiedad.GetValue(sedan));
            }

            SUV suv = new SUV();
            suv.Estado = false;
            do
            {

                int ele;
                Console.WriteLine("El coche esta apagado");
                Console.WriteLine("¿Desea encender el auto?");
                Console.WriteLine("1.Si \t2.No");
                ele = Convert.ToInt32(Console.ReadLine());

                if (ele == 1)
                {
                    Console.WriteLine("Su carro se ha encendido");
                    suv.Estado = true;

                    suv.acelerar(100);
                    suv.frenar(100);
                    suv.bocina();
                    suv.SistemaantiR();
                    suv.apagar();
                }
                else
                {
                    suv.Estado = false;
                }

            } while (suv.Estado == false);


            suv.marca = "Peugeot";
            suv.modelo = "Active";
            suv.color = "Naranja";
            suv.Anio = 2008;
            suv.placa = "s258cd";
            suv.tipo = "Vehiculo deportivo";
            suv.parabrisas = "3";
            suv.vinilos = "Si";
            suv.altavoces = "6";

            PropertyInfo[] propi = suv.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propi)
            {
                Console.WriteLine(propiedad.Name + ": " + propiedad.GetValue(suv));
            }

            _4x4 k4x4 = new _4x4();
            k4x4.Estado = false;
            do
            {

                int ele;
                Console.WriteLine("El coche esta apagado");
                Console.WriteLine("¿Desea encender el auto?");
                Console.WriteLine("1.Si \t2.No");
                ele = Convert.ToInt32(Console.ReadLine());

                if (ele == 1)
                {
                    Console.WriteLine("Su carro se ha encendido");
                    k4x4.Estado = true;

                    k4x4.acelerar(100);
                    k4x4.frenar(100);
                    k4x4.bocina();
                    k4x4.amplificadores();
                    k4x4.apagar();
                }
                else
                {
                    k4x4.Estado = false;
                }

            } while (k4x4.Estado == false);

            k4x4.marca = "Jeep Wrangler";
            k4x4.modelo = "Rubicon";
            k4x4.color = "Gris";
            k4x4.Anio = 2023;
            k4x4.placa = "po589s";
            k4x4.tipo = "4x4";
            k4x4.suspension = "Si";
            k4x4.amortiguadores = "Si";
            k4x4.defensa = "Si";


            PropertyInfo[] propieda = k4x4.GetType().GetProperties();

            foreach (PropertyInfo propiedad in propieda)
            {
                Console.WriteLine(propiedad.Name + ": " + propiedad.GetValue(k4x4));
            }
        }
    }
}