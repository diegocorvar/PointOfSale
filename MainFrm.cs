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
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
