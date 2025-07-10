using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using PuntoDeVenta.Helpers;

namespace PuntoDeVenta.Forms
{
    public partial class LoginFrm: Form
    {
        public LoginFrm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txtUser.Text;
            password = txtPassword.Text;

            using (var connection = ConexionDB.GetConnection())
            {
                connection.Open();
                string query = "SELECT Name FROM Users WHERE User = @user AND Password = @password";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string userName = result.ToString();
                        MessageBox.Show($"Bienvenido, {userName}");

                        // Open main form
                        this.Hide();
                        MainFrm mainfrm = new MainFrm();
                        mainfrm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
