namespace GUI
{
    partial class GUI_ThuCung
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butReset = new System.Windows.Forms.Button();
            this.cboLoaiThuCung = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.but_Sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.but_Them = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongConLai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenGiong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdThuCung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butReset);
            this.groupBox1.Controls.Add(this.cboLoaiThuCung);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.but_Xoa);
            this.groupBox1.Controls.Add(this.cboNhaCungCap);
            this.groupBox1.Controls.Add(this.but_Sua);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.but_Them);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSoLuongConLai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenGiong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdThuCung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thú cưng";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(165, 300);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(200, 27);
            this.txtMota.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mô tả";
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butReset.Location = new System.Drawing.Point(292, 474);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(73, 29);
            this.butReset.TabIndex = 11;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // cboLoaiThuCung
            // 
            this.cboLoaiThuCung.FormattingEnabled = true;
            this.cboLoaiThuCung.Location = new System.Drawing.Point(165, 95);
            this.cboLoaiThuCung.Name = "cboLoaiThuCung";
            this.cboLoaiThuCung.Size = new System.Drawing.Size(200, 28);
            this.cboLoaiThuCung.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 12;
            // 
            // but_Xoa
            // 
            this.but_Xoa.AutoSize = true;
            this.but_Xoa.CausesValidation = false;
            this.but_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Xoa.Location = new System.Drawing.Point(197, 471);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(73, 32);
            this.but_Xoa.TabIndex = 5;
            this.but_Xoa.Text = "Xoá";
            this.but_Xoa.UseVisualStyleBackColor = true;
            this.but_Xoa.Click += new System.EventHandler(this.but_Xoa_Click);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(165, 349);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(200, 28);
            this.cboNhaCungCap.TabIndex = 11;
            // 
            // but_Sua
            // 
            this.but_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Sua.Location = new System.Drawing.Point(105, 474);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(73, 29);
            this.but_Sua.TabIndex = 4;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // but_Them
            // 
            this.but_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_Them.Location = new System.Drawing.Point(6, 474);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(73, 29);
            this.but_Them.TabIndex = 3;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(165, 255);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 27);
            this.txtGiaBan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá bán";
            // 
            // txtSoLuongConLai
            // 
            this.txtSoLuongConLai.Location = new System.Drawing.Point(165, 199);
            this.txtSoLuongConLai.Name = "txtSoLuongConLai";
            this.txtSoLuongConLai.Size = new System.Drawing.Size(200, 27);
            this.txtSoLuongConLai.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng còn lại";
            // 
            // txtTenGiong
            // 
            this.txtTenGiong.Location = new System.Drawing.Point(165, 142);
            this.txtTenGiong.Name = "txtTenGiong";
            this.txtTenGiong.Size = new System.Drawing.Size(200, 27);
            this.txtTenGiong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên giống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã loại thú cưng";
            // 
            // txtIdThuCung
            // 
            this.txtIdThuCung.Location = new System.Drawing.Point(165, 44);
            this.txtIdThuCung.Name = "txtIdThuCung";
            this.txtIdThuCung.Size = new System.Drawing.Size(200, 27);
            this.txtIdThuCung.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thú cưng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvThuCung);
            this.groupBox2.Location = new System.Drawing.Point(403, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị toàn bộ thông tin thú cưng";
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvThuCung.Location = new System.Drawing.Point(-1, 32);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.RowHeadersWidth = 51;
            this.dgvThuCung.RowTemplate.Height = 29;
            this.dgvThuCung.Size = new System.Drawing.Size(988, 422);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdThuCung";
            this.Column1.HeaderText = "Mã thú cưng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdLoai";
            this.Column2.HeaderText = "Mã loại thú cưng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenGiong";
            this.Column3.HeaderText = "Tên giống";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongConLai";
            this.Column4.HeaderText = "Số lượng còn lại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaBan";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MoTa";
            this.Column6.HeaderText = "Mô tả";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "IdNhaCungCap";
            this.Column7.HeaderText = "Mã nhà cung cấp";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(891, 27);
            this.txtTimKiem.TabIndex = 7;
            // 
            // butTimKiem
            // 
            this.butTimKiem.Location = new System.Drawing.Point(895, 26);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(100, 27);
            this.butTimKiem.TabIndex = 9;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = true;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(403, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 65);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // GUI_ThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 571);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_ThuCung";
            this.Text = "Quản lý thú cưng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtIdThuCung;
        private Label label2;
        private Label label3;
        private Label label7;
        private TextBox txtGiaBan;
        private Label label6;
        private TextBox txtSoLuongConLai;
        private Label label5;
        private TextBox txtTenGiong;
        private Label label4;
        private Label label8;
        private DataGridView dgvThuCung;
        private Button but_Them;
        private Button but_Sua;
        private Button but_Xoa;
        private ColorDialog colorDialog1;
        private TextBox txtTimKiem;
        private Button butTimKiem;
        private GroupBox groupBox3;
        private ComboBox cboNhaCungCap;
        private ComboBox cboLoaiThuCung;
        private Button butReset;
        private TextBox txtMota;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}