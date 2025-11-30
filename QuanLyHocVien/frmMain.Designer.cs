namespace QuanLyHocVien
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
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
            this.dsSource2 = new QuanLyHocVien.Reports.dsSource();
            this.dsSource1 = new QuanLyHocVien.Reports.dsSource();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.lblServerName = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Button();
            this.lblCenterName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnThongTinPhanMem = new System.Windows.Forms.Button();
            this.btnTrangMoDau = new System.Windows.Forms.Button();
            this.pnlTabTitle = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanTriTitle = new System.Windows.Forms.Button();
            this.btnHocVienTitle = new System.Windows.Forms.Button();
            this.btnGiangVienTitle = new System.Windows.Forms.Button();
            this.btnNhanVienTitle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabRibbon = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.btnThayDoiThongTinNV = new System.Windows.Forms.Button();
            this.btnNVDoiMatKhau = new System.Windows.Forms.Button();
            this.btnXepLop = new System.Windows.Forms.Button();
            this.btnThongKeDiemTheoLop = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnThongKeNoHocVien = new System.Windows.Forms.Button();
            this.btnBaoCaoHocVienTheoThang = new System.Windows.Forms.Button();
            this.btnLapPhieuGhiDanh = new System.Windows.Forms.Button();
            this.btnTiepNhanHocVien = new System.Windows.Forms.Button();
            this.tabGiangVien = new System.Windows.Forms.TabPage();
            this.btnXemCacLopDay = new System.Windows.Forms.Button();
            this.btnGVThayDoiThongTin = new System.Windows.Forms.Button();
            this.btnGVDoiMatKhau = new System.Windows.Forms.Button();
            this.tabHocVien = new System.Windows.Forms.TabPage();
            this.btnHVThayDoiThongTin = new System.Windows.Forms.Button();
            this.btnHVDoiMatKhau = new System.Windows.Forms.Button();
            this.btnHocPhi = new System.Windows.Forms.Button();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.tabQuanTri = new System.Windows.Forms.TabPage();
            this.btnKetNoiCSDL = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinh = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyHocPhi = new System.Windows.Forms.Button();
            this.btnQuanLyKhoaHoc = new System.Windows.Forms.Button();
            this.btnQuanLyLopHoc = new System.Windows.Forms.Button();
            this.btnQuanLyGiangVien = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyHocVien = new System.Windows.Forms.Button();
            this.tabTroGiup = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlTabTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabRibbon.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabGiangVien.SuspendLayout();
            this.tabHocVien.SuspendLayout();
            this.tabQuanTri.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSource2
            // 
            this.dsSource2.DataSetName = "dsSource";
            this.dsSource2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSource1
            // 
            this.dsSource1.DataSetName = "dsSource";
            this.dsSource1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace.Location = new System.Drawing.Point(0, 93);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(1215, 458);
            this.pnlWorkspace.TabIndex = 4;
            // 
            // lblServerName
            // 
            this.lblServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerName.FlatAppearance.BorderSize = 0;
            this.lblServerName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.lblServerName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.lblServerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblServerName.ForeColor = System.Drawing.Color.White;
            this.lblServerName.Image = global::QuanLyHocVien.Properties.Resources.icon_Server_16dp;
            this.lblServerName.Location = new System.Drawing.Point(798, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(210, 24);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "<server name>";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServerName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblServerName.UseVisualStyleBackColor = true;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.FlatAppearance.BorderSize = 0;
            this.lblDateTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.lblDateTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.lblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Image = global::QuanLyHocVien.Properties.Resources.icon_Time_16dp;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Location = new System.Drawing.Point(1014, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(179, 24);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "dd/MM/yyyy HH:mm:ss tt";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblDateTime.UseVisualStyleBackColor = true;
            // 
            // lblCenterName
            // 
            this.lblCenterName.AutoSize = true;
            this.lblCenterName.ForeColor = System.Drawing.Color.White;
            this.lblCenterName.Location = new System.Drawing.Point(7, 5);
            this.lblCenterName.Name = "lblCenterName";
            this.lblCenterName.Size = new System.Drawing.Size(111, 20);
            this.lblCenterName.TabIndex = 3;
            this.lblCenterName.Text = "<center name>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.lblCenterName);
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Controls.Add(this.lblServerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 24);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 5);
            this.panel3.TabIndex = 2;
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Location = new System.Drawing.Point(0, 0);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(75, 23);
            this.btnTroGiup.TabIndex = 0;
            // 
            // btnThongTinPhanMem
            // 
            this.btnThongTinPhanMem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThongTinPhanMem.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinPhanMem.Name = "btnThongTinPhanMem";
            this.btnThongTinPhanMem.Size = new System.Drawing.Size(75, 23);
            this.btnThongTinPhanMem.TabIndex = 0;
            // 
            // btnTrangMoDau
            // 
            this.btnTrangMoDau.Location = new System.Drawing.Point(0, 0);
            this.btnTrangMoDau.Name = "btnTrangMoDau";
            this.btnTrangMoDau.Size = new System.Drawing.Size(75, 23);
            this.btnTrangMoDau.TabIndex = 0;
            // 
            // pnlTabTitle
            // 
            this.pnlTabTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTabTitle.Controls.Add(this.lblUserName);
            this.pnlTabTitle.Controls.Add(this.btnDangXuat);
            this.pnlTabTitle.Controls.Add(this.btnQuanTriTitle);
            this.pnlTabTitle.Controls.Add(this.btnHocVienTitle);
            this.pnlTabTitle.Controls.Add(this.btnGiangVienTitle);
            this.pnlTabTitle.Controls.Add(this.btnNhanVienTitle);
            this.pnlTabTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTabTitle.Name = "pnlTabTitle";
            this.pnlTabTitle.Size = new System.Drawing.Size(1215, 28);
            this.pnlTabTitle.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Black;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserName.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Yellow;
            this.lblUserName.Location = new System.Drawing.Point(840, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(228, 28);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "<user name>";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gold;
            this.btnDangXuat.Location = new System.Drawing.Point(1068, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(147, 28);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanTriTitle
            // 
            this.btnQuanTriTitle.BackColor = System.Drawing.Color.Black;
            this.btnQuanTriTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanTriTitle.FlatAppearance.BorderSize = 0;
            this.btnQuanTriTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTriTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuanTriTitle.ForeColor = System.Drawing.Color.White;
            this.btnQuanTriTitle.Location = new System.Drawing.Point(303, 0);
            this.btnQuanTriTitle.Name = "btnQuanTriTitle";
            this.btnQuanTriTitle.Size = new System.Drawing.Size(96, 28);
            this.btnQuanTriTitle.TabIndex = 3;
            this.btnQuanTriTitle.Text = "Quản trị";
            this.btnQuanTriTitle.UseVisualStyleBackColor = false;
            this.btnQuanTriTitle.Click += new System.EventHandler(this.btnQuanTriTitle_Click);
            // 
            // btnHocVienTitle
            // 
            this.btnHocVienTitle.BackColor = System.Drawing.Color.Black;
            this.btnHocVienTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHocVienTitle.FlatAppearance.BorderSize = 0;
            this.btnHocVienTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocVienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHocVienTitle.ForeColor = System.Drawing.Color.White;
            this.btnHocVienTitle.Location = new System.Drawing.Point(207, 0);
            this.btnHocVienTitle.Name = "btnHocVienTitle";
            this.btnHocVienTitle.Size = new System.Drawing.Size(96, 28);
            this.btnHocVienTitle.TabIndex = 2;
            this.btnHocVienTitle.Text = "Học viên";
            this.btnHocVienTitle.UseVisualStyleBackColor = false;
            this.btnHocVienTitle.Click += new System.EventHandler(this.btnHocVienTitle_Click);
            // 
            // btnGiangVienTitle
            // 
            this.btnGiangVienTitle.BackColor = System.Drawing.Color.Black;
            this.btnGiangVienTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGiangVienTitle.FlatAppearance.BorderSize = 0;
            this.btnGiangVienTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiangVienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGiangVienTitle.ForeColor = System.Drawing.Color.White;
            this.btnGiangVienTitle.Location = new System.Drawing.Point(96, 0);
            this.btnGiangVienTitle.Name = "btnGiangVienTitle";
            this.btnGiangVienTitle.Size = new System.Drawing.Size(111, 28);
            this.btnGiangVienTitle.TabIndex = 1;
            this.btnGiangVienTitle.Text = "Giảng viên";
            this.btnGiangVienTitle.UseVisualStyleBackColor = false;
            this.btnGiangVienTitle.Click += new System.EventHandler(this.btnGiangVienTitle_Click);
            // 
            // btnNhanVienTitle
            // 
            this.btnNhanVienTitle.BackColor = System.Drawing.Color.White;
            this.btnNhanVienTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVienTitle.FlatAppearance.BorderSize = 0;
            this.btnNhanVienTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhanVienTitle.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVienTitle.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVienTitle.Name = "btnNhanVienTitle";
            this.btnNhanVienTitle.Size = new System.Drawing.Size(96, 28);
            this.btnNhanVienTitle.TabIndex = 0;
            this.btnNhanVienTitle.Text = "Nhân viên";
            this.btnNhanVienTitle.UseVisualStyleBackColor = false;
            this.btnNhanVienTitle.Click += new System.EventHandler(this.btnNhanVienTitle_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.tabRibbon);
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1215, 65);
            this.panel4.TabIndex = 1;
            // 
            // tabRibbon
            // 
            this.tabRibbon.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabRibbon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRibbon.Controls.Add(this.tabNhanVien);
            this.tabRibbon.Controls.Add(this.tabGiangVien);
            this.tabRibbon.Controls.Add(this.tabHocVien);
            this.tabRibbon.Controls.Add(this.tabQuanTri);
            this.tabRibbon.Controls.Add(this.tabTroGiup);
            this.tabRibbon.Location = new System.Drawing.Point(-4, -5);
            this.tabRibbon.Name = "tabRibbon";
            this.tabRibbon.SelectedIndex = 0;
            this.tabRibbon.Size = new System.Drawing.Size(1207, 95);
            this.tabRibbon.TabIndex = 0;
            this.tabRibbon.TabStop = false;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.Black;
            this.tabNhanVien.Controls.Add(this.btnThayDoiThongTinNV);
            this.tabNhanVien.Controls.Add(this.btnNVDoiMatKhau);
            this.tabNhanVien.Controls.Add(this.btnXepLop);
            this.tabNhanVien.Controls.Add(this.btnThongKeDiemTheoLop);
            this.tabNhanVien.Controls.Add(this.btnQuanLyDiem);
            this.tabNhanVien.Controls.Add(this.btnThongKeNoHocVien);
            this.tabNhanVien.Controls.Add(this.btnBaoCaoHocVienTheoThang);
            this.tabNhanVien.Controls.Add(this.btnLapPhieuGhiDanh);
            this.tabNhanVien.Controls.Add(this.btnTiepNhanHocVien);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 4);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1199, 62);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.Click += new System.EventHandler(this.tabNhanVien_Click);
            // 
            // btnThayDoiThongTinNV
            // 
            this.btnThayDoiThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnThayDoiThongTinNV.FlatAppearance.BorderSize = 0;
            this.btnThayDoiThongTinNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiThongTinNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnThayDoiThongTinNV.Image = global::QuanLyHocVien.Properties.Resources.icon_ThayDoiThongTin_32dp;
            this.btnThayDoiThongTinNV.Location = new System.Drawing.Point(1068, 7);
            this.btnThayDoiThongTinNV.Name = "btnThayDoiThongTinNV";
            this.btnThayDoiThongTinNV.Size = new System.Drawing.Size(123, 48);
            this.btnThayDoiThongTinNV.TabIndex = 12;
            this.btnThayDoiThongTinNV.Text = "Thay đổi thông tin";
            this.btnThayDoiThongTinNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThayDoiThongTinNV.UseVisualStyleBackColor = false;
            this.btnThayDoiThongTinNV.Click += new System.EventHandler(this.btnThayDoiThongTinNV_Click);
            // 
            // btnNVDoiMatKhau
            // 
            this.btnNVDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnNVDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnNVDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnNVDoiMatKhau.Image = global::QuanLyHocVien.Properties.Resources.icon_MatKhau_32dp;
            this.btnNVDoiMatKhau.Location = new System.Drawing.Point(943, 7);
            this.btnNVDoiMatKhau.Name = "btnNVDoiMatKhau";
            this.btnNVDoiMatKhau.Size = new System.Drawing.Size(119, 48);
            this.btnNVDoiMatKhau.TabIndex = 11;
            this.btnNVDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnNVDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNVDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnNVDoiMatKhau.Click += new System.EventHandler(this.btnNVDoiMatKhau_Click);
            // 
            // btnXepLop
            // 
            this.btnXepLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnXepLop.FlatAppearance.BorderSize = 0;
            this.btnXepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnXepLop.Image = global::QuanLyHocVien.Properties.Resources.icon_XepLop_32dp;
            this.btnXepLop.Location = new System.Drawing.Point(840, 7);
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.Size = new System.Drawing.Size(97, 48);
            this.btnXepLop.TabIndex = 10;
            this.btnXepLop.Text = "Xếp lớp";
            this.btnXepLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXepLop.UseVisualStyleBackColor = false;
            this.btnXepLop.Click += new System.EventHandler(this.btnXepLop_Click);
            // 
            // btnThongKeDiemTheoLop
            // 
            this.btnThongKeDiemTheoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnThongKeDiemTheoLop.FlatAppearance.BorderSize = 0;
            this.btnThongKeDiemTheoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeDiemTheoLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnThongKeDiemTheoLop.Image = global::QuanLyHocVien.Properties.Resources.icon_XemDiem_32dp;
            this.btnThongKeDiemTheoLop.Location = new System.Drawing.Point(687, 7);
            this.btnThongKeDiemTheoLop.Name = "btnThongKeDiemTheoLop";
            this.btnThongKeDiemTheoLop.Size = new System.Drawing.Size(148, 48);
            this.btnThongKeDiemTheoLop.TabIndex = 9;
            this.btnThongKeDiemTheoLop.Text = "Thống kê điểm theo lớp";
            this.btnThongKeDiemTheoLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeDiemTheoLop.UseVisualStyleBackColor = false;
            this.btnThongKeDiemTheoLop.Click += new System.EventHandler(this.btnThongKeDiemTheoLop_Click);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyDiem.FlatAppearance.BorderSize = 0;
            this.btnQuanLyDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyDiem.Image = global::QuanLyHocVien.Properties.Resources.icon_QuanLyDiem_32dp;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(583, 7);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(100, 48);
            this.btnQuanLyDiem.TabIndex = 8;
            this.btnQuanLyDiem.Text = "Quản lý Điểm";
            this.btnQuanLyDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyDiem.UseVisualStyleBackColor = false;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.btnQuanLyDiem_Click);
            // 
            // btnThongKeNoHocVien
            // 
            this.btnThongKeNoHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnThongKeNoHocVien.FlatAppearance.BorderSize = 0;
            this.btnThongKeNoHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeNoHocVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnThongKeNoHocVien.Image = global::QuanLyHocVien.Properties.Resources.icon_ThongKeHocPhi_32dp;
            this.btnThongKeNoHocVien.Location = new System.Drawing.Point(445, 7);
            this.btnThongKeNoHocVien.Name = "btnThongKeNoHocVien";
            this.btnThongKeNoHocVien.Size = new System.Drawing.Size(134, 48);
            this.btnThongKeNoHocVien.TabIndex = 7;
            this.btnThongKeNoHocVien.Text = "Thống kê nợ học viên";
            this.btnThongKeNoHocVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeNoHocVien.UseVisualStyleBackColor = false;
            this.btnThongKeNoHocVien.Click += new System.EventHandler(this.btnThongKeNoHocVien_Click);
            // 
            // btnBaoCaoHocVienTheoThang
            // 
            this.btnBaoCaoHocVienTheoThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnBaoCaoHocVienTheoThang.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoHocVienTheoThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoHocVienTheoThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnBaoCaoHocVienTheoThang.Image = global::QuanLyHocVien.Properties.Resources.icon_BaoCaoHocVienTheoThang_32dp;
            this.btnBaoCaoHocVienTheoThang.Location = new System.Drawing.Point(256, 7);
            this.btnBaoCaoHocVienTheoThang.Name = "btnBaoCaoHocVienTheoThang";
            this.btnBaoCaoHocVienTheoThang.Size = new System.Drawing.Size(185, 48);
            this.btnBaoCaoHocVienTheoThang.TabIndex = 6;
            this.btnBaoCaoHocVienTheoThang.Text = "Báo cáo học viên ghi danh theo tháng";
            this.btnBaoCaoHocVienTheoThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCaoHocVienTheoThang.UseVisualStyleBackColor = false;
            this.btnBaoCaoHocVienTheoThang.Click += new System.EventHandler(this.btnBaoCaoHocVienTheoThang_Click);
            // 
            // btnLapPhieuGhiDanh
            // 
            this.btnLapPhieuGhiDanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnLapPhieuGhiDanh.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuGhiDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuGhiDanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnLapPhieuGhiDanh.Image = global::QuanLyHocVien.Properties.Resources.icon_LapPhieuGhiDanh_32dp;
            this.btnLapPhieuGhiDanh.Location = new System.Drawing.Point(132, 7);
            this.btnLapPhieuGhiDanh.Name = "btnLapPhieuGhiDanh";
            this.btnLapPhieuGhiDanh.Size = new System.Drawing.Size(119, 48);
            this.btnLapPhieuGhiDanh.TabIndex = 5;
            this.btnLapPhieuGhiDanh.Text = "Lập phiếu ghi danh";
            this.btnLapPhieuGhiDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapPhieuGhiDanh.UseVisualStyleBackColor = false;
            this.btnLapPhieuGhiDanh.Click += new System.EventHandler(this.btnLapPhieuGhiDanh_Click);
            // 
            // btnTiepNhanHocVien
            // 
            this.btnTiepNhanHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnTiepNhanHocVien.FlatAppearance.BorderSize = 0;
            this.btnTiepNhanHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepNhanHocVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnTiepNhanHocVien.Image = global::QuanLyHocVien.Properties.Resources.icon_TiepNhanHocVien_32dp;
            this.btnTiepNhanHocVien.Location = new System.Drawing.Point(12, 7);
            this.btnTiepNhanHocVien.Name = "btnTiepNhanHocVien";
            this.btnTiepNhanHocVien.Size = new System.Drawing.Size(116, 48);
            this.btnTiepNhanHocVien.TabIndex = 4;
            this.btnTiepNhanHocVien.Text = "Tiếp nhận học viên";
            this.btnTiepNhanHocVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiepNhanHocVien.UseVisualStyleBackColor = false;
            this.btnTiepNhanHocVien.Click += new System.EventHandler(this.btnTiepNhanHocVien_Click);
            // 
            // tabGiangVien
            // 
            this.tabGiangVien.BackColor = System.Drawing.Color.Black;
            this.tabGiangVien.Controls.Add(this.btnXemCacLopDay);
            this.tabGiangVien.Controls.Add(this.btnGVThayDoiThongTin);
            this.tabGiangVien.Controls.Add(this.btnGVDoiMatKhau);
            this.tabGiangVien.Location = new System.Drawing.Point(4, 4);
            this.tabGiangVien.Name = "tabGiangVien";
            this.tabGiangVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiangVien.Size = new System.Drawing.Size(1199, 62);
            this.tabGiangVien.TabIndex = 1;
            this.tabGiangVien.Text = "Giảng viên";
            // 
            // btnXemCacLopDay
            // 
            this.btnXemCacLopDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnXemCacLopDay.FlatAppearance.BorderSize = 0;
            this.btnXemCacLopDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCacLopDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnXemCacLopDay.Image = global::QuanLyHocVien.Properties.Resources.icon_Lop_32dp;
            this.btnXemCacLopDay.Location = new System.Drawing.Point(373, 9);
            this.btnXemCacLopDay.Name = "btnXemCacLopDay";
            this.btnXemCacLopDay.Size = new System.Drawing.Size(172, 44);
            this.btnXemCacLopDay.TabIndex = 4;
            this.btnXemCacLopDay.Text = "Xem các lớp dạy";
            this.btnXemCacLopDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemCacLopDay.UseVisualStyleBackColor = false;
            this.btnXemCacLopDay.Click += new System.EventHandler(this.btnXemCacLopDay_Click);
            // 
            // btnGVThayDoiThongTin
            // 
            this.btnGVThayDoiThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnGVThayDoiThongTin.FlatAppearance.BorderSize = 0;
            this.btnGVThayDoiThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVThayDoiThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnGVThayDoiThongTin.Image = global::QuanLyHocVien.Properties.Resources.icon_ThayDoiThongTin_32dp;
            this.btnGVThayDoiThongTin.Location = new System.Drawing.Point(174, 9);
            this.btnGVThayDoiThongTin.Name = "btnGVThayDoiThongTin";
            this.btnGVThayDoiThongTin.Size = new System.Drawing.Size(193, 46);
            this.btnGVThayDoiThongTin.TabIndex = 3;
            this.btnGVThayDoiThongTin.Text = "Thay đổi thông tin";
            this.btnGVThayDoiThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVThayDoiThongTin.UseVisualStyleBackColor = false;
            this.btnGVThayDoiThongTin.Click += new System.EventHandler(this.btnGVThayDoiThongTin_Click);
            // 
            // btnGVDoiMatKhau
            // 
            this.btnGVDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnGVDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnGVDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnGVDoiMatKhau.Image = global::QuanLyHocVien.Properties.Resources.icon_MatKhau_32dp;
            this.btnGVDoiMatKhau.Location = new System.Drawing.Point(12, 7);
            this.btnGVDoiMatKhau.Name = "btnGVDoiMatKhau";
            this.btnGVDoiMatKhau.Size = new System.Drawing.Size(156, 48);
            this.btnGVDoiMatKhau.TabIndex = 2;
            this.btnGVDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnGVDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnGVDoiMatKhau.Click += new System.EventHandler(this.btnGVDoiMatKhau_Click);
            // 
            // tabHocVien
            // 
            this.tabHocVien.BackColor = System.Drawing.Color.Black;
            this.tabHocVien.Controls.Add(this.btnHVThayDoiThongTin);
            this.tabHocVien.Controls.Add(this.btnHVDoiMatKhau);
            this.tabHocVien.Controls.Add(this.btnHocPhi);
            this.tabHocVien.Controls.Add(this.btnBangDiem);
            this.tabHocVien.Location = new System.Drawing.Point(4, 4);
            this.tabHocVien.Name = "tabHocVien";
            this.tabHocVien.Size = new System.Drawing.Size(1199, 62);
            this.tabHocVien.TabIndex = 2;
            this.tabHocVien.Text = "Học viên";
            // 
            // btnHVThayDoiThongTin
            // 
            this.btnHVThayDoiThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnHVThayDoiThongTin.FlatAppearance.BorderSize = 0;
            this.btnHVThayDoiThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHVThayDoiThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnHVThayDoiThongTin.Image = global::QuanLyHocVien.Properties.Resources.icon_ThayDoiThongTin_32dp;
            this.btnHVThayDoiThongTin.Location = new System.Drawing.Point(137, 7);
            this.btnHVThayDoiThongTin.Name = "btnHVThayDoiThongTin";
            this.btnHVThayDoiThongTin.Size = new System.Drawing.Size(100, 48);
            this.btnHVThayDoiThongTin.TabIndex = 4;
            this.btnHVThayDoiThongTin.Text = "Thay đổi thông tin";
            this.btnHVThayDoiThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHVThayDoiThongTin.UseVisualStyleBackColor = false;
            this.btnHVThayDoiThongTin.Click += new System.EventHandler(this.btnHVThayDoiThongTin_Click);
            // 
            // btnHVDoiMatKhau
            // 
            this.btnHVDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnHVDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHVDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHVDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnHVDoiMatKhau.Image = global::QuanLyHocVien.Properties.Resources.icon_MatKhau_32dp;
            this.btnHVDoiMatKhau.Location = new System.Drawing.Point(12, 7);
            this.btnHVDoiMatKhau.Name = "btnHVDoiMatKhau";
            this.btnHVDoiMatKhau.Size = new System.Drawing.Size(119, 48);
            this.btnHVDoiMatKhau.TabIndex = 3;
            this.btnHVDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnHVDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHVDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnHVDoiMatKhau.Click += new System.EventHandler(this.btnHVDoiMatKhau_Click);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnHocPhi.FlatAppearance.BorderSize = 0;
            this.btnHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnHocPhi.Image = global::QuanLyHocVien.Properties.Resources.icon_ThongKeHocPhi_32dp;
            this.btnHocPhi.Location = new System.Drawing.Point(353, 7);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.Size = new System.Drawing.Size(96, 48);
            this.btnHocPhi.TabIndex = 6;
            this.btnHocPhi.Text = "Học phí";
            this.btnHocPhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocPhi.UseVisualStyleBackColor = false;
            this.btnHocPhi.Click += new System.EventHandler(this.btnHocPhi_Click);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnBangDiem.FlatAppearance.BorderSize = 0;
            this.btnBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnBangDiem.Image = global::QuanLyHocVien.Properties.Resources.icon_XemDiem_32dp;
            this.btnBangDiem.Location = new System.Drawing.Point(243, 7);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(104, 48);
            this.btnBangDiem.TabIndex = 5;
            this.btnBangDiem.Text = "Bảng điểm";
            this.btnBangDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBangDiem.UseVisualStyleBackColor = false;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // tabQuanTri
            // 
            this.tabQuanTri.BackColor = System.Drawing.Color.Black;
            this.tabQuanTri.Controls.Add(this.btnKetNoiCSDL);
            this.tabQuanTri.Controls.Add(this.btnThayDoiQuyDinh);
            this.tabQuanTri.Controls.Add(this.btnQuanLyTaiKhoan);
            this.tabQuanTri.Controls.Add(this.btnQuanLyHocPhi);
            this.tabQuanTri.Controls.Add(this.btnQuanLyKhoaHoc);
            this.tabQuanTri.Controls.Add(this.btnQuanLyLopHoc);
            this.tabQuanTri.Controls.Add(this.btnQuanLyGiangVien);
            this.tabQuanTri.Controls.Add(this.btnQuanLyNhanVien);
            this.tabQuanTri.Controls.Add(this.btnQuanLyHocVien);
            this.tabQuanTri.Location = new System.Drawing.Point(4, 4);
            this.tabQuanTri.Name = "tabQuanTri";
            this.tabQuanTri.Size = new System.Drawing.Size(1199, 62);
            this.tabQuanTri.TabIndex = 3;
            this.tabQuanTri.Text = "Quản trị";
            // 
            // btnKetNoiCSDL
            // 
            this.btnKetNoiCSDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnKetNoiCSDL.FlatAppearance.BorderSize = 0;
            this.btnKetNoiCSDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoiCSDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnKetNoiCSDL.Image = global::QuanLyHocVien.Properties.Resources.icon_CSDL_32dp;
            this.btnKetNoiCSDL.Location = new System.Drawing.Point(976, 7);
            this.btnKetNoiCSDL.Name = "btnKetNoiCSDL";
            this.btnKetNoiCSDL.Size = new System.Drawing.Size(121, 48);
            this.btnKetNoiCSDL.TabIndex = 14;
            this.btnKetNoiCSDL.Text = "Kết nối cơ sở dữ liệu";
            this.btnKetNoiCSDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKetNoiCSDL.UseVisualStyleBackColor = false;
            this.btnKetNoiCSDL.Click += new System.EventHandler(this.btnKetNoiCSDL_Click);
            // 
            // btnThayDoiQuyDinh
            // 
            this.btnThayDoiQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnThayDoiQuyDinh.FlatAppearance.BorderSize = 0;
            this.btnThayDoiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiQuyDinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnThayDoiQuyDinh.Image = global::QuanLyHocVien.Properties.Resources.icon_CaiDat_32dp;
            this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(863, 7);
            this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
            this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(107, 48);
            this.btnThayDoiQuyDinh.TabIndex = 12;
            this.btnThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.btnThayDoiQuyDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThayDoiQuyDinh.UseVisualStyleBackColor = false;
            this.btnThayDoiQuyDinh.Click += new System.EventHandler(this.btnThayDoiQuyDinh_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyTaiKhoan.Image = global::QuanLyHocVien.Properties.Resources.icon_NguoiDung_32dp;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(741, 7);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(116, 48);
            this.btnQuanLyTaiKhoan.TabIndex = 11;
            this.btnQuanLyTaiKhoan.Text = "Quản lý Tài khoản";
            this.btnQuanLyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyHocPhi
            // 
            this.btnQuanLyHocPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyHocPhi.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHocPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHocPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyHocPhi.Image = global::QuanLyHocVien.Properties.Resources.icon_ThongKeHocPhi_32dp;
            this.btnQuanLyHocPhi.Location = new System.Drawing.Point(623, 7);
            this.btnQuanLyHocPhi.Name = "btnQuanLyHocPhi";
            this.btnQuanLyHocPhi.Size = new System.Drawing.Size(112, 48);
            this.btnQuanLyHocPhi.TabIndex = 9;
            this.btnQuanLyHocPhi.Text = "Quản lý Học phí";
            this.btnQuanLyHocPhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyHocPhi.UseVisualStyleBackColor = false;
            this.btnQuanLyHocPhi.Click += new System.EventHandler(this.btnQuanLyHocPhi_Click);
            // 
            // btnQuanLyKhoaHoc
            // 
            this.btnQuanLyKhoaHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyKhoaHoc.Image = global::QuanLyHocVien.Properties.Resources.icon_KhoaHoc_32dp;
            this.btnQuanLyKhoaHoc.Location = new System.Drawing.Point(500, 7);
            this.btnQuanLyKhoaHoc.Name = "btnQuanLyKhoaHoc";
            this.btnQuanLyKhoaHoc.Size = new System.Drawing.Size(117, 48);
            this.btnQuanLyKhoaHoc.TabIndex = 8;
            this.btnQuanLyKhoaHoc.Text = "Quản lý Khóa học";
            this.btnQuanLyKhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyKhoaHoc.UseVisualStyleBackColor = false;
            this.btnQuanLyKhoaHoc.Click += new System.EventHandler(this.btnQuanLyKhoaHoc_Click);
            // 
            // btnQuanLyLopHoc
            // 
            this.btnQuanLyLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyLopHoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyLopHoc.Image = global::QuanLyHocVien.Properties.Resources.icon_Lop_32dp;
            this.btnQuanLyLopHoc.Location = new System.Drawing.Point(390, 7);
            this.btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            this.btnQuanLyLopHoc.Size = new System.Drawing.Size(104, 48);
            this.btnQuanLyLopHoc.TabIndex = 7;
            this.btnQuanLyLopHoc.Text = "Quản lý Lớp học";
            this.btnQuanLyLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyLopHoc.UseVisualStyleBackColor = false;
            this.btnQuanLyLopHoc.Click += new System.EventHandler(this.btnQuanLyLopHoc_Click);
            // 
            // btnQuanLyGiangVien
            // 
            this.btnQuanLyGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyGiangVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyGiangVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyGiangVien.Image = global::QuanLyHocVien.Properties.Resources.icon_GiangVien_32dp;
            this.btnQuanLyGiangVien.Location = new System.Drawing.Point(258, 7);
            this.btnQuanLyGiangVien.Name = "btnQuanLyGiangVien";
            this.btnQuanLyGiangVien.Size = new System.Drawing.Size(126, 48);
            this.btnQuanLyGiangVien.TabIndex = 6;
            this.btnQuanLyGiangVien.Text = "Quản lý Giảng viên";
            this.btnQuanLyGiangVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyGiangVien.UseVisualStyleBackColor = false;
            this.btnQuanLyGiangVien.Click += new System.EventHandler(this.btnQuanLyGiangVien_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyNhanVien.Image = global::QuanLyHocVien.Properties.Resources.icon_NhanVien_32dp;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(136, 7);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(116, 48);
            this.btnQuanLyNhanVien.TabIndex = 5;
            this.btnQuanLyNhanVien.Text = "Quản lý Nhân viên";
            this.btnQuanLyNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyHocVien
            // 
            this.btnQuanLyHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyHocVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyHocVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHocVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btnQuanLyHocVien.Image = global::QuanLyHocVien.Properties.Resources.icon_QuanLyHocVien_32dp;
            this.btnQuanLyHocVien.Location = new System.Drawing.Point(12, 7);
            this.btnQuanLyHocVien.Name = "btnQuanLyHocVien";
            this.btnQuanLyHocVien.Size = new System.Drawing.Size(118, 48);
            this.btnQuanLyHocVien.TabIndex = 4;
            this.btnQuanLyHocVien.Text = "Quản lý Học viên";
            this.btnQuanLyHocVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyHocVien.UseVisualStyleBackColor = false;
            this.btnQuanLyHocVien.Click += new System.EventHandler(this.btnQuanLyHocVien_Click);
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Location = new System.Drawing.Point(4, 4);
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Size = new System.Drawing.Size(1199, 62);
            this.tabTroGiup.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlTabTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 88);
            this.panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1215, 575);
            this.Controls.Add(this.pnlWorkspace);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1166, 622);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Học viên Trung tâm Anh ngữ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTabTitle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabRibbon.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabGiangVien.ResumeLayout(false);
            this.tabHocVien.ResumeLayout(false);
            this.tabQuanTri.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Reports.dsSource dsSource2;
        private Reports.dsSource dsSource1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.Button lblServerName;
        private System.Windows.Forms.Button lblDateTime;
        private System.Windows.Forms.Label lblCenterName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTroGiup;
        private System.Windows.Forms.Button btnThongTinPhanMem;
        private System.Windows.Forms.Button btnTrangMoDau;
        private System.Windows.Forms.Panel pnlTabTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanTriTitle;
        private System.Windows.Forms.Button btnHocVienTitle;
        private System.Windows.Forms.Button btnGiangVienTitle;
        private System.Windows.Forms.Button btnNhanVienTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabRibbon;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Button btnThayDoiThongTinNV;
        private System.Windows.Forms.Button btnNVDoiMatKhau;
        private System.Windows.Forms.Button btnXepLop;
        private System.Windows.Forms.Button btnThongKeDiemTheoLop;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnThongKeNoHocVien;
        private System.Windows.Forms.Button btnBaoCaoHocVienTheoThang;
        private System.Windows.Forms.Button btnLapPhieuGhiDanh;
        private System.Windows.Forms.Button btnTiepNhanHocVien;
        private System.Windows.Forms.TabPage tabGiangVien;
        private System.Windows.Forms.Button btnXemCacLopDay;
        private System.Windows.Forms.Button btnGVThayDoiThongTin;
        private System.Windows.Forms.Button btnGVDoiMatKhau;
        private System.Windows.Forms.TabPage tabHocVien;
        private System.Windows.Forms.Button btnHVThayDoiThongTin;
        private System.Windows.Forms.Button btnHVDoiMatKhau;
        private System.Windows.Forms.Button btnHocPhi;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.TabPage tabQuanTri;
        private System.Windows.Forms.Button btnKetNoiCSDL;
        private System.Windows.Forms.Button btnThayDoiQuyDinh;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyHocPhi;
        private System.Windows.Forms.Button btnQuanLyKhoaHoc;
        private System.Windows.Forms.Button btnQuanLyLopHoc;
        private System.Windows.Forms.Button btnQuanLyGiangVien;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyHocVien;
        private System.Windows.Forms.TabPage tabTroGiup;
    }
}