namespace AgenciaViajes.Win.General
{
    partial class MenuPrincipalForm
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
            this.btnGestionNacionalidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLocalidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionNacionalidad
            // 
            this.btnGestionNacionalidad.Location = new System.Drawing.Point(50, 50);
            this.btnGestionNacionalidad.Name = "btnGestionNacionalidad";
            this.btnGestionNacionalidad.Size = new System.Drawing.Size(162, 23);
            this.btnGestionNacionalidad.TabIndex = 0;
            this.btnGestionNacionalidad.Text = "Gestión Nacionalidad";
            this.btnGestionNacionalidad.UseVisualStyleBackColor = true;
            this.btnGestionNacionalidad.Click += new System.EventHandler(this.BtnGestionNacionalidades_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(50, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnLocalidades
            // 
            this.btnLocalidades.Location = new System.Drawing.Point(50, 79);
            this.btnLocalidades.Name = "btnLocalidades";
            this.btnLocalidades.Size = new System.Drawing.Size(162, 23);
            this.btnLocalidades.TabIndex = 0;
            this.btnLocalidades.Text = "Gestión Localidades";
            this.btnLocalidades.UseVisualStyleBackColor = true;
            this.btnLocalidades.Click += new System.EventHandler(this.BtnGestionLocalidades_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLocalidades);
            this.Controls.Add(this.btnGestionNacionalidad);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionNacionalidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLocalidades;
    }
}