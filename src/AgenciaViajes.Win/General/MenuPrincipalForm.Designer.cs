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
            this.btnGestionNacionalidades = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestionLocalidades = new System.Windows.Forms.Button();
            this.btnSelectorLocalidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionNacionalidades
            // 
            this.btnGestionNacionalidades.Location = new System.Drawing.Point(50, 50);
            this.btnGestionNacionalidades.Name = "btnGestionNacionalidades";
            this.btnGestionNacionalidades.Size = new System.Drawing.Size(162, 23);
            this.btnGestionNacionalidades.TabIndex = 0;
            this.btnGestionNacionalidades.Text = "Gestión Nacionalidad";
            this.btnGestionNacionalidades.UseVisualStyleBackColor = true;
            this.btnGestionNacionalidades.Click += new System.EventHandler(this.BtnGestionNacionalidades_Click);
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
            // btnGestionLocalidades
            // 
            this.btnGestionLocalidades.Location = new System.Drawing.Point(50, 79);
            this.btnGestionLocalidades.Name = "btnGestionLocalidades";
            this.btnGestionLocalidades.Size = new System.Drawing.Size(162, 23);
            this.btnGestionLocalidades.TabIndex = 0;
            this.btnGestionLocalidades.Text = "Gestión Localidades";
            this.btnGestionLocalidades.UseVisualStyleBackColor = true;
            this.btnGestionLocalidades.Click += new System.EventHandler(this.BtnGestionLocalidades_Click);
            // 
            // btnSelectorLocalidades
            // 
            this.btnSelectorLocalidades.Location = new System.Drawing.Point(218, 50);
            this.btnSelectorLocalidades.Name = "btnSelectorLocalidades";
            this.btnSelectorLocalidades.Size = new System.Drawing.Size(162, 23);
            this.btnSelectorLocalidades.TabIndex = 0;
            this.btnSelectorLocalidades.Text = "Selector Localidades";
            this.btnSelectorLocalidades.UseVisualStyleBackColor = true;
            this.btnSelectorLocalidades.Click += new System.EventHandler(this.btnSelectorLocalidades_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionLocalidades);
            this.Controls.Add(this.btnSelectorLocalidades);
            this.Controls.Add(this.btnGestionNacionalidades);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionNacionalidades;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGestionLocalidades;
        private System.Windows.Forms.Button btnSelectorLocalidades;
    }
}