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
    public partial class Form1 : Form
    {
        BUS_ThanhVien busTV = new BUS_ThanhVien();

        public object DataGridViewButtonCollum { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTV.DataSource = busTV.getThanhVien(); // get thanh vien
            addButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtName.Text != "" && txtSDT.Text != "")
            {
                // Tạo DTo
                DTO_ThanhVien tv = new DTO_ThanhVien(0, txtName.Text, txtSDT.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busTV.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
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
                if (txtEmail.Text != "" && txtName.Text != "" && txtSDT.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvTV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_ThanhVien tv = new DTO_ThanhVien(ID, txtName.Text, txtSDT.Text, txtEmail.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busTV.suaThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
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
                if (busTV.xoaThanhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
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
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
    }
}
