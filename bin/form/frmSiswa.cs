using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ainelprojek
{
    public partial class frmSiswa : Form
    {
        private string idSiswa = "";
        private readonly AutoCompleteStringCollection _searchAutoComplete = new AutoCompleteStringCollection();
        private readonly HashSet<string> _searchHistory = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            private const string SearchPlaceholder = "Search";

        public frmSiswa()
        {
            InitializeComponent();

            // prevent manual typing in comboboxes
            tbsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbsearch.AutoCompleteCustomSource = _searchAutoComplete;

            this.AutoScroll = true;
            try
            {
                int contentHeight = 0;
                if (gbdn != null) contentHeight += gbdn.Height;
                if (panel2 != null) contentHeight += panel2.Height;
                // Add a small margin so controls aren't clipped
                this.AutoScrollMinSize = new Size(0, contentHeight + 20);
            }
            catch
            {
                // ignore if designer fields not available yet
                this.AutoScrollMinSize = new Size(0, 800);
            }

            // wire events
            Load += FrmSiswa_Load;
            btninsert.Click += Btninsert_Click;
            btnup.Click += Btnup_Click;
            btndel.Click += Btndel_Click;
            btncl.Click += Btncl_Click;
            btnsrch.Click += Btnsrch_Click;
            dgv.CellClick += Dgv_CellClick;
            tbsearch.KeyDown += Tbsearch_KeyDown;
            tbsearch.GotFocus += Tbsearch_GotFocus;
            tbsearch.LostFocus += Tbsearch_LostFocus;
        }

        private void FrmSiswa_Load(object sender, EventArgs e)
        {
            TampilData();
            PopulateComboBoxes();
            InitializeSearchPlaceholder();
        }

        private void TampilData()
        {
            try
            {
                string query = "SELECT * FROM Siswa";
                DataTable dt = DbHelper.ExecuteQuery(query);
                dgv.DataSource = dt;
                dgv.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboBoxes()
        {
            try
            {
                var kelasSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var jurusanSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var akhlakSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    // kelas
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT kelas FROM Siswa WHERE kelas IS NOT NULL", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            var v = r.IsDBNull(0) ? string.Empty : r.GetString(0).Trim();
                            if (!string.IsNullOrEmpty(v)) kelasSet.Add(v);
                        }
                    }

                    // jurusan
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT jurusan FROM Siswa WHERE jurusan IS NOT NULL", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            var v = r.IsDBNull(0) ? string.Empty : r.GetString(0).Trim();
                            if (!string.IsNullOrEmpty(v)) jurusanSet.Add(v);
                        }
                    }

                    // nilai_akhlak
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT nilai_akhlak FROM Siswa WHERE nilai_akhlak IS NOT NULL", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            var v = r.IsDBNull(0) ? string.Empty : r.GetValue(0)?.ToString().Trim();
                            if (!string.IsNullOrEmpty(v)) akhlakSet.Add(v);
                        }
                    }
                }

                // populate comboboxes with ordered normalized values
                var kelasItems = kelasSet.OrderBy(x => x).ToArray();
                var jurusanItems = jurusanSet.OrderBy(x => x).ToArray();
                var akhlakItems = akhlakSet.OrderBy(x => x).ToArray();

                cbkls.Items.Clear();
                if (kelasItems.Length > 0)
                    cbkls.Items.AddRange(kelasItems);
                else
                    cbkls.Items.AddRange(new object[] { "10", "11", "12" });

                cbj.Items.Clear();
                if (jurusanItems.Length > 0)
                    cbj.Items.AddRange(jurusanItems);
                else
                    cbj.Items.AddRange(new object[] { "PPLG", "MPLB", "TJKT", "DKV", "AK" });

                cbakh.Items.Clear();
                if (akhlakItems.Length > 0)
                    cbakh.Items.AddRange(akhlakItems);
                else
                    cbakh.Items.AddRange(new object[] { "A", "B", "C", "D" });

                // immediately show the first item if present
                if (cbkls.Items.Count > 0) cbkls.SelectedIndex = 0;
                if (cbj.Items.Count > 0) cbj.SelectedIndex = 0;
                if (cbakh.Items.Count > 0) cbakh.SelectedIndex = 0;
            }
            catch
            {
                // keep defaults if DB fails
                if (cbkls.Items.Count == 0) cbkls.Items.AddRange(new object[] { "10", "11", "12" });
                if (cbj.Items.Count == 0) cbj.Items.AddRange(new object[] { "PPLG", "MPLB", "TJKT", "DKV", "AK" });
                if (cbakh.Items.Count == 0) cbakh.Items.AddRange(new object[] { "A", "B", "C", "D" });

                if (cbkls.Items.Count > 0) cbkls.SelectedIndex = 0;
                if (cbj.Items.Count > 0) cbj.SelectedIndex = 0;
                if (cbakh.Items.Count > 0) cbakh.SelectedIndex = 0;
            }
        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            // validation: ensure required fields are present
            var missing = new List<string>();
            if (string.IsNullOrWhiteSpace(tbNISN.Text)) missing.Add("NISN");
            if (string.IsNullOrWhiteSpace(tbNL.Text)) missing.Add("Nama Lengkap");
            if (string.IsNullOrWhiteSpace(cbkls.Text)) missing.Add("Kelas");
            if (string.IsNullOrWhiteSpace(cbj.Text)) missing.Add("Jurusan");
            if (string.IsNullOrWhiteSpace(cbakh.Text)) missing.Add("Nilai Akhlak");
            if (string.IsNullOrWhiteSpace(tbmean.Text)) missing.Add("Rata-rata Nilai");

            if (missing.Count > 0)
            {
                MessageBox.Show("Tidak dapat menyimpan. Field kosong: " + string.Join(", ", missing),
                                "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validate numeric rata-rata before insert (prevents crash when user types non-number)
            if (!decimal.TryParse(tbmean.Text.Trim(), out decimal rataNilai))
            {
                MessageBox.Show("Rata-rata nilai harus berupa angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmean.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Siswa (nisn, nama, kelas, jurusan, nilai_akhlak, rata_nilai)
                                        VALUES (@nisn, @nama, @kelas, @jurusan, @nilai_akhlak, @rata_nilai)";
                    cmd.Parameters.AddWithValue("@nisn", tbNISN.Text.Trim());
                    cmd.Parameters.AddWithValue("@nama", tbNL.Text.Trim());
                    cmd.Parameters.AddWithValue("@kelas", cbkls.Text.Trim());
                    cmd.Parameters.AddWithValue("@jurusan", cbj.Text.Trim());
                    cmd.Parameters.AddWithValue("@nilai_akhlak", cbakh.Text.Trim());
                    // use the parsed decimal value for rata_nilai
                    cmd.Parameters.AddWithValue("@rata_nilai", rataNilai);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Data berhasil ditambahkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // clear only the specified textboxes after successful insert
                        tbNISN.Text = string.Empty;
                        tbNL.Text = string.Empty;
                        tbmean.Text = string.Empty;
                        tbNISN.Focus();

                        TampilData();
                        PopulateComboBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data yang ditambahkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNISN.Text))
            {
                MessageBox.Show("Pilih baris yang akan diubah.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // new value user entered
            var newNisn = tbNISN.Text.Trim();

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // if the grid contains an 'Id' column we use Id as the WHERE key,
                    // otherwise we use the original nisn stored in idSiswa.
                    if (ColumnExists(null, "Id"))
                    {
                        cmd.CommandText = @"UPDATE Siswa
                                            SET nisn = @newnisn,
                                                nama = @nama,
                                                kelas = @kelas,
                                                jurusan = @jurusan,
                                                nilai_akhlak = @nilai_akhlak,
                                                rata_nilai = @rata_nilai
                                            WHERE Id = @id";
                        cmd.Parameters.AddWithValue("@id", idSiswa ?? string.Empty);
                    }
                    else
                    {
                        cmd.CommandText = @"UPDATE Siswa
                                            SET nisn = @newnisn,
                                                nama = @nama,
                                                kelas = @kelas,
                                                jurusan = @jurusan,
                                                nilai_akhlak = @nilai_akhlak,
                                                rata_nilai = @rata_nilai
                                            WHERE nisn = @orignisn";
                        // idSiswa holds the original nisn when there's no Id column
                        cmd.Parameters.AddWithValue("@orignisn", idSiswa ?? string.Empty);
                    }

                    cmd.Parameters.AddWithValue("@newnisn", newNisn );
                    cmd.Parameters.AddWithValue("@nama", tbNL.Text.Trim());
                    cmd.Parameters.AddWithValue("@kelas", cbkls.Text.Trim());
                    cmd.Parameters.AddWithValue("@jurusan", cbj.Text.Trim());
                    cmd.Parameters.AddWithValue("@nilai_akhlak", cbakh.Text.Trim());
                    cmd.Parameters.AddWithValue("@rata_nilai", tbmean.Text.Trim());
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Data berhasil diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        TampilData();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada baris yang diupdate. Pastikan nisn benar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNISN.Text))
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Siswa WHERE nisn = @nisn";
                    cmd.Parameters.AddWithValue("@nisn", tbNISN.Text.Trim());
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        TampilData();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada baris yang dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btncl_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            idSiswa = "";
            tbNISN.Text = "";
            tbNL.Text = "";
            cbkls.SelectedIndex = -1;
            cbj.SelectedIndex = -1;
            cbakh.SelectedIndex = -1;
            tbmean.Text = "";
           
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            try
            {
                tbNISN.Text = GetCellValueSafe(row, "nisn") ?? row.Cells[0].Value?.ToString();
                tbNL.Text = GetCellValueSafe(row, "nama");
                cbkls.Text = GetCellValueSafe(row, "kelas");
                cbj.Text = GetCellValueSafe(row, "jurusan");
                cbakh.Text = GetCellValueSafe(row, "nilai_akhlak");
                tbmean.Text = GetCellValueSafe(row, "rata_nilai");

                if (ColumnExists(row, "Id"))
                {
                    idSiswa = GetCellValueSafe(row, "Id");
                }
                else
                {
                    idSiswa = tbNISN.Text;
                }
            }
            catch { /* ignore mapping errors */ }
        }

        private string GetCellValueSafe(DataGridViewRow row, string columnName)
        {
            if (dgv.Columns.Contains(columnName) && row.Cells[columnName].Value != null)
                return row.Cells[columnName].Value.ToString();
            return string.Empty;
        }

        private void Btnsrch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void Tbsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearch();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DoSearch()
        {
            string q = tbsearch.Text.Trim();
            if (string.IsNullOrEmpty(q) || string.Equals(q, SearchPlaceholder, StringComparison.OrdinalIgnoreCase))
            {
                TampilData();
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT * FROM Siswa
                        WHERE CAST(nisn AS VARCHAR(100)) LIKE @q
                           OR nama LIKE @q
                           OR kelas LIKE @q
                           OR jurusan LIKE @q
                           OR CAST(rata_nilai AS VARCHAR(100)) LIKE @q
                           OR nilai_akhlak LIKE @q
                    ";
                    cmd.Parameters.AddWithValue("@q", "%" + q + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                }

                // add to autocomplete / history and keep most-recent-first
                if (!string.IsNullOrWhiteSpace(q))
                {
                    if (_searchHistory.Contains(q))
                    {
                        // move existing entry to top
                        _searchAutoComplete.Remove(q);
                        _searchAutoComplete.Insert(0, q);
                    }
                    else
                    {
                        _searchHistory.Add(q);
                        _searchAutoComplete.Insert(0, q);
                    }

                    // optional: limit history size (e.g., 50)
                    const int maxHistory = 50;
                    while (_searchAutoComplete.Count > maxHistory)
                    {
                        var last = _searchAutoComplete[_searchAutoComplete.Count - 1];
                        _searchAutoComplete.Remove(last);
                        _searchHistory.Remove(last);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Empty event handlers generated by Designer - keep them to avoid compile errors
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void iconButton4_Click(object sender, EventArgs e) { }

        private void cbkls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ColumnExists(DataGridViewRow row, string columnName)
        {
            // defensive checks
            if (string.IsNullOrWhiteSpace(columnName) || dgv == null)
                return false;

            // check by column Name (case-insensitive)
            return dgv.Columns
                      .Cast<DataGridViewColumn>()
                      .Any(c => string.Equals(c.Name, columnName, StringComparison.OrdinalIgnoreCase));
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            // Contoh perbaikan di Btninsert_Click
            decimal nilaiCheck;
            if (!decimal.TryParse(tbmean.Text, out nilaiCheck))
            {
                MessageBox.Show("Rata-rata nilai harus berupa angka!", "Validasi");
                return;
            }
        }

        private void btnup_Click_1(object sender, EventArgs e)
        {

        }

        private void InitializeSearchPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(tbsearch.Text))
            {
                tbsearch.ForeColor = SystemColors.GrayText;
                tbsearch.Text = SearchPlaceholder;
            }
        }

        private void Tbsearch_GotFocus(object sender, EventArgs e)
        {
            if (string.Equals(tbsearch.Text, SearchPlaceholder, StringComparison.OrdinalIgnoreCase))
            {
                tbsearch.Text = string.Empty;
                tbsearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void Tbsearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbsearch.Text))
            {
                tbsearch.ForeColor = SystemColors.GrayText;
                tbsearch.Text = SearchPlaceholder;
            }
        }
    }
}
