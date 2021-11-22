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
        private int _GV_ID;
        private int _MH_ID;

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

        public int MH_ID
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

        public DTO_LOPHOC(int id, string name, int gv_id, int mh_id)
        {
            this.LH_ID = id;
            this.LH_NAME = name;
            this.GV_ID = gv_id;
            this.MH_ID = mh_id;
        }
    }
}
