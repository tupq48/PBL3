namespace GUI
{
    partial class GUI_Pet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Pet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdThuCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 86);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(784, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(395, 30);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(21, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 68);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm thú cưng";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AllowUserToAddRows = false;
            this.dgvThuCung.AllowUserToResizeColumns = false;
            this.dgvThuCung.AllowUserToResizeRows = false;
            this.dgvThuCung.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvThuCung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuCung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuCung.ColumnHeadersHeight = 30;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThuCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IdThuCung,
            this.IdLoai,
            this.TenGiong,
            this.SoLuongConLai,
            this.GiaBan,
            this.MoTa,
            this.IdNhaCungCap,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuCung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuCung.EnableHeadersVisualStyles = false;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 86);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.RowHeadersVisible = false;
            this.dgvThuCung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvThuCung.RowTemplate.Height = 35;
            this.dgvThuCung.Size = new System.Drawing.Size(1208, 454);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Visible = false;
            this.No.Width = 50;
            // 
            // IdThuCung
            // 
            this.IdThuCung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdThuCung.DataPropertyName = "IdThuCung";
            this.IdThuCung.HeaderText = "Id Thú cưng";
            this.IdThuCung.MinimumWidth = 6;
            this.IdThuCung.Name = "IdThuCung";
            // 
            // IdLoai
            // 
            this.IdLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdLoai.DataPropertyName = "IdLoai";
            this.IdLoai.HeaderText = "Id Loại thú cưng";
            this.IdLoai.MinimumWidth = 6;
            this.IdLoai.Name = "IdLoai";
            // 
            // TenGiong
            // 
            this.TenGiong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGiong.DataPropertyName = "TenGiong";
            this.TenGiong.HeaderText = "Tên giống";
            this.TenGiong.MinimumWidth = 6;
            this.TenGiong.Name = "TenGiong";
            // 
            // SoLuongConLai
            // 
            this.SoLuongConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongConLai.DataPropertyName = "SoLuongConLai";
            this.SoLuongConLai.HeaderText = "Số lượng còn lại";
            this.SoLuongConLai.MinimumWidth = 6;
            this.SoLuongConLai.Name = "SoLuongConLai";
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // IdNhaCungCap
            // 
            this.IdNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdNhaCungCap.DataPropertyName = "IdNhaCungCap";
            this.IdNhaCungCap.HeaderText = "Id Nhà cung cấp";
            this.IdNhaCungCap.MinimumWidth = 6;
            this.IdNhaCungCap.Name = "IdNhaCungCap";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Visible = false;
            this.Delete.Width = 6;
            // 
            // GUI_Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 540);
            this.Controls.Add(this.dgvThuCung);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Pet";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.GUI_Pet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        public DataGridView dgvThuCung;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn IdThuCung;
        private DataGridViewTextBoxColumn IdLoai;
        private DataGridViewTextBoxColumn TenGiong;
        private DataGridViewTextBoxColumn SoLuongConLai;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn IdNhaCungCap;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}