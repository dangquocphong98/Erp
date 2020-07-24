using Erp.Model;
using Erp.Model.Entity;
using Erp.Web.Service.BasicService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erp.Web.Service.StaffService
{
    public class StaffService : BasicService<Staff>, IStaffService
    {
        public StaffService(ErpContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
