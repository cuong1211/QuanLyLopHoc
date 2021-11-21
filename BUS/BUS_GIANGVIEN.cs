using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_GIANGVIEN
    {
        DAL_GIANGVIEN dalGiangVien = new DAL_GIANGVIEN();

        public DataTable getGiangVien()
        {
            return dalGiangVien.getGiangVien();
        }

        public bool themGiangVien(DTO_GIANGVIEN gv)
        {
            return dalGiangVien.themGiangVien(gv);
        }

        public bool suaGiangvien(DTO_GIANGVIEN gv)
        {
            return dalGiangVien.suaGiangVien(gv);
        }

        public bool xoaGiangVien(int GV_ID)
        {
            return dalGiangVien.xoaGiangVien(GV_ID);
        }
    }
}