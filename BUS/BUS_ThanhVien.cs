using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ThanhVien
    {
        DAL_ThanhVien dalThanhVien = new DAL_ThanhVien();

        public DataTable getThanhVien()
        {
            return dalThanhVien.getThanhVien();
        }

        public bool themThanhVien(DTO_ThanhVien tv)
        {
            return dalThanhVien.themThanhVien(tv);
        }

        public bool suaThanhVien(DTO_ThanhVien tv)
        {
            return dalThanhVien.suaThanhVien(tv);
        }

        public bool xoaThanhVien(int TV_ID)
        {
            return dalThanhVien.xoaThanhVien(TV_ID);
        }
    }
}
