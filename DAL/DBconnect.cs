﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=CUONG;Initial Catalog=QLLH;Integrated Security=True");
    }
}
