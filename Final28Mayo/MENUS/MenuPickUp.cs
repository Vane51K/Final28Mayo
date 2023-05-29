using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProyectoFinal.CLASE;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final28Mayo.MENUS
{
    public partial class MenuPickUp : Form
    {
        public MenuPickUp()
        {
            InitializeComponent();
            Load += MenuPickUp_Load;
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

        private void MenuPickUp_Load(object sender, EventArgs e)
        {
            PickUp pickup = new PickUp();
            pickup.marca = "Volkswagen";
            pickup.modelo = "Nuevo";
            pickup.color = "Azul";
            pickup.Anio = 2023;
            pickup.placa = "fps134";
            pickup.tipo = "Amarok";
            pickup.material = "Acero";
            pickup.CamRetro = "Si";
            pickup.luzled = "Doble";

            // Mostrar la información en etiquetas o controles de tu formulario
            lblMarca.Text = "Marca: " + pickup.marca;
            lblModelo.Text = "Modelo: " + pickup.modelo;
            lblColor.Text = "Color: " + pickup.color; 
            lblAnio.Text = "Año: " + pickup.Anio;
            lblPlaca.Text = "Placa: " + pickup.Placa;
            lblTipo.Text = "Tipo: " + pickup.Tipo;
            lblMaterial.Text = "Material: " + pickup.material;
            lblCamRetro.Text = "Camara de retroceso: " + pickup.CamRetro;
            lblLuzLed.Text = "Luces Led: " + pickup.luzled;
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblMaterial_Click(object sender, EventArgs e)
        {

        }

        private void lblLuzLed_Click(object sender, EventArgs e)
        {

        }

        private void lblAnio_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblCamRetro_Click(object sender, EventArgs e)
        {

        }
    }
}


