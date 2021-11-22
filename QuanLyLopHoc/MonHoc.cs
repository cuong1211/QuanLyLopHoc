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
    public partial class MonHoc : Form
    {
        BUS_MONHOC busMH = new BUS_MONHOC();
        public MonHoc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtName.Text != "" )
            {
                // Tạo DTo
                DTO_MONHOC mh = new DTO_MONHOC(0, txtName.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busMH.themMonHoc(mh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTV.DataSource = busMH.getMonHoc(); // refresh datagridview
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
                if (txtName.Text != "" )
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvTV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_MONHOC tv = new DTO_MONHOC(ID, txtName.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busMH.suaMonHoc(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTV.DataSource = busMH.getMonHoc(); // refresh datagridview
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
                if (busMH.xoaMonHoc(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTV.DataSource = busMH.getMonHoc(); // refresh datagridview
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

       

        private void MonHoc_Load(object sender, EventArgs e)
        {
            dgvTV.DataSource = busMH.getMonHoc(); // get thanh vien
            
        }
    }
}
