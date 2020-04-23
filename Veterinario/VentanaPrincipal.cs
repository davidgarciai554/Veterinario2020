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
    public partial class VentanaPrincipal : Form
    {
        //Juan
        connection myConnection = new connection();
        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView1.DataSource = myConnection.getPets();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void tab1_Nombre_Mascota_Click(object sender, EventArgs e)
        {

        }
    }
}
