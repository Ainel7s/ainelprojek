namespace ainelprojek
{
    partial class frmSiswa
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
            this.gbdn = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncl = new FontAwesome.Sharp.IconButton();
            this.btnup = new FontAwesome.Sharp.IconButton();
            this.btninsert = new FontAwesome.Sharp.IconButton();
            this.tbmean = new System.Windows.Forms.TextBox();
            this.tbNL = new System.Windows.Forms.TextBox();
            this.tbNISN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndel = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnsrch = new FontAwesome.Sharp.IconButton();
            this.cbkls = new System.Windows.Forms.ComboBox();
            this.cbj = new System.Windows.Forms.ComboBox();
            this.cbakh = new System.Windows.Forms.ComboBox();
            this.gbdn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdn
            // 
            this.gbdn.Controls.Add(this.cbakh);
            this.gbdn.Controls.Add(this.cbj);
            this.gbdn.Controls.Add(this.cbkls);
            this.gbdn.Controls.Add(this.panel1);
            this.gbdn.Controls.Add(this.tbmean);
            this.gbdn.Controls.Add(this.tbNL);
            this.gbdn.Controls.Add(this.tbNISN);
            this.gbdn.Controls.Add(this.label7);
            this.gbdn.Controls.Add(this.label6);
            this.gbdn.Controls.Add(this.label5);
            this.gbdn.Controls.Add(this.label4);
            this.gbdn.Controls.Add(this.label3);
            this.gbdn.Controls.Add(this.label2);
            this.gbdn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdn.Location = new System.Drawing.Point(0, 0);
            this.gbdn.Name = "gbdn";
            this.gbdn.Size = new System.Drawing.Size(800, 338);
            this.gbdn.TabIndex = 2;
            this.gbdn.TabStop = false;
            this.gbdn.Text = "Data Nilai";
            this.gbdn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btncl);
            this.panel1.Controls.Add(this.btnup);
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 43);
            this.panel1.TabIndex = 3;
            // 
            // btncl
            // 
            this.btncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncl.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btncl.IconColor = System.Drawing.Color.Black;
            this.btncl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncl.IconSize = 20;
            this.btncl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncl.Location = new System.Drawing.Point(336, 13);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(75, 23);
            this.btncl.TabIndex = 2;
            this.btncl.Text = "clear";
            this.btncl.UseVisualStyleBackColor = true;
            // 
            // btnup
            // 
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnup.IconColor = System.Drawing.Color.Black;
            this.btnup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnup.IconSize = 20;
            this.btnup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnup.Location = new System.Drawing.Point(203, 13);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 1;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click_1);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btninsert.IconColor = System.Drawing.Color.Black;
            this.btninsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninsert.IconSize = 20;
            this.btninsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsert.Location = new System.Drawing.Point(73, 13);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // tbmean
            // 
            this.tbmean.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbmean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmean.Location = new System.Drawing.Point(140, 237);
            this.tbmean.Name = "tbmean";
            this.tbmean.Size = new System.Drawing.Size(257, 23);
            this.tbmean.TabIndex = 14;
            // 
            // tbNL
            // 
            this.tbNL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNL.Location = new System.Drawing.Point(140, 88);
            this.tbNL.Name = "tbNL";
            this.tbNL.Size = new System.Drawing.Size(259, 23);
            this.tbNL.TabIndex = 10;
            // 
            // tbNISN
            // 
            this.tbNISN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNISN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNISN.Location = new System.Drawing.Point(140, 49);
            this.tbNISN.Name = "tbNISN";
            this.tbNISN.Size = new System.Drawing.Size(257, 23);
            this.tbNISN.TabIndex = 9;
            this.tbNISN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Rata-rata Nilai :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nilai Akhlak :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jurusan :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kelas :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Lengkap :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NISN :";
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btndel.IconColor = System.Drawing.Color.Black;
            this.btndel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndel.IconSize = 20;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(713, 151);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsrch);
            this.panel2.Controls.Add(this.tbsearch);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 411);
            this.panel2.TabIndex = 4;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(3, 151);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(270, 20);
            this.tbsearch.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 177);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(800, 234);
            this.dgv.TabIndex = 0;
            // 
            // btnsrch
            // 
            this.btnsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnsrch.IconColor = System.Drawing.Color.Black;
            this.btnsrch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsrch.IconSize = 16;
            this.btnsrch.Location = new System.Drawing.Point(265, 151);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(24, 20);
            this.btnsrch.TabIndex = 3;
            this.btnsrch.UseVisualStyleBackColor = true;
            // 
            // cbkls
            // 
            this.cbkls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkls.FormattingEnabled = true;
            this.cbkls.Location = new System.Drawing.Point(140, 125);
            this.cbkls.Name = "cbkls";
            this.cbkls.Size = new System.Drawing.Size(121, 24);
            this.cbkls.TabIndex = 15;
            // 
            // cbj
            // 
            this.cbj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbj.FormattingEnabled = true;
            this.cbj.Location = new System.Drawing.Point(140, 161);
            this.cbj.Name = "cbj";
            this.cbj.Size = new System.Drawing.Size(121, 24);
            this.cbj.TabIndex = 16;
            // 
            // cbakh
            // 
            this.cbakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbakh.FormattingEnabled = true;
            this.cbakh.Location = new System.Drawing.Point(140, 197);
            this.cbakh.Name = "cbakh";
            this.cbakh.Size = new System.Drawing.Size(121, 24);
            this.cbakh.TabIndex = 17;
            // 
            // frmSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbdn);
            this.Name = "frmSiswa";
            this.Text = "frmSiswa";
            this.gbdn.ResumeLayout(false);
            this.gbdn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbdn;
        private System.Windows.Forms.TextBox tbNISN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNL;
        private System.Windows.Forms.TextBox tbmean;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btndel;
        private FontAwesome.Sharp.IconButton btnup;
        private FontAwesome.Sharp.IconButton btninsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton btncl;
        private System.Windows.Forms.TextBox tbsearch;
        private FontAwesome.Sharp.IconButton btnsrch;
        private System.Windows.Forms.ComboBox cbakh;
        private System.Windows.Forms.ComboBox cbj;
        private System.Windows.Forms.ComboBox cbkls;
    }
}