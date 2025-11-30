using System;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyHocVien.Popups
{
    public partial class frmNhanVienEdit : Form
    {
        private NHANVIEN nv;
        private bool isInsert = false;

        public frmNhanVienEdit(NHANVIEN nv)
        {
            InitializeComponent();
            this.nv = nv;
            isInsert = nv == null;
        }

        /// Nạp nhân viên lên giao diện
        public void LoadUI(NHANVIEN nv)
        {
            if (nv == null)
            {
                txtMaNV.Text = NhanVien.AutoGenerateId();
            }
            else
            {
                txtMaNV.Text = nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                txtSDT.Text = nv.SdtNV;
                txtEmail.Text = nv.EmailNV;
                cboLoaiNV.SelectedValue = nv.MaLoaiNV;
                txtTenDangNhap.Text = nv.TenDangNhap;
                txtMatKhau.Text = nv.TAIKHOAN.MatKhau;
                txtTenDangNhap.Enabled = false;
            }
        }

        /// Nạp giao diện thành đối tượng
        private NHANVIEN LoadNhanVien()
        {
            return new NHANVIEN()
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTenNV.Text,
                SdtNV = txtSDT.Text,
                EmailNV = txtEmail.Text,
                MaLoaiNV = cboLoaiNV.SelectedValue.ToString(),
                TenDangNhap = txtTenDangNhap.Text
            };
        }

        /// Kiểm tra hợp lệ
        public void ValidateLuu()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                throw new ArgumentException("Họ và tên nhân viên không được trống");
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
                throw new ArgumentException("Số điện thoại không được trống");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                throw new ArgumentException("Email không được trống");
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                throw new ArgumentException("Tên đăng nhập không được trống");
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                throw new ArgumentException("Mật khẩu không được trống");
        }

        #region Events

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVienEdit_Load(object sender, EventArgs e)
        {
            //load loại nhân viên
            cboLoaiNV.DataSource = LoaiNV.SelectAll();
            cboLoaiNV.DisplayMember = "TenLoaiNV";
            cboLoaiNV.ValueMember = "MaLoaiNV";

            LoadUI(nv);
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLuu();

                if (isInsert)
                {
                    NhanVien.Insert(LoadNhanVien(), new TAIKHOAN()
                    {
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                    });

                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NhanVien.Update(LoadNhanVien(), new TAIKHOAN()
                    {
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                    });

                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
