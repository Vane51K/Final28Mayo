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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPickUp menuPickUp = new MenuPickUp();
            menuPickUp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuSedan menuSedan = new MenuSedan();
            menuSedan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuSUV menuSUV = new MenuSUV();
            menuSUV.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu4x4 menu4X4 = new Menu4x4();
            menu4X4.Show();
            this.Hide();
        }
    }
}
