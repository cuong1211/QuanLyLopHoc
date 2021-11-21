using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DTO
{
    public class DTO_LOPHOC
    {
        private int _LH_ID;
        private string _LH_NAME;
        private string _GV_ID;
        private string _MH_ID;

        /* ======== GETTER/SETTER ======== */
        public int LH_ID
        {
            get
            {
                return _LH_ID;
            }

            set
            {
                _LH_ID = value;
            }
        }

        public string LH_NAME
        {
            get
            {
                return _LH_NAME;
            }

            set
            {
                _LH_NAME = value;
            }
        }

        public string GV_ID
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

        public string MH_ID
        {
            get
            {
                return _MH_ID;
            }

            set
            {
                _MH_ID = value;
            }
        }

        /* === Constructor === */
        public DTO_LOPHOC()
        {

        }

        public DTO_LOPHOC(int id, string name, string dob, string add)
        {
            this.LH_ID = id;
            this.LH_NAME = name;
            this.GV_ID = dob;
            this.MH_ID = add;
        }
    }
}
