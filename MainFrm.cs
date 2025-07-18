using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class MainFrm: Form
    {
        public MainFrm()
        {
            InitializeComponent();

            // this closes all open forms by clicking on the x button at the top right
            this.FormClosing += MainFrm_FormClosing;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.None;
            btnExit.BackColor = Color.FromArgb(218, 13, 75);
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult exitConfirmation = MessageBox.Show(
                    "¿Seguro que quieres salir del punto de venta?",
                    "Saliendo del Punto de Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (exitConfirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
