
using System;

namespace SoftUniInjector.Repository
{
    public class DefaultPaymentRepository : IPaymentRepository
    {
        private readonly IAnotherRepository anotherRepository;

        public DefaultPaymentRepository(IAnotherRepository anotherRepo)
        {
            Console.WriteLine("Constructor of payment called!");
            this.anotherRepository = anotherRepo;
        }
       
        public void Pay()
        {
            Console.WriteLine("Payment repo called!");
            this.anotherRepository.AndMe();
        }
    }
}
