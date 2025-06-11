using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Karaoke_PopRock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //Untuk set button login jadi transparan/tidak terlihat
            btnMasuk.FlatStyle = FlatStyle.Flat;
            btnMasuk.FlatAppearance.BorderSize = 0;
            btnMasuk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMasuk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMasuk.BackColor = Color.Transparent;
        }

        private String AuthenticateUser(string username, string password)
        {
            string connectionString = "Server=.;Database=Db_karaoke_poprock;User Id=Wyzord;Password=wyzord2006;";
            string role = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_AuthenticateUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Add the OUTPUT parameter
                SqlParameter roleParam = new SqlParameter("@role", SqlDbType.NVarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(roleParam);

                conn.Open();
                cmd.ExecuteNonQuery();

                // Get the value from the output parameter
                if (roleParam.Value != DBNull.Value)
                {
                    role = roleParam.Value.ToString();
                }
            }

            return role;
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string username = tfUsername.Text.Trim();
            string password = tfPassword.Text.Trim();

            string role = AuthenticateUser(username, password);
            if (role != null)
            {
                MessageBox.Show("Login berhasil!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "Admin")
                {
                    //new AdminDashboard().Show();
                }
                else if (role == "Kasir")
                {
                    new Kasir().Show();
                }

                this.Hide();
            }

            else if (string.IsNullOrEmpty(tfUsername.Text) && string.IsNullOrEmpty(tfPassword.Text))
            {
                MessageBox.Show("Input tidak boleh kosong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrEmpty(tfUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ( string.IsNullOrEmpty(tfPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (username != "@username" || password != "@password")
            {
                MessageBox.Show("Username atau password yang dimasukkan salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
