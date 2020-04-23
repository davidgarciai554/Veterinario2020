namespace Veterinario
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tab1_Nombre_Mascota = new System.Windows.Forms.Label();
            this.tab1_NHC_Mascota = new System.Windows.Forms.Label();
            this.tab1_Peso = new System.Windows.Forms.Label();
            this.tab1_Altura = new System.Windows.Forms.Label();
            this.tab1_Nombre_Dueño = new System.Windows.Forms.Label();
            this.tab1_TipoAnimal = new System.Windows.Forms.Label();
            this.DNI_Dueño = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.DNI_Dueño);
            this.tabPage1.Controls.Add(this.tab1_TipoAnimal);
            this.tabPage1.Controls.Add(this.tab1_Nombre_Dueño);
            this.tabPage1.Controls.Add(this.tab1_Altura);
            this.tabPage1.Controls.Add(this.tab1_Peso);
            this.tabPage1.Controls.Add(this.tab1_NHC_Mascota);
            this.tabPage1.Controls.Add(this.tab1_Nombre_Mascota);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(659, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_bandage.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_dog.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_shopping_cart.ico");
            // 
            // tab1_Nombre_Mascota
            // 
            this.tab1_Nombre_Mascota.Location = new System.Drawing.Point(122, 30);
            this.tab1_Nombre_Mascota.Name = "tab1_Nombre_Mascota";
            this.tab1_Nombre_Mascota.Size = new System.Drawing.Size(108, 30);
            this.tab1_Nombre_Mascota.TabIndex = 0;
            this.tab1_Nombre_Mascota.Text = "Nombre";
            this.tab1_Nombre_Mascota.Click += new System.EventHandler(this.tab1_Nombre_Mascota_Click);
            // 
            // tab1_NHC_Mascota
            // 
            this.tab1_NHC_Mascota.Location = new System.Drawing.Point(8, 30);
            this.tab1_NHC_Mascota.Name = "tab1_NHC_Mascota";
            this.tab1_NHC_Mascota.Size = new System.Drawing.Size(108, 30);
            this.tab1_NHC_Mascota.TabIndex = 1;
            this.tab1_NHC_Mascota.Text = "NHC";
            // 
            // tab1_Peso
            // 
            this.tab1_Peso.Location = new System.Drawing.Point(350, 30);
            this.tab1_Peso.Name = "tab1_Peso";
            this.tab1_Peso.Size = new System.Drawing.Size(108, 30);
            this.tab1_Peso.TabIndex = 2;
            this.tab1_Peso.Text = "Peso";
            // 
            // tab1_Altura
            // 
            this.tab1_Altura.Location = new System.Drawing.Point(464, 30);
            this.tab1_Altura.Name = "tab1_Altura";
            this.tab1_Altura.Size = new System.Drawing.Size(108, 30);
            this.tab1_Altura.TabIndex = 3;
            this.tab1_Altura.Text = "Altura";
            // 
            // tab1_Nombre_Dueño
            // 
            this.tab1_Nombre_Dueño.Location = new System.Drawing.Point(8, 84);
            this.tab1_Nombre_Dueño.Name = "tab1_Nombre_Dueño";
            this.tab1_Nombre_Dueño.Size = new System.Drawing.Size(108, 30);
            this.tab1_Nombre_Dueño.TabIndex = 4;
            this.tab1_Nombre_Dueño.Text = "Nombre_Dueño";
            // 
            // tab1_TipoAnimal
            // 
            this.tab1_TipoAnimal.Location = new System.Drawing.Point(236, 30);
            this.tab1_TipoAnimal.Name = "tab1_TipoAnimal";
            this.tab1_TipoAnimal.Size = new System.Drawing.Size(108, 30);
            this.tab1_TipoAnimal.TabIndex = 5;
            this.tab1_TipoAnimal.Text = "Tipo de animal";
            // 
            // DNI_Dueño
            // 
            this.DNI_Dueño.Location = new System.Drawing.Point(122, 84);
            this.DNI_Dueño.Name = "DNI_Dueño";
            this.DNI_Dueño.Size = new System.Drawing.Size(108, 30);
            this.DNI_Dueño.TabIndex = 6;
            this.DNI_Dueño.Text = "DNI_Dueño";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 211);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label DNI_Dueño;
        private System.Windows.Forms.Label tab1_TipoAnimal;
        private System.Windows.Forms.Label tab1_Nombre_Dueño;
        private System.Windows.Forms.Label tab1_Altura;
        private System.Windows.Forms.Label tab1_Peso;
        private System.Windows.Forms.Label tab1_NHC_Mascota;
        private System.Windows.Forms.Label tab1_Nombre_Mascota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}