using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Tiếng Anh");
            cboKhoa.Items.Add("Toán-Tin");
            cboKhoa.SelectedIndex = 0; // Chọn mặc định mục đầu tiên
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Kiểm tra Năm sinh
            int currentYear = DateTime.Now.Year;
            if (string.IsNullOrWhiteSpace(txtNamSinh.Text) ||
                !int.TryParse(txtNamSinh.Text, out int namSinh) ||
                namSinh < 1900 || namSinh > currentYear)
            {
                MessageBox.Show($"Năm sinh phải là số nguyên từ 1900 đến {currentYear}!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Kiểm tra Giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Khoa
            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa hoặc lớp!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu và tính toán
            string hoTen = txtHoTen.Text.Trim();
            int tuoi = currentYear - namSinh;
            string email = txtEmail.Text.Trim();
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string khoa = cboKhoa.SelectedItem.ToString();

            // Hiển thị kết quả 
            txtKetQua.Text = $"THÔNG TIN SINH VIÊN\r\n\r\n" +
                 $"Họ tên: {hoTen}\r\n\r\n" +
                 $"Tuổi: {tuoi}\r\n\r\n" +
                 $"Email: {email}\r\n\r\n" +
                 $"Giới tính: {gioiTinh}\r\n\r\n" +
                 $"Khoa/Lớp: {khoa}";
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhoa.SelectedIndex = -1;
            txtKetQua.Text = string.Empty;
            txtHoTen.Focus();
        }
    }
}
