
using SoftUniInjector.Repository;
using System;

namespace SoftUniInjector.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly ISoftUniRepository softUnirepository;

        public UserService(IUserRepository userRepo, ISoftUniRepository softUniRepo)
        {
            this.userRepository = userRepo;
            this.softUnirepository = softUniRepo;
        }

        public void Rename()
        {
            Console.WriteLine($"User service called!");
            Console.WriteLine($"User service calls user repo");
            this.userRepository.Print();
            Console.WriteLine($"User service calls also softuni repo");
            this.softUnirepository.Oop();
        }
    }
}
