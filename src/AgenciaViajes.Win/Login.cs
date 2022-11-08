using AgenciaViajes.Negocio.Seguridad;
using System;
using System.Windows.Forms;

namespace AgenciaViajes.Win
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

#if DEBUG
            txtUsuario.Text = "admin";
            txtContrasenia.Text = "admin123";
#endif
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Valido el formulario
            if (Validar())
            {
                // Valido si el usuario y contraseña son correctos
                if (SeguridadLogica.ValidarUsuario(txtUsuario.Text, txtContrasenia.Text))
                {
                    // Marco resultado Exitoso, y cierro formulario
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Valida que los campos sean correctos
        /// </summary>
        /// <returns>Verdadero si los campos son correctos</returns>
        public bool Validar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Funcionalidad aún no implementada.\nConsulte con el Administrador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
