using Domain;
using Domain.Entities;
using Domain.Services;
using LiteDB;

namespace Infrastructure.Database
{
    /// <summary>
    /// Handles database operations using LiteDB (NoSQL)
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        private LiteDatabase _database;
        private ILiteCollection<User> _collection;

        public UserRepository(LiteDatabase database)
        {
            _database = database;

            _collection = _database.GetCollection<User>("Users");
        }
        public int Insert(User entity) => _collection.Insert(entity);

        public bool Delete(int id) => _collection.Delete(id);

        public bool DeleteAll() => _collection.DeleteAll() > 0;

        public IEnumerable<User> GetAll() => _collection.FindAll();

        public User GetById(int id) => _collection.FindById(id);

        public bool Update(User entity) => _collection.Update(entity);

        public bool Upsert(User entity) => _collection.Upsert(entity);

        /// <summary>
        /// No need to implement since LiteDB does not have a dispose method.
        /// </summary>
        public void Dispose() { }
    }

}
