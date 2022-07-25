using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class AppRepository : IAppRepository
    {
        private ArgusDatabaseContext _dbContext;

        public AppRepository(/*ArgusDatabaseContext dbContext*/)
        {
            _dbContext = new ArgusDatabaseContext();
        }
        public void Add<T>(T entity)
        {
            _dbContext.Add(entity);
        }

        public List<User> GetList()
        {
            var users=_dbContext.Users.ToList();
            return users;
        }

        public bool SaveAll()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
