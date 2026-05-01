using WebApp.Models;

namespace WebApp.Managers
{
    public interface IGenericManager<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public int Insert(T entity);
        public int Update(int id, T entity);
        public int Delete(int id);
    }
}
