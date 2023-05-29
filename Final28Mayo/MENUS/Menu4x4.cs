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
    public partial class Menu4x4 : Form
    {
        public Menu4x4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void Menu4x4_Load(object sender, EventArgs e)
        {
            _4x4 k4x4 = new _4x4();
            k4x4.marca = "Jeep Wrangler";
            k4x4.modelo = "Rubicon";
            k4x4.color = "Gris";
            k4x4.Anio = 2023;
            k4x4.placa = "po589s";
            k4x4.tipo = "4x4";
            k4x4.suspension = "Si";
            k4x4.amortiguadores = "Si";
            k4x4.defensa = "Si";

            // Mostrar la información en etiquetas o controles de tu formulario
            lblMarca.Text = "Marca: " + k4x4.marca;
            lblModelo.Text = "Modelo: " + k4x4.modelo;
            lblColor.Text = "Color: " + k4x4.color;
            lblAnio.Text = "Año: " + k4x4.Anio;
            lblPlaca.Text = "Placa: " + k4x4.placa;
            lblTipo.Text = "Tipo: " + k4x4.tipo;
            lblSuspension.Text = "Suspensión: " + k4x4.suspension;
            lblAmortiguadores.Text = "Amortiguadores: " + k4x4.amortiguadores;
            lblDefensa.Text = "Defensa: " + k4x4.defensa;
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
