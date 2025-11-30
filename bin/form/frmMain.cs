using ainelprojek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ainelprojek
{
    public partial class frmMain : Form
    {
        public string UserLogin { get; set; }
        private Form ActiveForm = null;
        private bool IsMenuCollapsed = true;
        private const int WIDTH_COLLAPSED = 70;
        private const int WIDTH_EXPANDED = 201;



        public frmMain()
        {

            InitializeComponent();
        
        }
        private void OpenChildForm(Form ChildForm, string title)
        {
                if (ActiveForm != null)
                ActiveForm.Close();


            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.AutoScroll = true;


            panel3.Controls.Clear();
            panel3.Controls.Add(ChildForm);
            panel3.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

            pagename.Text = title;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pagename.Text = "Hallo, " + UserLogin;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSiswa(),"Siswa"); 
        
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // close any opened child form and return to dashboard
            if (ActiveForm != null)
            {
                try
                {
                    ActiveForm.Close();
                }
                catch { /* ignore close errors */ }
                ActiveForm = null;
            }

            // clear panel and show dashboard title
            panel3.Controls.Clear();
            pagename.Text = "Dashboard";
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();


            // Tutup dashboard
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
