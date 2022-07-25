using WebApi.Models;

namespace WebApi.Data
{
    public interface IAppRepository
    {
        List<User> GetList();
        void Add<T>(T entity);
        bool SaveAll();
    }
}
