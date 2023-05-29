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
    public partial class MenuSUV : Form
    {
        public MenuSUV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void MenuSUV_Load(object sender, EventArgs e)
        {
            SUV suv = new SUV();
            suv.marca = "Peugeot";
            suv.modelo = "Active";
            suv.color = "Naranja";
            suv.Anio = 2008;
            suv.placa = "s258cd";
            suv.tipo = "Vehiculo deportivo";
            suv.parabrisas = "3";
            suv.vinilos = "Si";
            suv.altavoces = "6";

            // Mostrar la información en etiquetas o controles de tu formulario
            lblMarca.Text = "Marca: " + suv.marca;
            lblModelo.Text = "Modelo: " + suv.modelo;
            lblColor.Text = "Color: " + suv.color;
            lblAnio.Text = "Año: " + suv.Anio;
            lblPlaca.Text = "Placa: " + suv.placa;
            lblTipo.Text = "Tipo: " + suv.tipo;
            lblParabrisas.Text = "Parabrisas: " + suv.parabrisas;
            lblVinilos.Text = "Vinilos: " + suv.vinilos;
            lblVinilos.Text = "Altavoces: " + suv.altavoces;
        }
    }
}
