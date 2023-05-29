using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.INTERFAZ
{
    interface IVehiculo
    {
        //Propiedades
        string Marca { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }
        int anio { get; set; }
        string Placa { get; set; }
        string Tipo { get; set; }
        int VelocidadMaxima { get; set; }
        int VelocidadActual { get; set; }

        //Métodos
        void Bocina();
        void Acelerar(int cuando);
        void Encende();
        void Apagar();
        void Frenar(int cuando);

    }
}
