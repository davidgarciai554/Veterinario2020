namespace Veterinario
{
    partial class VentanaConsulta
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
            this.pet_name = new System.Windows.Forms.TextBox();
            this.PetName = new System.Windows.Forms.Label();
            this.Animal = new System.Windows.Forms.Label();
            this.pet_type = new System.Windows.Forms.TextBox();
            this.NHC = new System.Windows.Forms.Label();
            this.pet_NHC = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.pet_weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.pet_height = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.Label();
            this.owner_name = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.owner_dni = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.pet_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pet_name
            // 
            this.pet_name.Location = new System.Drawing.Point(16, 29);
            this.pet_name.Name = "pet_name";
            this.pet_name.Size = new System.Drawing.Size(100, 20);
            this.pet_name.TabIndex = 0;
            // 
            // PetName
            // 
            this.PetName.AutoSize = true;
            this.PetName.Location = new System.Drawing.Point(13, 13);
            this.PetName.Name = "PetName";
            this.PetName.Size = new System.Drawing.Size(88, 13);
            this.PetName.TabIndex = 1;
            this.PetName.Text = "Nombre Mascota";
            // 
            // Animal
            // 
            this.Animal.AutoSize = true;
            this.Animal.Location = new System.Drawing.Point(15, 91);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(38, 13);
            this.Animal.TabIndex = 3;
            this.Animal.Text = "Animal";
            // 
            // pet_type
            // 
            this.pet_type.Location = new System.Drawing.Point(18, 107);
            this.pet_type.Name = "pet_type";
            this.pet_type.Size = new System.Drawing.Size(100, 20);
            this.pet_type.TabIndex = 2;
            // 
            // NHC
            // 
            this.NHC.AutoSize = true;
            this.NHC.Location = new System.Drawing.Point(15, 130);
            this.NHC.Name = "NHC";
            this.NHC.Size = new System.Drawing.Size(30, 13);
            this.NHC.TabIndex = 5;
            this.NHC.Text = "NHC";
            // 
            // pet_NHC
            // 
            this.pet_NHC.Location = new System.Drawing.Point(18, 146);
            this.pet_NHC.Name = "pet_NHC";
            this.pet_NHC.Size = new System.Drawing.Size(100, 20);
            this.pet_NHC.TabIndex = 4;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(15, 169);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(31, 13);
            this.weight.TabIndex = 7;
            this.weight.Text = "Peso";
            // 
            // pet_weight
            // 
            this.pet_weight.Location = new System.Drawing.Point(18, 185);
            this.pet_weight.Name = "pet_weight";
            this.pet_weight.Size = new System.Drawing.Size(100, 20);
            this.pet_weight.TabIndex = 6;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(15, 208);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(33, 13);
            this.Height.TabIndex = 9;
            this.Height.Text = "altura";
            // 
            // pet_height
            // 
            this.pet_height.Location = new System.Drawing.Point(18, 224);
            this.pet_height.Name = "pet_height";
            this.pet_height.Size = new System.Drawing.Size(100, 20);
            this.pet_height.TabIndex = 8;
            // 
            // OwnerName
            // 
            this.OwnerName.AutoSize = true;
            this.OwnerName.Location = new System.Drawing.Point(168, 13);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(79, 13);
            this.OwnerName.TabIndex = 11;
            this.OwnerName.Text = "Nombre Dueño";
            // 
            // owner_name
            // 
            this.owner_name.Location = new System.Drawing.Point(171, 29);
            this.owner_name.Name = "owner_name";
            this.owner_name.Size = new System.Drawing.Size(100, 20);
            this.owner_name.TabIndex = 10;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(168, 52);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 13;
            this.DNI.Text = "DNI";
            // 
            // owner_dni
            // 
            this.owner_dni.Location = new System.Drawing.Point(171, 68);
            this.owner_dni.Name = "owner_dni";
            this.owner_dni.Size = new System.Drawing.Size(100, 20);
            this.owner_dni.TabIndex = 12;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(168, 91);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(39, 13);
            this.text.TabIndex = 15;
            this.text.Text = "Motivo";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(171, 106);
            this.reason.Multiline = true;
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(100, 138);
            this.reason.TabIndex = 16;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(89, 263);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(118, 36);
            this.Send.TabIndex = 17;
            this.Send.Text = "Crear";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(15, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 19;
            this.ID.Text = "ID";
            // 
            // pet_id
            // 
            this.pet_id.Location = new System.Drawing.Point(18, 68);
            this.pet_id.Name = "pet_id";
            this.pet_id.Size = new System.Drawing.Size(100, 20);
            this.pet_id.TabIndex = 18;
            // 
            // VentanaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 325);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pet_id);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.text);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.owner_dni);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.owner_name);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.pet_height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.pet_weight);
            this.Controls.Add(this.NHC);
            this.Controls.Add(this.pet_NHC);
            this.Controls.Add(this.Animal);
            this.Controls.Add(this.pet_type);
            this.Controls.Add(this.PetName);
            this.Controls.Add(this.pet_name);
            this.Name = "VentanaConsulta";
            this.Text = "VentanaConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pet_name;
        private System.Windows.Forms.Label PetName;
        private System.Windows.Forms.Label Animal;
        private System.Windows.Forms.TextBox pet_type;
        private System.Windows.Forms.Label NHC;
        private System.Windows.Forms.TextBox pet_NHC;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox pet_weight;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox pet_height;
        private System.Windows.Forms.Label OwnerName;
        private System.Windows.Forms.TextBox owner_name;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.TextBox owner_dni;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox pet_id;
    }
}