namespace Veterinario
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_Txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_Txt
            // 
            this.user_Txt.Location = new System.Drawing.Point(58, 93);
            this.user_Txt.Name = "user_Txt";
            this.user_Txt.Size = new System.Drawing.Size(197, 20);
            this.user_Txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI/Usuario";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // pass_Txt
            // 
            this.pass_Txt.Location = new System.Drawing.Point(58, 146);
            this.pass_Txt.Name = "pass_Txt";
            this.pass_Txt.Size = new System.Drawing.Size(197, 20);
            this.pass_Txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(61, 212);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(194, 27);
            this.error.TabIndex = 5;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 339);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_Txt);
            this.Name = "VentanaLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_Txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label error;
    }
}

