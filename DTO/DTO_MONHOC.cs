using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DTO
{
    public class DTO_MONHOC
    {
        private int _MH_ID;
        private string _MH_NAME;

        /* ======== GETTER/SETTER ======== */
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

        public string MH_NAME
        {
            get
            {
                return _MH_NAME;
            }

            set
            {
                _MH_NAME = value;
            }
        }

        

        /* === Constructor === */
        public DTO_MONHOC()
        {

        }

        public DTO_MONHOC(int id, string name)
        {
            this.MH_ID = id;
            this.MH_NAME = name;
            
        }
    }
}

