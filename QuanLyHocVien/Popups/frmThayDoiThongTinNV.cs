using System;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace QuanLyHocVien.Popups
{
    public partial class frmThayDoiThongTinNV : Form
    {
        public frmThayDoiThongTinNV()
        {
            InitializeComponent();
        }

        /// Kiểm tra hợp lệ
        public void ValidateLuu()
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
                throw new ArgumentException("Số điện thoại không được trống");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                throw new ArgumentException("Email không được trống");
        }


        #region Events

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThayDoiThongTinNV_Load(object sender, EventArgs e)
        {
            cboLoaiNV.DataSource = LoaiNV.SelectAll();
            cboLoaiNV.DisplayMember = "TenLoaiNV";
            cboLoaiNV.ValueMember = "MaLoaiNV";

            NHANVIEN nv = NhanVien.Select(GlobalSettings.UserID);
            txtMaNV.Text = nv.MaNV;
            txtTenNV.Text = nv.TenNV;
            txtEmail.Text = nv.EmailNV;
            txtSDT.Text = nv.SdtNV;
            cboLoaiNV.SelectedValue = nv.MaLoaiNV;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLuu();

                NhanVien.Update(new NHANVIEN()
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    EmailNV = txtEmail.Text,
                    SdtNV = txtSDT.Text,
                    MaLoaiNV = cboLoaiNV.SelectedValue.ToString()
                });

                MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
