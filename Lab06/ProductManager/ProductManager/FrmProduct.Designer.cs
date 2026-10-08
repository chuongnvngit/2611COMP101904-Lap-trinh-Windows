namespace ProductManager
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmsProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSua = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.msMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiupInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLamMoi = new System.Windows.Forms.ToolStripButton();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsProduct.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1406, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cmsProduct
            // 
            this.cmsProduct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsXoa,
            this.cmsSua,
            this.cmsChiTiet});
            this.cmsProduct.Name = "contextMenuStrip1";
            this.cmsProduct.Size = new System.Drawing.Size(158, 76);
            this.cmsProduct.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProduct_Opening);
            // 
            // cmsXoa
            // 
            this.cmsXoa.Name = "cmsXoa";
            this.cmsXoa.Size = new System.Drawing.Size(157, 24);
            this.cmsXoa.Text = "Xóa";
            this.cmsXoa.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cmsSua
            // 
            this.cmsSua.Name = "cmsSua";
            this.cmsSua.Size = new System.Drawing.Size(157, 24);
            this.cmsSua.Text = "Sửa";
            // 
            // cmsChiTiet
            // 
            this.cmsChiTiet.Name = "cmsChiTiet";
            this.cmsChiTiet.Size = new System.Drawing.Size(157, 24);
            this.cmsChiTiet.Text = "Xem chi tiết";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMain,
            this.quảnLýToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1406, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // msMain
            // 
            this.msMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(46, 24);
            this.msMain.Text = "File";
            this.msMain.Click += new System.EventHandler(this.msMain_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(116, 26);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyThem,
            this.mnuQuanLySua,
            this.mnuQuanLyXoa,
            this.mnuQuanLyLamMoi});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuQuanLyThem
            // 
            this.mnuQuanLyThem.Name = "mnuQuanLyThem";
            this.mnuQuanLyThem.Size = new System.Drawing.Size(150, 26);
            this.mnuQuanLyThem.Text = "Thêm";
            this.mnuQuanLyThem.Click += new System.EventHandler(this.mnuQuanLyThem_Click);
            // 
            // mnuQuanLySua
            // 
            this.mnuQuanLySua.Name = "mnuQuanLySua";
            this.mnuQuanLySua.Size = new System.Drawing.Size(150, 26);
            this.mnuQuanLySua.Text = "Sửa";
            this.mnuQuanLySua.Click += new System.EventHandler(this.mnuQuanLySua_Click);
            // 
            // mnuQuanLyXoa
            // 
            this.mnuQuanLyXoa.Name = "mnuQuanLyXoa";
            this.mnuQuanLyXoa.Size = new System.Drawing.Size(150, 26);
            this.mnuQuanLyXoa.Text = "Xóa";
            this.mnuQuanLyXoa.Click += new System.EventHandler(this.mnuQuanLyXoa_Click);
            // 
            // mnuQuanLyLamMoi
            // 
            this.mnuQuanLyLamMoi.Name = "mnuQuanLyLamMoi";
            this.mnuQuanLyLamMoi.Size = new System.Drawing.Size(150, 26);
            this.mnuQuanLyLamMoi.Text = "Làm mới";
            this.mnuQuanLyLamMoi.Click += new System.EventHandler(this.mnuQuanLyLamMoi_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTroGiupInfo});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // mnuTroGiupInfo
            // 
            this.mnuTroGiupInfo.Name = "mnuTroGiupInfo";
            this.mnuTroGiupInfo.Size = new System.Drawing.Size(155, 26);
            this.mnuTroGiupInfo.Text = "Thông tin";
            this.mnuTroGiupInfo.Click += new System.EventHandler(this.mnuTroGiupInfo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLamMoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1406, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbThem
            // 
            this.tsbThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThem.Image = ((System.Drawing.Image)(resources.GetObject("tsbThem.Image")));
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(29, 24);
            this.tsbThem.Text = "Them";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click_1);
            // 
            // tsbSua
            // 
            this.tsbSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSua.Image = ((System.Drawing.Image)(resources.GetObject("tsbSua.Image")));
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(29, 24);
            this.tsbSua.Text = "Sua";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(29, 24);
            this.tsbXoa.Text = "Xoa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click_1);
            // 
            // tsbLamMoi
            // 
            this.tsbLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsbLamMoi.Image")));
            this.tsbLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLamMoi.Name = "tsbLamMoi";
            this.tsbLamMoi.Size = new System.Drawing.Size(29, 24);
            this.tsbLamMoi.Text = "Lam moi";
            this.tsbLamMoi.Click += new System.EventHandler(this.tsbLamMoi_Click_1);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnLamMoi);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.btnChonAnh);
            this.gbThongTin.Controls.Add(this.picSanPham);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.chkConKinhDoanh);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.numDonGia);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.dtpNgayNhap);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.numSoLuong);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.cboLoaiSP);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.txtTenSP);
            this.gbThongTin.Controls.Add(this.txtMaSP);
            this.gbThongTin.Location = new System.Drawing.Point(12, 101);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(476, 350);
            this.gbThongTin.TabIndex = 4;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sản phẩm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(338, 241);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 169);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(338, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(338, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(338, 300);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 15;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(82, 274);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(231, 70);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 14;
            this.picSanPham.TabStop = false;
            this.picSanPham.Click += new System.EventHandler(this.picSanPham_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // chkConKinhDoanh
            // 
            this.chkConKinhDoanh.AutoSize = true;
            this.chkConKinhDoanh.Location = new System.Drawing.Point(92, 248);
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Size = new System.Drawing.Size(121, 20);
            this.chkConKinhDoanh.TabIndex = 12;
            this.chkConKinhDoanh.Text = "Còn kinh doanh";
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;
            this.chkConKinhDoanh.CheckedChanged += new System.EventHandler(this.chkConKinhDoanh_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đơn giá";
            // 
            // numDonGia
            // 
            this.numDonGia.Location = new System.Drawing.Point(92, 170);
            this.numDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(120, 22);
            this.numDonGia.TabIndex = 10;
            this.numDonGia.ValueChanged += new System.EventHandler(this.numDonGia_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(99, 220);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.TabIndex = 8;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(92, 142);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 6;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOẠI SP";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(91, 99);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 24);
            this.cboLoaiSP.TabIndex = 4;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÊN SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÃ SP";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(91, 62);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(121, 22);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(91, 34);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(121, 22);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(640, 112);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(185, 22);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(559, 112);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(559, 174);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(818, 297);
            this.dgvProducts.TabIndex = 21;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 520);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1406, 26);
            this.ssStatus.TabIndex = 22;
            this.ssStatus.Text = "statusStrip1";
            this.ssStatus.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssStatus_ItemClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 20);
            this.lblStatus.Text = "Sẵn sàng";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1406, 546);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FrmProduct_Load_1);
            this.cmsProduct.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip cmsProduct;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyThem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLySua;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyXoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyLamMoi;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiupInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbLamMoi;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ToolStripMenuItem cmsXoa;
        private System.Windows.Forms.ToolStripMenuItem cmsSua;
        private System.Windows.Forms.ToolStripMenuItem cmsChiTiet;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

