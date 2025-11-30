using System;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyHocVien.Popups
{
    public partial class frmThayDoiThongTinGV : Form
    {
        public frmThayDoiThongTinGV()
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

        private void frmThayDoiThongTinGV_Load(object sender, EventArgs e)
        {
            GIANGVIEN gv = GiangVien.Select(GlobalSettings.UserID);
            txtMaGV.Text = gv.MaGV;
            txtTenGV.Text = gv.TenGV;
            cboGioiTinh.Text = gv.GioiTinhGV;
            txtEmail.Text = gv.EmailGV;
            txtSDT.Text = gv.SdtGV;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLuu();

                GiangVien.Update(new GIANGVIEN()
                {
                    MaGV = txtMaGV.Text,
                    TenGV = txtTenGV.Text,
                    GioiTinhGV = cboGioiTinh.Text,
                    EmailGV = txtEmail.Text,
                    SdtGV = txtSDT.Text
                });

                MessageBox.Show("Cập nhật thông tin giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion
    }
}
