using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyLopHoc
{
    public partial class GiaoVien : Form
    {
        BUS_GIANGVIEN busGV = new BUS_GIANGVIEN();
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtName.Text != "" && dpDob.Text != "")
            {
                // Tạo DTo
                DTO_GIANGVIEN gv = new DTO_GIANGVIEN(0, txtName.Text, dpDob.Text, txtAdd.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busGV.themGiangVien(gv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvGV.DataSource = busGV.getGiangVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGV.SelectedRows.Count > 0)
            {
                if (txtAdd.Text != "" && txtName.Text != "" && dpDob.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvGV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_GIANGVIEN gv = new DTO_GIANGVIEN(ID, txtName.Text, dpDob.Text, txtAdd.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busGV.suaGiangvien(gv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvGV.DataSource = busGV.getGiangVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGV.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvGV.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (busGV.xoaGiangVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvGV.DataSource = busGV.getGiangVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void dgvGV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGV.SelectedCells[0].OwningRow;

            // Chuyển giá trị lên form
            txtName.Text = row.Cells[1].Value.ToString();
            dpDob.Text = row.Cells[2].Value.ToString();
            txtAdd.Text = row.Cells[3].Value.ToString();
        }
    }
}
