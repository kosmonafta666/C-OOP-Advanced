
using System;

namespace SoftUniInjector.Repository
{
    public class DefaultUserRepository : IUserRepository
    {
        private readonly IPaymentRepository paymentRepository;

        private readonly ISoftUniRepository softUniRepository;

        public DefaultUserRepository(IPaymentRepository payRepo, ISoftUniRepository softRepo)
        {
            this.paymentRepository = payRepo;
            this.softUniRepository = softRepo;
        }

        public void Print()
        {
            Console.WriteLine($"User repo called!");
            Console.WriteLine($"User repo calling payment repo");
            this.paymentRepository.Pay();
            Console.WriteLine($"User repo also calling also softuni repo");
            this.softUniRepository.Oop();
        }
    }
}
