using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke_PopRock
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_karaoke_poprockDataSet.master_karyawan' table. You can move, or remove it, as needed.
            //this.master_karyawanTableAdapter.Fill(this.db_karaoke_poprockDataSet.master_karyawan);

        }

        private void gnbKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gbSearch_Click(object sender, EventArgs e)
        {
            new TambahKaryawancs().Show();
        }
    }
}
