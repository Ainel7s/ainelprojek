using System;
using System.Windows.Forms;
using System.Data; // Jangan lupa ini
using System.Data.SqlClient; // Untuk SqlConnection dan SqlCommand

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

            string query = "SELECT * FROM Users WHERE username = @user AND password = @pass";

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", usn.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", pw.Text); // consider hashing in future

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            // login success: read user info or proceed
                            MessageBox.Show("Login berhasil.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Buka Form Utama (frmMain)
                            frmMain mainForm = new frmMain();
                            mainForm.UserLogin = usn.Text;
                            mainForm.Show();

                            // Sembunyikan Form Login
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal proses login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spw_CheckedChanged(object sender, EventArgs e)
        {
            if (spw.Checked)
            {
                pw.UseSystemPasswordChar = false;
            }
            else
            {
                pw.UseSystemPasswordChar = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}