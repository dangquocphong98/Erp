using Erp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erp.Web.Service.BasicService
{
    public class BasicService<T> : IBasicService<T> where T : class
    {
        ErpContext RepositoryContext { get; set; }
        public BasicService(ErpContext repositoryContext)
        { 
            RepositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public List<T> FindAll()
        {
            return RepositoryContext.Set<T>().ToList();
        }

        public T Get(string code)
        {
            return RepositoryContext.Set<T>().Find(code);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
