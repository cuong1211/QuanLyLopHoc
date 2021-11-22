using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_LOPHOC
    {
        DAL_LOPHOC dalLophoc = new DAL_LOPHOC();

        public DataTable getLopHoc()
        {
            return dalLophoc.getLopHoc();
        }

        public bool themHocVien(DTO_LOPHOC lh)
        {
            return dalLophoc.themLopHoc(lh);
        }

        public bool suaHocVien(DTO_LOPHOC lh)
        {
            return dalLophoc.suaLopHoc(lh);
        }

        public bool xoaHocVien(int LH_ID)
        {
            return dalLophoc.xoaLopHoc(LH_ID);
        }
        public DataTable getGV()
        {
            return dalLophoc.getGV();
        }
        public DataTable getMH()
        {
            return dalLophoc.getMH();
        }
    }
}

