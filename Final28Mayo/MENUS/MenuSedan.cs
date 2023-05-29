using ProyectoFinal.CLASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final28Mayo.MENUS
{
    public partial class MenuSedan : Form
    {
        public MenuSedan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void MenuSedan_Load(object sender, EventArgs e)
        {
            Sedan sedan = new Sedan();
            sedan.marca = "Nissan";
            sedan.modelo = "Nuevo";
            sedan.color = "Negro";
            sedan.Anio = 2023;
            sedan.placa = "423sde";
            sedan.tipo = "Sentra";
            sedan.Polarizado = "SI";
            sedan.PortaVasos = "3";
            sedan.Ventanas = "4";

            // Mostrar la información en etiquetas o controles de tu formulario
            lblMarca.Text = "Marca: " + sedan.marca;
            lblModelo.Text = "Modelo: " + sedan.modelo;
            lblColor.Text = "Color: " + sedan.color;
            lblAnio.Text = "Año: " + sedan.Anio;
            lblPlaca.Text = "Placa: " + sedan.placa;
            lblTipo.Text = "Tipo: " + sedan.tipo;
            lblPolarizado.Text = "Polarizado: " + sedan.Polarizado;
            lblPortaVasos.Text = "Portavasos: " + sedan.PortaVasos;
            lblVentanas.Text = "Ventanas: " + sedan.Ventanas;
        }
    }
}
