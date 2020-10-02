using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padronize.Repositories
{
    public interface IRepository
    {
        List<T> FindAll<T>(string entitys = "") where T : class;
        T FindById<T>(int id,string entitys = "") where T : class;
        T Create<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}