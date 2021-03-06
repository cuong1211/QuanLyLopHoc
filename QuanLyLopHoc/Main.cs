using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HocVien hv= new HocVien();
            hv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoVien gv = new GiaoVien();
            gv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LopHoc lh = new LopHoc();
            lh.Show();
        }

        private void txtMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc mh = new MonHoc();
            mh.Show();
        }
    }
}
