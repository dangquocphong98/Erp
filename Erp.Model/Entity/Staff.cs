using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Erp.Model.Entity
{
    public class Staff
    {
        [Key]
        public string Id_Staff { get; set; }
        public string AttendanceCode { get; set; } // Mã chấm công
        public string Name { get; set; }
        public string CodeMachine { get; set; } // Mã máy
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
