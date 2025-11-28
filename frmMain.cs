using ainelprojek.form;
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
        private Form ActiveForm = null;
        private bool IsMenuCollapsed = true;
        private const int WIDTH_COLLAPSED = 70;
        private const int WIDTH_EXPANDED = 201;



        public frmMain()
        {

            InitializeComponent();
        }
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();


            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(ChildForm);
            panel3.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            pagename.Text = ChildForm.Tag != null ?
                ChildForm.Tag.ToString().ToUpper() : "Form Not Found";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }
    }
}
