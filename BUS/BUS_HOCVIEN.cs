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
        DAL_HOCVIEN dalHocVien = new DAL_HOCVIEN();

        public DataTable getHocVien()
        {
            return dalHocVien.getHocVien();
        }

        public bool themHocVien(DTO_HOCVIEN tv)
        {
            return dalHocVien.themHocVien(tv);
        }

        public bool suaHocVien(DTO_HOCVIEN tv)
        {
            return dalHocVien.suaHocVien(tv);
        }

        public bool xoaHocVien(int TV_ID)
        {
            return dalHocVien.xoaHocVien(TV_ID);
        }
    }
}
