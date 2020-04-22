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
    public partial class VentanaNewUser : Form
    {
        connection _connection = new connection();
        public VentanaNewUser()
        {
            InitializeComponent();
        }
        //David
        private void button1_Click(object sender, EventArgs e)
        {
            string myHash = BCrypt.Net.BCrypt.HashPassword(DNI_txt.Text, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(_connection.newUser(name_txt.Text, pass_txt.Text,myHash ));
            this.Hide();
        }
    }
}
