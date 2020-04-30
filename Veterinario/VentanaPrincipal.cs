using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        DataTable pets = new DataTable();

        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView1.DataSource = myConnection.getPets();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        //Juan
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            getInfo(dataGridView1.Rows[e.RowIndex].Cells["Nombre Mascota"].Value.ToString());                 
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
           

        }
        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        public void getInfo(String _petName)
        {
            pets = myConnection.getAllPets(_petName);
            petName.Text = "Nombre: " + pets.Rows[0]["Nombre_Mascota"].ToString();
            petType.Text = "Animal: " + pets.Rows[0]["Animal_Mascota"].ToString();
            petNHC.Text = "NHC: " + pets.Rows[0]["NumeroHistorialClinico"].ToString();
            petHeight.Text = "Altura: " + pets.Rows[0]["Altura_Mascota"].ToString();
            petWeight.Text = "Peso: " + pets.Rows[0]["Peso_Mascota"].ToString();
            petReason.Text = "Motivo: " + pets.Rows[0]["Motivo_Asistencia"].ToString();
            ownerName.Text = "Nombre dueño: " + pets.Rows[0]["Nombre_Dueño"].ToString();
            DNI.Text = "DNI: " + pets.Rows[0]["DNI_Dueño"].ToString();
            pictureBox1.Image = convierteBlobImagen((byte[])pets.Rows[0]["Mascota_IMG"]);
        }
    }
}
