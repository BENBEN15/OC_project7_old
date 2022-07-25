using System.Collections.Generic;

namespace WebApi.Services
{
    public interface IService<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Update(T entityUpdate);
        void Delete(int id);
    }
}
