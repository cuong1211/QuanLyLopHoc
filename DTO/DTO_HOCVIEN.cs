using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DTO
{
    public class DTO_HOCVIEN
    {
        private int _HV_ID;
        private string _HV_NAME;
        private string _HV_DOB;
        private string _HV_ADD;

        /* ======== GETTER/SETTER ======== */
        public int HV_ID
        {
            get
            {
                return _HV_ID;
            }

            set
            {
                _HV_ID = value;
            }
        }

        public string HV_NAME
        {
            get
            {
                return _HV_NAME;
            }

            set
            {
                _HV_NAME = value;
            }
        }

        public string HV_DOB
        {
            get
            {
                return _HV_DOB;
            }

            set
            {
                _HV_DOB = value;
            }
        }

        public string HV_ADD
        {
            get
            {
                return _HV_ADD;
            }

            set
            {
                _HV_ADD = value;
            }
        }

        /* === Constructor === */
        public DTO_HOCVIEN()
        {

        }

        public DTO_HOCVIEN(int id, string name, string dob, string add)
        {
            this.HV_ID = id;
            this.HV_NAME = name;
            this.HV_DOB = dob;
            this.HV_ADD = add;
        }
    }
}
