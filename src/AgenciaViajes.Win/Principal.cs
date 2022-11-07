using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //METODOS----------------------------------------------------------->

        private Form activeForm = null;
        private void AbrirForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pnlMain.Controls.Add(form);
            pnlMain.Tag = form;
            form.Show();
        }

        //EVENTOS----------------------------------------------------------->

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form frmClientes = new Clientes();
            AbrirForm(frmClientes);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new Dashboard();
            AbrirForm(frmDashboard);

        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Form frmPaquetes = new Paquetes();
            AbrirForm(frmPaquetes);

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Form frmFacturas = new Facturas();
            AbrirForm(frmFacturas);
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
