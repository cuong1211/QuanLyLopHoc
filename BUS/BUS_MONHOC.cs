using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_MONHOC
    {
        DAL_MONHOC dalMonHoc = new DAL_MONHOC();

        public DataTable getMonHoc()
        {
            return dalMonHoc.getMonHoc();
        }

        public bool themMonHoc(DTO_MONHOC mh)
        {
            return dalMonHoc.themMonHoc(mh);
        }

        public bool suaMonHoc(DTO_MONHOC mh)
        {
            return dalMonHoc.suaMonHoc(mh);
        }

        public bool xoaMonHoc(int MH_ID)
        {
            return dalMonHoc.xoaMonHoc(MH_ID);
        }
    }
}

