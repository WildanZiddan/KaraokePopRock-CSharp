namespace KaraokeKaryawan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunatxtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnbKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.db_karaoke_poprockDataSet = new KaraokeKaryawan.Db_karaoke_poprockDataSet();
            this.masterkaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_karyawanTableAdapter = new KaraokeKaryawan.Db_karaoke_poprockDataSetTableAdapters.master_karyawanTableAdapter();
            this.idkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpkaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_karaoke_poprockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterkaryawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(59, 674);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(63, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // gbSearch
            // 
            this.gbSearch.BorderColor = System.Drawing.Color.Silver;
            this.gbSearch.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.gbSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.gbSearch.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.Color.White;
            this.gbSearch.Location = new System.Drawing.Point(441, 232);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(188, 50);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.Text = "Tambah Data";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this.gbSearch;
            // 
            // gunatxtCari
            // 
            this.gunatxtCari.BackColor = System.Drawing.Color.Transparent;
            this.gunatxtCari.BorderColor = System.Drawing.Color.Transparent;
            this.gunatxtCari.BorderThickness = 0;
            this.gunatxtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunatxtCari.DefaultText = "";
            this.gunatxtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunatxtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunatxtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunatxtCari.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.gunatxtCari.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunatxtCari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.gunatxtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunatxtCari.Location = new System.Drawing.Point(681, 232);
            this.gunatxtCari.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gunatxtCari.Name = "gunatxtCari";
            this.gunatxtCari.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.gunatxtCari.PlaceholderText = "Cari. . .";
            this.gunatxtCari.SelectedText = "";
            this.gunatxtCari.Size = new System.Drawing.Size(360, 50);
            this.gunatxtCari.TabIndex = 2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.gunatxtCari;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderThickness = 0;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(1250, 239);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(143, 36);
            this.guna2ComboBox1.TabIndex = 3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 40;
            this.guna2Elipse3.TargetControl = this.guna2ComboBox1;
            // 
            // gnbKaryawan
            // 
            this.gnbKaryawan.CustomBorderColor = System.Drawing.Color.White;
            this.gnbKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbKaryawan.FillColor = System.Drawing.Color.White;
            this.gnbKaryawan.FocusedColor = System.Drawing.Color.White;
            this.gnbKaryawan.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbKaryawan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            this.gnbKaryawan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnbKaryawan.Location = new System.Drawing.Point(0, 649);
            this.gnbKaryawan.Name = "gnbKaryawan";
            this.gnbKaryawan.Size = new System.Drawing.Size(400, 122);
            this.gnbKaryawan.TabIndex = 4;
            this.gnbKaryawan.Text = "       Karyawan";
            this.gnbKaryawan.Click += new System.EventHandler(this.gnbKaryawan_Click);
            // 
            // dgvKaryawan
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKaryawan.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvKaryawan.ColumnHeadersHeight = 30;
            this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkaryawanDataGridViewTextBoxColumn,
            this.namakaryawanDataGridViewTextBoxColumn,
            this.notelpkaryawanDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvKaryawan.DataSource = this.masterkaryawanBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKaryawan.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKaryawan.GridColor = System.Drawing.Color.White;
            this.dgvKaryawan.Location = new System.Drawing.Point(435, 315);
            this.dgvKaryawan.Name = "dgvKaryawan";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(50)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKaryawan.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvKaryawan.RowHeadersVisible = false;
            this.dgvKaryawan.RowHeadersWidth = 51;
            this.dgvKaryawan.RowTemplate.Height = 24;
            this.dgvKaryawan.Size = new System.Drawing.Size(982, 645);
            this.dgvKaryawan.TabIndex = 6;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKaryawan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKaryawan.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvKaryawan.ThemeStyle.ReadOnly = false;
            this.dgvKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKaryawan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKaryawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKaryawan_CellContentClick);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 40;
            this.guna2Elipse4.TargetControl = this.dgvKaryawan;
            // 
            // db_karaoke_poprockDataSet
            // 
            this.db_karaoke_poprockDataSet.DataSetName = "Db_karaoke_poprockDataSet";
            this.db_karaoke_poprockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterkaryawanBindingSource
            // 
            this.masterkaryawanBindingSource.DataMember = "master_karyawan";
            this.masterkaryawanBindingSource.DataSource = this.db_karaoke_poprockDataSet;
            // 
            // master_karyawanTableAdapter
            // 
            this.master_karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // idkaryawanDataGridViewTextBoxColumn
            // 
            this.idkaryawanDataGridViewTextBoxColumn.DataPropertyName = "id_karyawan";
            this.idkaryawanDataGridViewTextBoxColumn.HeaderText = "id_karyawan";
            this.idkaryawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkaryawanDataGridViewTextBoxColumn.Name = "idkaryawanDataGridViewTextBoxColumn";
            this.idkaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namakaryawanDataGridViewTextBoxColumn
            // 
            this.namakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan";
            this.namakaryawanDataGridViewTextBoxColumn.HeaderText = "nama_karyawan";
            this.namakaryawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namakaryawanDataGridViewTextBoxColumn.Name = "namakaryawanDataGridViewTextBoxColumn";
            // 
            // notelpkaryawanDataGridViewTextBoxColumn
            // 
            this.notelpkaryawanDataGridViewTextBoxColumn.DataPropertyName = "notelp_karyawan";
            this.notelpkaryawanDataGridViewTextBoxColumn.HeaderText = "notelp_karyawan";
            this.notelpkaryawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpkaryawanDataGridViewTextBoxColumn.Name = "notelpkaryawanDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKaryawan);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.gnbKaryawan);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.gunatxtCari);
            this.Controls.Add(this.gbSearch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_karaoke_poprockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterkaryawanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button gbSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox gunatxtCari;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button gnbKaryawan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKaryawan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Db_karaoke_poprockDataSet db_karaoke_poprockDataSet;
        private System.Windows.Forms.BindingSource masterkaryawanBindingSource;
        private Db_karaoke_poprockDataSetTableAdapters.master_karyawanTableAdapter master_karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpkaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

