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
                this.Hide();
                MessageBox.Show("Se ha logeado bien");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            VentanaNewUser ventana = new VentanaNewUser();
            ventana.Show();
            this.Hide();
        }
    }
}
