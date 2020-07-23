using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Erp.Model.Entity
{
    public class TimekeepingHistory
    {
        [Key]
        public int Id { get; set; }
        public string CodeStaff { get; set; }
        public string CodeMachine { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime BackTime  { get; set; }
        public bool IsTrue { get; set; }
        public int LateTime { get; set; }
        public string LateTimeType { get; set; }
    }
}
