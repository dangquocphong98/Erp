using Erp.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Erp.Model
{
    public class ErpContext : DbContext
    {
        public ErpContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Timekeeper> Timekeepers { get; set; }
        public DbSet<TimekeepingHistory> TimekeepingHistories { get; set; }
    }
}
