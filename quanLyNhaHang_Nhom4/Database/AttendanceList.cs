﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;

namespace quanLyNhaHang_Nhom4.Database
{
    public partial class AttendanceList
    {
        public int id { get; set; }
        public string idStaff { get; set; } 
        public System.DateTime dateCheckIn { get; set; }    

    }
}
