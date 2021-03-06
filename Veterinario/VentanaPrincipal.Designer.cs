﻿namespace Veterinario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DNI = new System.Windows.Forms.Label();
            this.ownerName = new System.Windows.Forms.Label();
            this.petReason = new System.Windows.Forms.Label();
            this.petHeight = new System.Windows.Forms.Label();
            this.petWeight = new System.Windows.Forms.Label();
            this.petNHC = new System.Windows.Forms.Label();
            this.petType = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(676, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.DNI);
            this.tabPage2.Controls.Add(this.ownerName);
            this.tabPage2.Controls.Add(this.petReason);
            this.tabPage2.Controls.Add(this.petHeight);
            this.tabPage2.Controls.Add(this.petWeight);
            this.tabPage2.Controls.Add(this.petNHC);
            this.tabPage2.Controls.Add(this.petType);
            this.tabPage2.Controls.Add(this.petName);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(327, 48);
            this.DNI.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(41, 18);
            this.DNI.TabIndex = 10;
            this.DNI.Text = "DNI: ";
            // 
            // ownerName
            // 
            this.ownerName.AutoSize = true;
            this.ownerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerName.Location = new System.Drawing.Point(327, 13);
            this.ownerName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(115, 18);
            this.ownerName.TabIndex = 9;
            this.ownerName.Text = "Nombre dueño: ";
            // 
            // petReason
            // 
            this.petReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petReason.Location = new System.Drawing.Point(19, 200);
            this.petReason.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petReason.Name = "petReason";
            this.petReason.Size = new System.Drawing.Size(266, 109);
            this.petReason.TabIndex = 8;
            this.petReason.Text = "Motivo: ";
            // 
            // petHeight
            // 
            this.petHeight.AutoSize = true;
            this.petHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petHeight.Location = new System.Drawing.Point(19, 162);
            this.petHeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petHeight.Name = "petHeight";
            this.petHeight.Size = new System.Drawing.Size(53, 18);
            this.petHeight.TabIndex = 7;
            this.petHeight.Text = "Altura: ";
            // 
            // petWeight
            // 
            this.petWeight.AutoSize = true;
            this.petWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petWeight.Location = new System.Drawing.Point(19, 124);
            this.petWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petWeight.Name = "petWeight";
            this.petWeight.Size = new System.Drawing.Size(51, 18);
            this.petWeight.TabIndex = 6;
            this.petWeight.Text = "Peso: ";
            // 
            // petNHC
            // 
            this.petNHC.AutoSize = true;
            this.petNHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petNHC.Location = new System.Drawing.Point(19, 86);
            this.petNHC.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petNHC.Name = "petNHC";
            this.petNHC.Size = new System.Drawing.Size(49, 18);
            this.petNHC.TabIndex = 5;
            this.petNHC.Text = "NHC: ";
            // 
            // petType
            // 
            this.petType.AutoSize = true;
            this.petType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petType.Location = new System.Drawing.Point(19, 48);
            this.petType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petType.Name = "petType";
            this.petType.Size = new System.Drawing.Size(60, 18);
            this.petType.TabIndex = 4;
            this.petType.Text = "Animal: ";
            // 
            // petName
            // 
            this.petName.AutoSize = true;
            this.petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petName.Location = new System.Drawing.Point(19, 15);
            this.petName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(70, 18);
            this.petName.TabIndex = 0;
            this.petName.Text = "Nombre: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.productPrice);
            this.tabPage3.Controls.Add(this.productDescription);
            this.tabPage3.Controls.Add(this.productName);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(420, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // productPrice
            // 
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(562, 85);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(100, 39);
            this.productPrice.TabIndex = 3;
            this.productPrice.Text = "     €";
            // 
            // productDescription
            // 
            this.productDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription.Location = new System.Drawing.Point(6, 163);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(320, 151);
            this.productDescription.TabIndex = 2;
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(320, 21);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(297, 64);
            this.productName.TabIndex = 1;
            this.productName.Text = "Nombre: ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_bandage.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_dog.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_shopping_cart.ico");
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 133);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 374);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Veterinario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label petType;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.Label petHeight;
        private System.Windows.Forms.Label petWeight;
        private System.Windows.Forms.Label petNHC;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label ownerName;
        private System.Windows.Forms.Label petReason;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productDescription;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}