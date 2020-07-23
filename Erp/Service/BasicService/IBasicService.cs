using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erp.Web.Service.BasicService
{
    public interface IBasicService<T> where T : class
    {
        List<T> FindAll();
        T Get(string code);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
