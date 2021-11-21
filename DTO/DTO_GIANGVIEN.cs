using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GIANGVIEN
    {
        private int _GV_ID;
        private string _GV_NAME;
        private string _GV_DOB;
        private string _GV_ADD;
        public int GV_ID
        {
            get
            {
                return _GV_ID;
            }

            set
            {
                _GV_ID = value;
            }
        }
        public string GV_NAME
        {
            get
            {
                return _GV_NAME;
            }

            set
            {
                _GV_NAME = value;
            }
        }
        public string GV_DOB
        {
            get
            {
                return _GV_DOB;
            }

            set
            {
                _GV_DOB = value;
            }
        }
        public string GV_ADD
        {
            get
            {
                return _GV_ADD;
            }

            set
            {
                _GV_ADD = value;
            }
        }
        public DTO_GIANGVIEN(){}
        public DTO_GIANGVIEN(int id, string name, string dob, string add)
        {
            this.GV_ID = id;
            this.GV_NAME = name;
            this.GV_DOB = dob;
            this.GV_ADD = add;
        }
    }
}
