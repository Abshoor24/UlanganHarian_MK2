namespace CatatanKeuangan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDeskripsi = new TextBox();
            txtJumlah = new TextBox();
            cmbJenis = new ComboBox();
            btnTambah = new Button();
            dgvCatatan = new DataGridView();
            lblSaldo = new Label();
            groupInput = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCatatan).BeginInit();
            groupInput.SuspendLayout();
            SuspendLayout();
  
            txtDeskripsi.Location = new Point(25, 41);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.PlaceholderText = "Deskripsi";
            txtDeskripsi.Size = new Size(200, 30);
            txtDeskripsi.TabIndex = 0;

            txtJumlah.Location = new Point(240, 40);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.PlaceholderText = "Jumlah";
            txtJumlah.Size = new Size(126, 30);
            txtJumlah.TabIndex = 1;
            txtJumlah.TextAlign = HorizontalAlignment.Right;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
  
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Pemasukan", "Pengeluaran" });
            cmbJenis.Location = new Point(381, 39);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(121, 31);
            cmbJenis.TabIndex = 2;

            btnTambah.BackColor = Color.LightGreen;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Location = new Point(526, 40);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(90, 32);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "➕ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;

            dgvCatatan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatatan.BackgroundColor = Color.WhiteSmoke;
            dgvCatatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatatan.Location = new Point(12, 130);
            dgvCatatan.Name = "dgvCatatan";
            dgvCatatan.RowHeadersWidth = 51;
            dgvCatatan.RowTemplate.Height = 25;
            dgvCatatan.Size = new Size(760, 280);
            dgvCatatan.TabIndex = 4;
   
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.DarkBlue;
            lblSaldo.Location = new Point(12, 420);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(136, 32);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo: Rp0";
  
            groupInput.BackColor = Color.AliceBlue;
            groupInput.Controls.Add(txtDeskripsi);
            groupInput.Controls.Add(txtJumlah);
            groupInput.Controls.Add(cmbJenis);
            groupInput.Controls.Add(btnTambah);
            groupInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupInput.Location = new Point(12, 12);
            groupInput.Name = "groupInput";
            groupInput.Size = new Size(726, 100);
            groupInput.TabIndex = 6;
            groupInput.TabStop = false;
            groupInput.Text = "Input Catatan";

            ClientSize = new Size(800, 470);
            Controls.Add(lblSaldo);
            Controls.Add(dgvCatatan);
            Controls.Add(groupInput);
            Name = "Form1";
            Text = "💰 Catatan Keuangan";
            ((System.ComponentModel.ISupportInitialize)dgvCatatan).EndInit();
            groupInput.ResumeLayout(false);
            groupInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgvCatatan;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox groupInput;
    }
}
