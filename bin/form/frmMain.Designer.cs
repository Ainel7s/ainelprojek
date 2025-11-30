namespace ainelprojek
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnDash = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pagename = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.iconButton7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.BarsStaggered;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 35;
            this.iconButton7.Location = new System.Drawing.Point(118, 30);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(56, 50);
            this.iconButton7.TabIndex = 2;
            this.iconButton7.Tag = "menu";
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 35;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 407);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(200, 43);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Tag = "signout";
            this.iconButton6.Text = "Sign Out";
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 229);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(200, 43);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Tag = "matapelajaran";
            this.iconButton5.Text = "Mata Pelajaran";
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 186);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(200, 43);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Tag = "nilai";
            this.iconButton4.Text = "Nilai";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 143);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(200, 43);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Tag = "siswa";
            this.iconButton3.Text = "Siswa";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDash.IconColor = System.Drawing.Color.Black;
            this.btnDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDash.IconSize = 35;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(0, 100);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(200, 43);
            this.btnDash.TabIndex = 1;
            this.btnDash.Tag = "dashboard";
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel2.Controls.Add(this.pagename);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pagename
            // 
            this.pagename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagename.AutoSize = true;
            this.pagename.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagename.Location = new System.Drawing.Point(3, 0);
            this.pagename.Name = "pagename";
            this.pagename.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.pagename.Size = new System.Drawing.Size(0, 62);
            this.pagename.TabIndex = 0;
            this.pagename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagename.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 350);
            this.panel3.TabIndex = 3;
            this.panel3.Tag = "Sign Out";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnDash;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pagename;
        private System.Windows.Forms.Panel panel3;
    }
}

