using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
    }
}
