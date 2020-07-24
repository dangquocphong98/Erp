using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Erp.Model.Entity
{
    public class Timekeeper // máy chấm công
    {
        [Key]
        public string CodeMachine { get; set; }
        public string Name { get; set; }
        public int type { get; set; }
    }
}
