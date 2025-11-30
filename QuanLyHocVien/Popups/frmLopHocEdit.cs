using System;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace QuanLyHocVien.Popups
{
    public partial class frmLopHocEdit : Form
    {
        private LOPHOC lh;
        private bool isInsert = false;

        public frmLopHocEdit(LOPHOC lh = null)
        {
            InitializeComponent();
            this.lh = lh;
            isInsert = lh == null;
        }

        /// Nạp lớp lên giao diện
        public void LoadUI(LOPHOC lh)
        {
            if (lh == null)
            {
                txtMaLop.Text = LopHoc.AutoGenerateId(dateNgayBD.Value);
            }
            else
            {
                txtMaLop.Text = lh.MaLop;
                txtTenLop.Text = lh.TenLop;
                dateNgayBD.Value = (DateTime)lh.NgayBD;
                dateNgayBD.Enabled = cboKhoa.Enabled = isInsert;
                dateNgayKT.Value = (DateTime)lh.NgayKT;
                cboKhoa.SelectedValue = lh.MaKH;
                rdMo.Checked = (bool)lh.DangMo;
                rdDong.Checked = !(bool)lh.DangMo;
            }
        }

        /// Nạp giao diện thành đối tượng
        private LOPHOC LoadLopHoc()
        {
            return new LOPHOC()
            {
                MaLop = txtMaLop.Text,
                TenLop = txtTenLop.Text,
                NgayBD = dateNgayBD.Value,
                NgayKT = dateNgayKT.Value,
                SiSo = lh == null ? 0 : lh.SiSo,
                MaKH=cboKhoa.SelectedValue.ToString(),
                DangMo = rdMo.Checked
            };
        }

        /// Kiểm tra nhập liệu tìm kiếm có hợp lệ
        public void ValidateLuu()
        {
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
                throw new ArgumentException("Tên lớp không được trống");
        }

        #region Events

        private void dateNgayBD_ValueChanged(object sender, EventArgs e)
        {
            if (isInsert)
                txtMaLop.Text = LopHoc.AutoGenerateId(dateNgayBD.Value);

            dateNgayKT.MinDate = dateNgayBD.Value;
            dateNgayKT.Value = dateNgayBD.Value + TimeSpan.FromDays(180);
        }

        private void frmLopHocEdit_Load(object sender, EventArgs e)
        {
            dateNgayBD.Value = DateTime.Now;

            cboKhoa.DataSource = KhoaHoc.SelectAll();
            cboKhoa.DisplayMember = "TenKH";
            cboKhoa.ValueMember = "MaKH";

            LoadUI(lh);
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLuu();

                if (isInsert)
                {
                    LopHoc.Insert(LoadLopHoc());

                    MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LopHoc.Update(LoadLopHoc());

                    MessageBox.Show("Sửa lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion
    }
}
