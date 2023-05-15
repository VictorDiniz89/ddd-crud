using Domain.Entities;
using Domain.Services;
using FluentValidation;
using Infrastructure.Validators;

namespace API.Services
{
    /// <summary>
    /// Handles validation and operations concerning Users.
    /// </summary>
    public class UserService : IUserService
    {
        private IRepository<User> _repository;

        private UserValidator _validator;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
            _validator = new UserValidator();
        }
        public void CreateUser(User user)
        {
            _validator.ValidateAndThrow(user);
            _repository.Insert(user);
        }

        public bool DeleteUser(int id) => _repository.Delete(id);

        public IEnumerable<User> GetAllUsers() => _repository.GetAll();

        public User GetUser(int Id) => _repository.GetById(Id);

        public bool UpdateUser(User user)
        {
            _validator.ValidateAndThrow(user);
           return  _repository.Upsert(user);
        }
    }
}
