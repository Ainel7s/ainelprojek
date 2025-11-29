using System;
using System.Windows.Forms;
using System.Data; // Jangan lupa ini

namespace ainelprojek // Sesuaikan dengan namespace kamu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Cek apakah textbox kosong
            if (usn.Text == "" || pw.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Siapkan Query SQL
                // Ganti 'TabelUser' dengan nama tabel aslimu (misal: users, admin, petugas)
                string query = string.Format("SELECT * FROM Users WHERE username = '{0}' AND password = '{1}'",
                                             usn.Text, pw.Text);

                // 3. Panggil DbHelper untuk eksekusi query
                DataTable dt = DbHelper.ExecuteQuery(query);

                // 4. Cek apakah ada data yang ditemukan (baris > 0)
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka Form Utama (frmMain)
                    frmMain mainForm = new frmMain();
                    mainForm.Show();

                    // Sembunyikan Form Login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}