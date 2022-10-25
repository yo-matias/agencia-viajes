using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes.Win.General
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            // Posición inicial -> Centro de pantalla
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void SplashForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
