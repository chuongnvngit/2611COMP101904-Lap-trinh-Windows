using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        // Khai báo các biến quản lý dữ liệu
        private BindingList<Product> products = new BindingList<Product>();
        private BindingSource productSource = new BindingSource();
        private string selectedImagePath = string.Empty;

        public FrmProduct()
        {
            InitializeComponent();
        }

        // 1. SỰ KIỆN FORM LOAD
        private void FrmProduct_Load_1(object sender, EventArgs e)
        {
            // Nạp danh sách loại sản phẩm
            cboLoaiSP.Items.AddRange(new object[]
            {
                "Điện tử", "Văn phòng", "Gia dụng", "Thời trang"
            });
            cboLoaiSP.SelectedIndex = 0;

            // Thêm dữ liệu mẫu ban đầu
            products.Add(new Product
            {
                MaSP = "SP01",
                TenSP = "Chuột không dây",
                LoaiSP = "Điện tử",
                DonGia = 150000,
                SoLuong = 20,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true
            });

            products.Add(new Product
            {
                MaSP = "SP02",
                TenSP = "Bút bi",
                LoaiSP = "Văn phòng",
                DonGia = 5000,
                SoLuong = 100,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true
            });

            // Gán dữ liệu lên BindingSource và DataGridView
            productSource.DataSource = products;
            dgvProducts.DataSource = productSource;

            // Cấu hình hiển thị cho DataGridView
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;

            UpdateStatus("Sẵn sàng");
        }

        // 2. CÁC HÀM BỔ TRỢ (VALIDATION, GET PRODUCT, CLEAR, UPDATE STATUS)
        private bool ValidateInput(bool isEdit = false)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được rỗng");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được rỗng");
                isValid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0");
                isValid = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn hôm nay");
                isValid = false;
            }

            string ma = txtMaSP.Text.Trim();
            bool isDuplicate = products.Any(p => p.MaSP.Equals(ma, StringComparison.OrdinalIgnoreCase));
            if (!isEdit && isDuplicate)
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại");
                isValid = false;
            }

            return isValid;
        }

        private Product GetSelectedProduct()
        {
            if (productSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong danh sách.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return productSource.Current as Product;
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            //cboLoaiSP.SelectedIndex = 0;
            numDonGia.Value = 1;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;
            txtTimKiem.Clear();
            picSanPham.Image = null;
            selectedImagePath = string.Empty;
            errorProvider1.Clear();
            txtMaSP.Focus();
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"{message} | Số sản phẩm: {products.Count}";
        }

        // 3. XỬ LÝ NÚT THÊM - SỬA - XÓA - LÀM MỚI (BUTTON)
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput(isEdit: false)) return;

            Product p = new Product
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                LoaiSP = cboLoaiSP.Text,
                DonGia = numDonGia.Value,
                SoLuong = (int)numSoLuong.Value,
                NgayNhap = dtpNgayNhap.Value.Date,
                ConKinhDoanh = chkConKinhDoanh.Checked,
                DuongDanAnh = selectedImagePath
            };

            products.Add(p);
            ClearInput();
            UpdateStatus("Đã thêm sản phẩm mới");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            if (!ValidateInput(isEdit: true)) return;

            p.TenSP = txtTenSP.Text.Trim();
            p.LoaiSP = cboLoaiSP.Text;
            p.DonGia = numDonGia.Value;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayNhap = dtpNgayNhap.Value.Date;
            p.ConKinhDoanh = chkConKinhDoanh.Checked;
            p.DuongDanAnh = selectedImagePath;

            productSource.ResetBindings(false);
            UpdateStatus("Đã cập nhật sản phẩm");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm {p.TenSP}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                products.Remove(p);
                ClearInput();
                UpdateStatus("Đã xóa sản phẩm");
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productSource;
            ClearInput();
            UpdateStatus("Đã làm mới dữ liệu");
        }

        // 4. CHỌN DÒNG TRÊN DATAGRIDVIEW ĐỂ ĐẨY DỮ LIỆU LÊN FORM
        private void dgvProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;

            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;
            cboLoaiSP.Text = p.LoaiSP;
            numDonGia.Value = p.DonGia;
            numSoLuong.Value = p.SoLuong;
            dtpNgayNhap.Value = p.NgayNhap;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;
            selectedImagePath = p.DuongDanAnh;

            if (!string.IsNullOrWhiteSpace(p.DuongDanAnh) && File.Exists(p.DuongDanAnh))
                picSanPham.Image = Image.FromFile(p.DuongDanAnh);
            else
                picSanPham.Image = null;
        }

        // 5. TÌM KIẾM VÀ CHỌN ẢNH
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            var result = products
                .Where(p => p.MaSP.ToLower().Contains(keyword)
                         || p.TenSP.ToLower().Contains(keyword))
                .ToList();

            dgvProducts.DataSource = result;
            lblStatus.Text = $"Tìm thấy {result.Count} sản phẩm";
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";
                dialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    picSanPham.Image = Image.FromFile(selectedImagePath);
                    UpdateStatus("Đã chọn ảnh sản phẩm");
                }
            }
        }

        // 6. ĐIỀU HƯỚNG MENU / TOOLSTRIP / CONTEXT MENU
        private void mnuFileExit_Click(object sender, EventArgs e) => Close();
        private void mnuQuanLyThem_Click(object sender, EventArgs e) => btnThem.PerformClick();
        private void mnuQuanLySua_Click(object sender, EventArgs e) => btnSua.PerformClick();
        private void mnuQuanLyXoa_Click(object sender, EventArgs e) => btnXoa.PerformClick();
        private void mnuQuanLyLamMoi_Click(object sender, EventArgs e) => btnLamMoi.PerformClick();

        private void tsbThem_Click_1(object sender, EventArgs e) => btnThem.PerformClick();
        private void tsbSua_Click(object sender, EventArgs e) => btnSua.PerformClick();
        private void tsbXoa_Click_1(object sender, EventArgs e) => btnXoa.PerformClick();
        private void tsbLamMoi_Click_1(object sender, EventArgs e) => btnLamMoi.PerformClick();

        private void cmsSua_Click(object sender, EventArgs e) => btnSua.PerformClick();
        private void cmsXoa_Click(object sender, EventArgs e) => btnXoa.PerformClick();

        private void cmsChiTiet_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p == null) return;
            MessageBox.Show($"Mã: {p.MaSP}\nTên: {p.TenSP}\nLoại: {p.LoaiSP}\nĐơn giá: {p.DonGia:N0} VNĐ\nSố lượng: {p.SoLuong}\nThành tiền: {p.ThanhTien:N0} VNĐ",
                "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuTroGiupInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình Quản lý sản phẩm +  Nguyễn Võ Nguyên Chương + 4901103010", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Các hàm sự kiện phụ không dùng tới có thể để trống
        private void toolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void ssStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void txtMaSP_TextChanged(object sender, EventArgs e) { }
        private void txtTenSP_TextChanged(object sender, EventArgs e) { }
        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numSoLuong_ValueChanged(object sender, EventArgs e) { }
        private void numDonGia_ValueChanged(object sender, EventArgs e) { }
        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e) { }
        private void chkConKinhDoanh_CheckedChanged(object sender, EventArgs e) { }
        private void picSanPham_Click(object sender, EventArgs e) { }
        private void txtTimKiem_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void cmsProduct_Opening(object sender, CancelEventArgs e) { }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void msMain_Click(object sender, EventArgs e) { }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}