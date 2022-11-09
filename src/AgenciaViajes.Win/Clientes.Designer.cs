
namespace AgenciaViajes.Win
{
    partial class Clientes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxAltaCliente = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.comboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDeDocumentoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.tipoDeClienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.provinciaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCalleNro = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.comboPais = new System.Windows.Forms.ComboBox();
            this.paisModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCalleNro = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboNacionalidad = new System.Windows.Forms.ComboBox();
            this.nacionalidadModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxAltaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDeDocumentoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDeClienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(257, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CLIENTES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(641, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 27);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre :";
            // 
            // gbxAltaCliente
            // 
            this.gbxAltaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxAltaCliente.Controls.Add(this.btnCancelar);
            this.gbxAltaCliente.Controls.Add(this.btnAgregar);
            this.gbxAltaCliente.Controls.Add(this.lblPais);
            this.gbxAltaCliente.Controls.Add(this.lblProvincia);
            this.gbxAltaCliente.Controls.Add(this.comboTipoDocumento);
            this.gbxAltaCliente.Controls.Add(this.comboTipoCliente);
            this.gbxAltaCliente.Controls.Add(this.comboNacionalidad);
            this.gbxAltaCliente.Controls.Add(this.comboCiudad);
            this.gbxAltaCliente.Controls.Add(this.comboProvincia);
            this.gbxAltaCliente.Controls.Add(this.txtCUIT);
            this.gbxAltaCliente.Controls.Add(this.txtDNI);
            this.gbxAltaCliente.Controls.Add(this.lblTipoDocumento);
            this.gbxAltaCliente.Controls.Add(this.lblTipoCliente);
            this.gbxAltaCliente.Controls.Add(this.lblCUIT);
            this.gbxAltaCliente.Controls.Add(this.txtTelefono);
            this.gbxAltaCliente.Controls.Add(this.txtCalleNro);
            this.gbxAltaCliente.Controls.Add(this.txtCalle);
            this.gbxAltaCliente.Controls.Add(this.comboPais);
            this.gbxAltaCliente.Controls.Add(this.txtRazonSocial);
            this.gbxAltaCliente.Controls.Add(this.txtApellido);
            this.gbxAltaCliente.Controls.Add(this.txtNombre);
            this.gbxAltaCliente.Controls.Add(this.lblDNI);
            this.gbxAltaCliente.Controls.Add(this.label10);
            this.gbxAltaCliente.Controls.Add(this.lblTelefono);
            this.gbxAltaCliente.Controls.Add(this.lblCalleNro);
            this.gbxAltaCliente.Controls.Add(this.lblCalle);
            this.gbxAltaCliente.Controls.Add(this.lblCiudad);
            this.gbxAltaCliente.Controls.Add(this.lblNacionalidad);
            this.gbxAltaCliente.Controls.Add(this.lblRazonSocial);
            this.gbxAltaCliente.Controls.Add(this.lblApellido);
            this.gbxAltaCliente.Controls.Add(this.lblNombre);
            this.gbxAltaCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAltaCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbxAltaCliente.Location = new System.Drawing.Point(71, 68);
            this.gbxAltaCliente.Name = "gbxAltaCliente";
            this.gbxAltaCliente.Size = new System.Drawing.Size(543, 271);
            this.gbxAltaCliente.TabIndex = 10;
            this.gbxAltaCliente.TabStop = false;
            this.gbxAltaCliente.Text = "Datos del Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(417, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 30);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(314, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 30);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.Color.DimGray;
            this.lblPais.Location = new System.Drawing.Point(329, 50);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(44, 16);
            this.lblPais.TabIndex = 35;
            this.lblPais.Text = "País :";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.Color.DimGray;
            this.lblProvincia.Location = new System.Drawing.Point(297, 80);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(77, 16);
            this.lblProvincia.TabIndex = 34;
            this.lblProvincia.Text = "Provincia :";
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.DataSource = this.tipoDeDocumentoModelBindingSource;
            this.comboTipoDocumento.DisplayMember = "DescripcionTipoDocumento";
            this.comboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Location = new System.Drawing.Point(127, 221);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(131, 24);
            this.comboTipoDocumento.TabIndex = 33;
            this.comboTipoDocumento.ValueMember = "IdTipoDocumento";
            this.comboTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.ComboCiudad_SelectionChangeCommitted);
            // 
            // tipoDeDocumentoModelBindingSource
            // 
            this.tipoDeDocumentoModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.TipoDeDocumentoModel);
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.DataSource = this.tipoDeClienteModelBindingSource;
            this.comboTipoCliente.DisplayMember = "DescripcionTipoCliente";
            this.comboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Location = new System.Drawing.Point(127, 17);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(131, 24);
            this.comboTipoCliente.TabIndex = 33;
            this.comboTipoCliente.ValueMember = "IdTipoCliente";
            this.comboTipoCliente.SelectionChangeCommitted += new System.EventHandler(this.ComboCiudad_SelectionChangeCommitted);
            // 
            // tipoDeClienteModelBindingSource
            // 
            this.tipoDeClienteModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.TipoDeClienteModel);
            // 
            // comboCiudad
            // 
            this.comboCiudad.DataSource = this.ciudadModelBindingSource;
            this.comboCiudad.DisplayMember = "Ciudad";
            this.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Location = new System.Drawing.Point(381, 107);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(131, 24);
            this.comboCiudad.TabIndex = 33;
            this.comboCiudad.ValueMember = "IdCiudad";
            this.comboCiudad.SelectionChangeCommitted += new System.EventHandler(this.ComboCiudad_SelectionChangeCommitted);
            // 
            // ciudadModelBindingSource
            // 
            this.ciudadModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.CiudadModel);
            // 
            // comboProvincia
            // 
            this.comboProvincia.DataSource = this.provinciaModelBindingSource;
            this.comboProvincia.DisplayMember = "Provincia";
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(381, 77);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(131, 24);
            this.comboProvincia.TabIndex = 32;
            this.comboProvincia.ValueMember = "IdProvincia";
            this.comboProvincia.SelectionChangeCommitted += new System.EventHandler(this.ComboProvincia_SelectionChangeCommitted);
            // 
            // provinciaModelBindingSource
            // 
            this.provinciaModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.ProvinciaModel);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(127, 192);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(131, 23);
            this.txtCUIT.TabIndex = 31;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(127, 163);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(131, 23);
            this.txtDNI.TabIndex = 30;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipoDocumento.Location = new System.Drawing.Point(20, 224);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(92, 16);
            this.lblTipoDocumento.TabIndex = 29;
            this.lblTipoDocumento.Text = "Documento :";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipoCliente.Location = new System.Drawing.Point(20, 20);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(46, 16);
            this.lblTipoCliente.TabIndex = 29;
            this.lblTipoCliente.Text = "Tipo :";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.ForeColor = System.Drawing.Color.DimGray;
            this.lblCUIT.Location = new System.Drawing.Point(20, 195);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(50, 16);
            this.lblCUIT.TabIndex = 29;
            this.lblCUIT.Text = "CUIT :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(127, 134);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 23);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtCalleNro
            // 
            this.txtCalleNro.Location = new System.Drawing.Point(381, 166);
            this.txtCalleNro.Name = "txtCalleNro";
            this.txtCalleNro.Size = new System.Drawing.Size(131, 23);
            this.txtCalleNro.TabIndex = 24;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(381, 137);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 23);
            this.txtCalle.TabIndex = 23;
            // 
            // comboPais
            // 
            this.comboPais.DataSource = this.paisModelBindingSource;
            this.comboPais.DisplayMember = "Pais";
            this.comboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPais.FormattingEnabled = true;
            this.comboPais.Location = new System.Drawing.Point(381, 47);
            this.comboPais.Name = "comboPais";
            this.comboPais.Size = new System.Drawing.Size(131, 24);
            this.comboPais.TabIndex = 22;
            this.comboPais.ValueMember = "IdPais";
            this.comboPais.SelectionChangeCommitted += new System.EventHandler(this.ComboPais_SelectionChangeCommitted);
            // 
            // paisModelBindingSource
            // 
            this.paisModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.PaisModel);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(127, 105);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(131, 23);
            this.txtRazonSocial.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(127, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(131, 23);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 23);
            this.txtNombre.TabIndex = 19;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.Color.DimGray;
            this.lblDNI.Location = new System.Drawing.Point(20, 166);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 16);
            this.lblDNI.TabIndex = 18;
            this.lblDNI.Text = "DNI :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(20, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefono.Location = new System.Drawing.Point(20, 137);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 16);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // lblCalleNro
            // 
            this.lblCalleNro.AutoSize = true;
            this.lblCalleNro.ForeColor = System.Drawing.Color.DimGray;
            this.lblCalleNro.Location = new System.Drawing.Point(317, 169);
            this.lblCalleNro.Name = "lblCalleNro";
            this.lblCalleNro.Size = new System.Drawing.Size(57, 16);
            this.lblCalleNro.TabIndex = 15;
            this.lblCalleNro.Text = "Altura :";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.ForeColor = System.Drawing.Color.DimGray;
            this.lblCalle.Location = new System.Drawing.Point(325, 140);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(49, 16);
            this.lblCalle.TabIndex = 14;
            this.lblCalle.Text = "Calle :";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCiudad.Location = new System.Drawing.Point(311, 110);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(62, 16);
            this.lblCiudad.TabIndex = 13;
            this.lblCiudad.Text = "Ciudad :";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.ForeColor = System.Drawing.Color.DimGray;
            this.lblNacionalidad.Location = new System.Drawing.Point(273, 198);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(100, 16);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad :";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.ForeColor = System.Drawing.Color.DimGray;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 108);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(101, 16);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Razón Social :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(20, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 16);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido :";
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.ELIMINAR});
            this.gridClientes.Location = new System.Drawing.Point(74, 383);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(539, 204);
            this.gridClientes.TabIndex = 11;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "";
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseColumnTextForButtonValue = true;
            // 
            // comboNacionalidad
            // 
            this.comboNacionalidad.DataSource = this.nacionalidadModelBindingSource;
            this.comboNacionalidad.DisplayMember = "Gentilicio";
            this.comboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNacionalidad.FormattingEnabled = true;
            this.comboNacionalidad.Location = new System.Drawing.Point(379, 195);
            this.comboNacionalidad.Name = "comboNacionalidad";
            this.comboNacionalidad.Size = new System.Drawing.Size(131, 24);
            this.comboNacionalidad.TabIndex = 33;
            this.comboNacionalidad.ValueMember = "IdPais";
            this.comboNacionalidad.SelectionChangeCommitted += new System.EventHandler(this.ComboCiudad_SelectionChangeCommitted);
            // 
            // nacionalidadModelBindingSource
            // 
            this.nacionalidadModelBindingSource.DataSource = typeof(AgenciaViajes.Dominio.PaisModel);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 610);
            this.ControlBox = false;
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.gbxAltaCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Clientes";
            this.gbxAltaCliente.ResumeLayout(false);
            this.gbxAltaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDeDocumentoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDeClienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxAltaCliente;
        private System.Windows.Forms.ComboBox comboPais;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCalleNro;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCalleNro;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ELIMINAR;
        private System.Windows.Forms.BindingSource ciudadModelBindingSource;
        private System.Windows.Forms.BindingSource provinciaModelBindingSource;
        private System.Windows.Forms.BindingSource paisModelBindingSource;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private System.Windows.Forms.BindingSource tipoDeClienteModelBindingSource;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox comboTipoDocumento;
        private System.Windows.Forms.BindingSource tipoDeDocumentoModelBindingSource;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox comboNacionalidad;
        private System.Windows.Forms.BindingSource nacionalidadModelBindingSource;
    }
}