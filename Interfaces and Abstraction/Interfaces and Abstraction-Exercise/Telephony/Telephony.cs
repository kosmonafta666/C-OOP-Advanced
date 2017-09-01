namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Telephony
    {
        public static void Main(string[] args)
        {
            //reda the phone numbers;
            var phoneNumbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            //read the sites;
            var sites = Console.ReadLine()
                .Split(' ')
                .ToList();

            //create smartphone object;
            Smartfone smartPhone = new Smartfone();

            //printing the result;
            foreach (var phone in phoneNumbers)
            {
                Console.WriteLine(smartPhone.Call(phone));
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smartPhone.Browse(site));
            }
        }
    }
}
