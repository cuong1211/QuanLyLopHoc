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
    public partial class HocVien : Form
    {
        BUS_HOCVIEN busTV = new BUS_HOCVIEN();

        public object DataGridViewButtonCollum { get; private set; }

        public HocVien()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTV.DataSource = busTV.getHocVien(); // get thanh vien
            addButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtName.Text != "" && dpDob.Text != "")
            {
                // Tạo DTo
                DTO_HOCVIEN tv = new DTO_HOCVIEN(0, txtName.Text, dpDob.Text, txtAdd.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busTV.themHocVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTV.DataSource = busTV.getHocVien(); // refresh datagridview
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTV.SelectedRows.Count > 0)
            {
                if (txtAdd.Text != "" && txtName.Text != "" && dpDob.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvTV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_HOCVIEN tv = new DTO_HOCVIEN(ID, txtName.Text, dpDob.Text, txtAdd.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busTV.suaHocVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTV.DataSource = busTV.getHocVien(); // refresh datagridview
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTV.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvTV.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (busTV.xoaHocVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTV.DataSource = busTV.getHocVien(); // refresh datagridview
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
        private void addButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "ACTION";
            btn.Name = "Action";
            btn.Text = "Xem";
            btn.UseColumnTextForButtonValue = true;
            dgvTV.Columns.Add(btn);
        }
      

        private void dgvTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                this.Hide();
                GiaoVien f2 = new GiaoVien();
                f2.Show();
            }
        }

       

        private void dgvTV_Click(object sender, DataGridViewCellEventArgs e)
        {
           

            DataGridViewRow row = dgvTV.SelectedCells[0].OwningRow;

            // Chuyển giá trị lên form
            txtName.Text = row.Cells[1].Value.ToString();
            dpDob.Text = row.Cells[2].Value.ToString();
            txtAdd.Text = row.Cells[3].Value.ToString();
        }

        private void dpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
