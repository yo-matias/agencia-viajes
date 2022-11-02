namespace AgenciaViajes.Win.Selectores
{
    partial class SelectorLocalidadesForm
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
            this.txtDescCiudad = new System.Windows.Forms.TextBox();
            this.txtDescProvincia = new System.Windows.Forms.TextBox();
            this.txtDescPais = new System.Windows.Forms.TextBox();
            this.lblCiudadTxt = new System.Windows.Forms.Label();
            this.lblProvinciaTxt = new System.Windows.Forms.Label();
            this.lblPaisTxt = new System.Windows.Forms.Label();
            this.gridLocalidades = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescCiudad
            // 
            this.txtDescCiudad.Location = new System.Drawing.Point(74, 6);
            this.txtDescCiudad.Name = "txtDescCiudad";
            this.txtDescCiudad.Size = new System.Drawing.Size(149, 20);
            this.txtDescCiudad.TabIndex = 0;
            this.txtDescCiudad.Enter += new System.EventHandler(this.TxtDescCiudad_Enter);
            // 
            // txtDescProvincia
            // 
            this.txtDescProvincia.Location = new System.Drawing.Point(74, 32);
            this.txtDescProvincia.Name = "txtDescProvincia";
            this.txtDescProvincia.Size = new System.Drawing.Size(149, 20);
            this.txtDescProvincia.TabIndex = 1;
            this.txtDescProvincia.Enter += new System.EventHandler(this.TxtDescProvincia_Enter);
            // 
            // txtDescPais
            // 
            this.txtDescPais.Location = new System.Drawing.Point(74, 58);
            this.txtDescPais.Name = "txtDescPais";
            this.txtDescPais.Size = new System.Drawing.Size(149, 20);
            this.txtDescPais.TabIndex = 2;
            this.txtDescPais.Enter += new System.EventHandler(this.TxtDescPais_Enter);
            // 
            // lblCiudadTxt
            // 
            this.lblCiudadTxt.AutoSize = true;
            this.lblCiudadTxt.Location = new System.Drawing.Point(12, 9);
            this.lblCiudadTxt.Name = "lblCiudadTxt";
            this.lblCiudadTxt.Size = new System.Drawing.Size(43, 13);
            this.lblCiudadTxt.TabIndex = 3;
            this.lblCiudadTxt.Text = "Ciudad:";
            // 
            // lblProvinciaTxt
            // 
            this.lblProvinciaTxt.AutoSize = true;
            this.lblProvinciaTxt.Location = new System.Drawing.Point(12, 35);
            this.lblProvinciaTxt.Name = "lblProvinciaTxt";
            this.lblProvinciaTxt.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaTxt.TabIndex = 3;
            this.lblProvinciaTxt.Text = "Provincia:";
            // 
            // lblPaisTxt
            // 
            this.lblPaisTxt.AutoSize = true;
            this.lblPaisTxt.Location = new System.Drawing.Point(12, 61);
            this.lblPaisTxt.Name = "lblPaisTxt";
            this.lblPaisTxt.Size = new System.Drawing.Size(32, 13);
            this.lblPaisTxt.TabIndex = 3;
            this.lblPaisTxt.Text = "País:";
            // 
            // gridLocalidades
            // 
            this.gridLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.IdCiudad,
            this.DescripcionCiudad,
            this.IdProvincia,
            this.DescripcionProvincia,
            this.IdPais,
            this.DescripcionPais});
            this.gridLocalidades.Location = new System.Drawing.Point(12, 84);
            this.gridLocalidades.Name = "gridLocalidades";
            this.gridLocalidades.Size = new System.Drawing.Size(750, 352);
            this.gridLocalidades.TabIndex = 4;
            this.gridLocalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLocalidades_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Visible = false;
            // 
            // IdCiudad
            // 
            this.IdCiudad.DataPropertyName = "IdCiudad";
            this.IdCiudad.HeaderText = "Ciudad Id";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.ReadOnly = true;
            this.IdCiudad.Visible = false;
            // 
            // DescripcionCiudad
            // 
            this.DescripcionCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionCiudad.DataPropertyName = "DescripcionCiudad";
            this.DescripcionCiudad.HeaderText = "Ciudad";
            this.DescripcionCiudad.Name = "DescripcionCiudad";
            this.DescripcionCiudad.ReadOnly = true;
            this.DescripcionCiudad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "IdProvincia";
            this.IdProvincia.HeaderText = "Provincia Id";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Visible = false;
            // 
            // DescripcionProvincia
            // 
            this.DescripcionProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionProvincia.DataPropertyName = "DescripcionProvincia";
            this.DescripcionProvincia.HeaderText = "Provincia";
            this.DescripcionProvincia.Name = "DescripcionProvincia";
            this.DescripcionProvincia.ReadOnly = true;
            this.DescripcionProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdPais
            // 
            this.IdPais.DataPropertyName = "IdPais";
            this.IdPais.HeaderText = "País Id";
            this.IdPais.Name = "IdPais";
            this.IdPais.ReadOnly = true;
            this.IdPais.Visible = false;
            // 
            // DescripcionPais
            // 
            this.DescripcionPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionPais.DataPropertyName = "DescripcionPais";
            this.DescripcionPais.HeaderText = "Pais";
            this.DescripcionPais.Name = "DescripcionPais";
            this.DescripcionPais.ReadOnly = true;
            this.DescripcionPais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(292, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(558, 16);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(195, 50);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // SelectorLocalidadesForm
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 448);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridLocalidades);
            this.Controls.Add(this.lblPaisTxt);
            this.Controls.Add(this.lblProvinciaTxt);
            this.Controls.Add(this.lblCiudadTxt);
            this.Controls.Add(this.txtDescPais);
            this.Controls.Add(this.txtDescProvincia);
            this.Controls.Add(this.txtDescCiudad);
            this.Name = "SelectorLocalidadesForm";
            this.Text = "SelectorLocalidad";
            ((System.ComponentModel.ISupportInitialize)(this.gridLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescCiudad;
        private System.Windows.Forms.TextBox txtDescProvincia;
        private System.Windows.Forms.TextBox txtDescPais;
        private System.Windows.Forms.Label lblCiudadTxt;
        private System.Windows.Forms.Label lblProvinciaTxt;
        private System.Windows.Forms.Label lblPaisTxt;
        private System.Windows.Forms.DataGridView gridLocalidades;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPais;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}