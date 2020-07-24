using Erp.Model;
using Erp.Model.Entity;
using Erp.Web.Service.BasicService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erp.Web.Service.TimekeepingHistoryService
{
    public class TimekeepingHistoryService : BasicService<TimekeepingHistory>, ITimekeepingHistoryService
    {
        public TimekeepingHistoryService(ErpContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
