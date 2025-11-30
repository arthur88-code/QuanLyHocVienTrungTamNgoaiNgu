using System;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyHocVien.Popups
{
    public partial class frmThayDoiThongTinHV : Form
    {
        private HOCVIEN hv;

        public frmThayDoiThongTinHV()
        {
            InitializeComponent();
        }

        /// Kiểm tra hợp lệ
        public void ValidateLuu()
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                throw new ArgumentException("Địa chỉ không được trống");
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
                throw new ArgumentException("Số điện thoại không được trống");
        }


        #region Events

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThayDoiThongTinHV_Load(object sender, EventArgs e)
        {
            hv = HocVien.Select(GlobalSettings.UserID);

            txtMaHV.Text = hv.MaHV;
            txtTenHV.Text = hv.TenHV;
            dateNgaySinh.Value = (DateTime)hv.NgaySinh;
            cboGioiTinh.Text = hv.GioiTinhHV;
            txtDiaChi.Text = hv.DiaChi;
            txtSDT.Text = hv.SdtHV;
            txtEmail.Text = hv.EmailHV;
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

                HocVien.Update(new HOCVIEN()
                {
                    MaHV = txtMaHV.Text,
                    TenHV = txtTenHV.Text,
                    GioiTinhHV = cboGioiTinh.Text,
                    NgaySinh = dateNgaySinh.Value,
                    DiaChi = txtDiaChi.Text,
                    SdtHV = txtSDT.Text,
                    EmailHV = txtEmail.Text,
                    MaLoaiHV = hv.MaLoaiHV
                });

                MessageBox.Show("Cập nhật thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

