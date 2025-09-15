using System;
using System.Data;
using System.Windows.Forms;

namespace CatatanKeuangan
{
    public partial class Form1 : Form
    {
        private DataTable dtCatatan;
        private decimal saldo = 0;

        public Form1()
        {
            InitializeComponent();
            InitDataTable();
        }

        private void InitDataTable()
        {
            dtCatatan = new DataTable();
            dtCatatan.Columns.Add("Deskripsi");
            dtCatatan.Columns.Add("Jumlah", typeof(decimal));
            dtCatatan.Columns.Add("Jenis");

            dgvCatatan.DataSource = dtCatatan;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeskripsi.Text) || string.IsNullOrWhiteSpace(txtJumlah.Text) || cmbJenis.SelectedIndex < 0)
            {
                MessageBox.Show("Isi semua data terlebih dahulu!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah))
            {
                MessageBox.Show("Jumlah harus berupa angka!");
                return;
            }

            string deskripsi = txtDeskripsi.Text;
            string jenis = cmbJenis.SelectedItem.ToString();

            dtCatatan.Rows.Add(deskripsi, jumlah, jenis);

            if (jenis == "Pemasukan")
                saldo += jumlah;
            else
                saldo -= jumlah;

            lblSaldo.Text = $"Saldo: {saldo:C}";

            txtDeskripsi.Clear();
            txtJumlah.Clear();
            cmbJenis.SelectedIndex = -1;
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
