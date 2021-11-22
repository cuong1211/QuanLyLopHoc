using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HOCVIEN
    {
        DAL_HOCVIEN dalMonHoc = new DAL_HOCVIEN();

        public DataTable getHocVien()
        {
            return dalMonHoc.getHocVien();
        }

        public bool themHocVien(DTO_HOCVIEN tv)
        {
            return dalMonHoc.themHocVien(tv);
        }

        public bool suaHocVien(DTO_HOCVIEN tv)
        {
            return dalMonHoc.suaHocVien(tv);
        }

        public bool xoaHocVien(int TV_ID)
        {
            return dalMonHoc.xoaHocVien(TV_ID);
        }
    }
}
