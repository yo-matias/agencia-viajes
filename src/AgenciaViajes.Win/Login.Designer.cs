
namespace AgenciaViajes.Win
{
    partial class Login
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            this.panelCredenciales = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.panelCredenciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.imgInicio);
            this.panelLogo.Location = new System.Drawing.Point(0, -1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(393, 374);
            this.panelLogo.TabIndex = 0;
            // 
            // imgInicio
            // 
            this.imgInicio.ErrorImage = null;
            this.imgInicio.Image = global::AgenciaViajes.Win.Properties.Resources.logo;
            this.imgInicio.InitialImage = null;
            this.imgInicio.Location = new System.Drawing.Point(0, 3);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(393, 371);
            this.imgInicio.TabIndex = 0;
            this.imgInicio.TabStop = false;
            // 
            // panelCredenciales
            // 
            this.panelCredenciales.Controls.Add(this.btnSalir);
            this.panelCredenciales.Controls.Add(this.lblRegistrarse);
            this.panelCredenciales.Controls.Add(this.btnIngresar);
            this.panelCredenciales.Controls.Add(this.txtContrasenia);
            this.panelCredenciales.Controls.Add(this.txtUsuario);
            this.panelCredenciales.Controls.Add(this.lblContrasenia);
            this.panelCredenciales.Controls.Add(this.lblUsuario);
            this.panelCredenciales.Controls.Add(this.pictureBoxUsuario);
            this.panelCredenciales.Location = new System.Drawing.Point(397, 1);
            this.panelCredenciales.Name = "panelCredenciales";
            this.panelCredenciales.Size = new System.Drawing.Size(378, 372);
            this.panelCredenciales.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(335, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 27);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRegistrarse.Location = new System.Drawing.Point(122, 319);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(150, 16);
            this.lblRegistrarse.TabIndex = 6;
            this.lblRegistrarse.TabStop = true;
            this.lblRegistrarse.Text = "¿No estas registrado?";
            this.lblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRegistrarse_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresar.Location = new System.Drawing.Point(147, 276);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 30);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(125, 232);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(131, 20);
            this.txtContrasenia.TabIndex = 4;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(125, 193);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.lblContrasenia.Location = new System.Drawing.Point(36, 232);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(82, 16);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuario.Location = new System.Drawing.Point(63, 193);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::AgenciaViajes.Win.Properties.Resources.usuario;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(125, 27);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(131, 132);
            this.pictureBoxUsuario.TabIndex = 0;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 375);
            this.ControlBox = false;
            this.Controls.Add(this.panelCredenciales);
            this.Controls.Add(this.panelLogo);
            this.Name = "Login";
            this.ShowIcon = false;
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.panelCredenciales.ResumeLayout(false);
            this.panelCredenciales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imgInicio;
        private System.Windows.Forms.Panel panelCredenciales;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblRegistrarse;
        private System.Windows.Forms.Button btnSalir;
    }
}