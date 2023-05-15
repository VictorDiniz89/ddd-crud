using Domain.Services;
using LiteDB;
using API.Services;
using Infrastructure.Database;
using Domain.Entities;
using System.Security.Cryptography;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //DB Setup Context
            var db = new LiteDatabase(@"ddd.db");
            IRepository<User> repository = new UserRepository(db);

            // Seeding for testing
            if (repository.GetAll().Any() == false)
            {
                //populateDatabase(repository);
            }

            // Add User service to scope.
            builder.Services.AddScoped<IUserService, UserService>(f => new UserService(repository));

            // Add services to the container.
            builder.Services.AddControllers();

            // Swagger enabled
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            // Configure CORS to interact with Frontend.
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Origins", policy =>
                {
                    policy
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            var app = builder.Build();
            app.UseCors("Origins");
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }

        private static void populateDatabase(IRepository<User> repository)
        {

            repository.Insert(
                new User(
                    1,
                    "Mr",
                    "Victor",
                    "Diniz",
                    "victordiniz@gmail.com",
                    "Admin"
                    ));

            repository.Insert(
                new User(
                    2,
                    "Ms",
                    "Susan",
                    "Smith",
                    "susan-smith@gmail.com",
                    "User"
                ));
        }
    }

}
