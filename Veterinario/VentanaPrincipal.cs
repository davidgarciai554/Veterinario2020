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

            dataGridView2.DataSource = myConnection.shop();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;       
        }

        //Juan
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getPetInfo(dataGridView1.Rows[e.RowIndex].Cells["Nombre Mascota"].Value.ToString());
            tabPage2.Show();
            tabControl1.SelectedTab = tabPage2;
        }
        private Image convierteBlobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        public void getPetInfo(String _petName)
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
        public void getShopInfo(String id)
        {
            pets = myConnection.shopProducts(id);
            productName.Text = "Producto: " + pets.Rows[0]["Nombre"].ToString();
            productPrice.Text = pets.Rows[0]["Precio"].ToString()+" €";
            productDescription.Text = pets.Rows[0]["Descripcion"].ToString();
            pictureBox2.Image = convierteBlobImagen((byte[])pets.Rows[0]["IMG"]);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getShopInfo(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
    }
}
