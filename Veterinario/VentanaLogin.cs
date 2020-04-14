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
    public partial class VentanaLogin : Form
    {
        connection _connection = new connection();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = user_Txt.Text;
            String password = pass_Txt.Text;
            if (_connection.checkUser(user,password))
            {
                this.Hide();
            }
            else
            {
                error.Text = "Usuario o contraseña incorrectos";
            }

        }
    }
}
