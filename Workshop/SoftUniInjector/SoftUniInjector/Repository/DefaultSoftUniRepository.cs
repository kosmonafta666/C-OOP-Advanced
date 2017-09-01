
using System;

namespace SoftUniInjector.Repository
{
    public class DefaultSoftUniRepository : ISoftUniRepository
    {
        private readonly IPaymentRepository paymentRepository;

        public DefaultSoftUniRepository(IPaymentRepository paymentRepo)
        {
            this.paymentRepository = paymentRepo;
        }

        public void Oop()
        {
            Console.WriteLine($"Softuni repo called!");
            Console.WriteLine($"Softuni repo tries to call payment repo");
            this.paymentRepository.Pay();
        }
    }
}
