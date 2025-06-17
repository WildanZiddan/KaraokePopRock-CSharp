using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeKaryawan
{
    public partial class TambahKaryawancs: Form
    {
        public TambahKaryawancs()
        {
            InitializeComponent();
        }

        private bool validasiBoxKosong()
        {
            return string.IsNullOrEmpty(txtNamaKaryawan.Text) || string.IsNullOrEmpty(txtNoTelpon.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(cmbRole.Text);
        }

        private void clear()
        {
            txtNamaKaryawan.Text = "";
            txtNoTelpon.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasiBoxKosong())
            {
                MessageBox.Show("Seluruh Kotak Wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string connectionString = "integrated security = true; data source=astratech; initial catalog = Db_karaoke_poprock";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_createKaryawan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nama_karyawan", txtNamaKaryawan.Text);
                    cmd.Parameters.AddWithValue("@notelp_karyawan", txtNoTelpon.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    int berhasil = cmd.ExecuteNonQuery();
                    if (berhasil != 0)
                    {
                        MessageBox.Show("Data berhasil Disimpan", "Berhasil", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                    //ResetData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

    }
}
