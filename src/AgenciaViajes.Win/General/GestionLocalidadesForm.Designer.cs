namespace AgenciaViajes.Win.General
{
    partial class GestionLocalidadesForm
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
            this.tabControlLocalidades = new System.Windows.Forms.TabControl();
            this.tabCiudades = new System.Windows.Forms.TabPage();
            this.gridCiudades = new System.Windows.Forms.DataGridView();
            this.tabProvincias = new System.Windows.Forms.TabPage();
            this.gridProvincias = new System.Windows.Forms.DataGridView();
            this.tabPaises = new System.Windows.Forms.TabPage();
            this.gridPaises = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRecargarTodo = new System.Windows.Forms.Button();
            this.tabControlLocalidades.SuspendLayout();
            this.tabCiudades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudades)).BeginInit();
            this.tabProvincias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProvincias)).BeginInit();
            this.tabPaises.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLocalidades
            // 
            this.tabControlLocalidades.Controls.Add(this.tabCiudades);
            this.tabControlLocalidades.Controls.Add(this.tabProvincias);
            this.tabControlLocalidades.Controls.Add(this.tabPaises);
            this.tabControlLocalidades.Location = new System.Drawing.Point(12, 12);
            this.tabControlLocalidades.Name = "tabControlLocalidades";
            this.tabControlLocalidades.SelectedIndex = 0;
            this.tabControlLocalidades.Size = new System.Drawing.Size(776, 375);
            this.tabControlLocalidades.TabIndex = 0;
            // 
            // tabCiudades
            // 
            this.tabCiudades.Controls.Add(this.gridCiudades);
            this.tabCiudades.Location = new System.Drawing.Point(4, 22);
            this.tabCiudades.Name = "tabCiudades";
            this.tabCiudades.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiudades.Size = new System.Drawing.Size(768, 349);
            this.tabCiudades.TabIndex = 1;
            this.tabCiudades.Text = "Ciudades";
            this.tabCiudades.UseVisualStyleBackColor = true;
            // 
            // gridCiudades
            // 
            this.gridCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCiudades.Location = new System.Drawing.Point(3, 6);
            this.gridCiudades.Name = "gridCiudades";
            this.gridCiudades.Size = new System.Drawing.Size(759, 337);
            this.gridCiudades.TabIndex = 0;
            // 
            // tabProvincias
            // 
            this.tabProvincias.Controls.Add(this.gridProvincias);
            this.tabProvincias.Location = new System.Drawing.Point(4, 22);
            this.tabProvincias.Name = "tabProvincias";
            this.tabProvincias.Padding = new System.Windows.Forms.Padding(3);
            this.tabProvincias.Size = new System.Drawing.Size(768, 349);
            this.tabProvincias.TabIndex = 2;
            this.tabProvincias.Text = "Localidades";
            this.tabProvincias.UseVisualStyleBackColor = true;
            // 
            // gridProvincias
            // 
            this.gridProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProvincias.Location = new System.Drawing.Point(6, 6);
            this.gridProvincias.Name = "gridProvincias";
            this.gridProvincias.Size = new System.Drawing.Size(756, 337);
            this.gridProvincias.TabIndex = 0;
            // 
            // tabPaises
            // 
            this.tabPaises.Controls.Add(this.gridPaises);
            this.tabPaises.Location = new System.Drawing.Point(4, 22);
            this.tabPaises.Name = "tabPaises";
            this.tabPaises.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaises.Size = new System.Drawing.Size(768, 349);
            this.tabPaises.TabIndex = 3;
            this.tabPaises.Text = "Paises";
            this.tabPaises.UseVisualStyleBackColor = true;
            // 
            // gridPaises
            // 
            this.gridPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaises.Location = new System.Drawing.Point(6, 6);
            this.gridPaises.Name = "gridPaises";
            this.gridPaises.Size = new System.Drawing.Size(756, 337);
            this.gridPaises.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(709, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnRecargarTodo
            // 
            this.btnRecargarTodo.Location = new System.Drawing.Point(628, 393);
            this.btnRecargarTodo.Name = "btnRecargarTodo";
            this.btnRecargarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnRecargarTodo.TabIndex = 2;
            this.btnRecargarTodo.Text = "Recargar Todo";
            this.btnRecargarTodo.UseVisualStyleBackColor = true;
            this.btnRecargarTodo.Click += new System.EventHandler(this.BtnRecargarTodo_Click);
            // 
            // GestionLocalidadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecargarTodo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControlLocalidades);
            this.Name = "GestionLocalidadesForm";
            this.Text = "GestionLocalidadesForm";
            this.tabControlLocalidades.ResumeLayout(false);
            this.tabCiudades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudades)).EndInit();
            this.tabProvincias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProvincias)).EndInit();
            this.tabPaises.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLocalidades;
        private System.Windows.Forms.TabPage tabCiudades;
        private System.Windows.Forms.TabPage tabProvincias;
        private System.Windows.Forms.TabPage tabPaises;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView gridCiudades;
        private System.Windows.Forms.DataGridView gridProvincias;
        private System.Windows.Forms.DataGridView gridPaises;
        private System.Windows.Forms.Button btnRecargarTodo;
    }
}