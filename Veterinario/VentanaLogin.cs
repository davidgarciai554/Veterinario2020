using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario
{
    public partial class VentanaLogin : Form
    {
        connection _connection = new connection();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_connection.checkUser(user_Txt.Text, pass_Txt.Text))
            {
                MessageBox.Show("Se ha logeado bien");
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.Show();
                this.Hide();
            }
            else
            {
                //MessageBox.Show("Usuario o contraseña incorrectos");
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaNewUser ventana = new VentanaNewUser();
            ventana.Show();
        }
    }
}
