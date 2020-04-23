using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class VentanaConsulta : Form
    {
        public VentanaConsulta()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            Console.WriteLine(pet_name + " " + pet_id + " " + pet_type + " " + pet_NHC + " " + pet_weight + " " + pet_height + " " + owner_name + " " + owner_dni + " " + reason);
            this.Hide();
        }
    }
}
