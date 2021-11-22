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

    public partial class LopHoc : Form
    {
        BUS_LOPHOC busLH = new BUS_LOPHOC();
        public LopHoc()
        {
            InitializeComponent();
        }

        private void cbGiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            //giao vien
            cbbGV.DataSource = busLH.getGV();
            cbbGV.DisplayMember = "GV_NAME";
            cbbGV.ValueMember = "GV_ID";

            //mon hoc
            cbbMH.DataSource = busLH.getMH();
            cbbMH.DisplayMember = "MH_NAME";
            cbbMH.ValueMember = "MH_ID";

            dgvLH.DataSource = busLH.getLopHoc();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbGV.Text != "" && cbbGV.Text != "" && txtName.Text != "")
            {
                // Tạo DTo
                DTO_LOPHOC lh = new DTO_LOPHOC(0, txtName.Text, Convert.ToInt32(cbbGV.Text), Convert.ToInt32(cbbMH.Text)); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busLH.themHocVien(lh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvLH.DataSource = busLH.getLopHoc(); // refresh datagridview
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

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}

