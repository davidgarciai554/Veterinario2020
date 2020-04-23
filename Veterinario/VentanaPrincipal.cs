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
        //Juan
        private void creaConsulta_Click(object sender, EventArgs e)
        {
            VentanaConsulta ventanaConsulta = new VentanaConsulta();
            ventanaConsulta.Show();
        }
        //Juan
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            petName.Text = "Nombre: ";
            petType.Text = "Animal: ";
            petNHC.Text = "NHC: ";
            petHeight.Text = "Altura: ";
            petWeight.Text = "Peso: ";
            petReason.Text = "Motivo: ";
            ownerName.Text = "Nombre dueño: ";
            DNI.Text = "DNI: ";
        }
    }
}
