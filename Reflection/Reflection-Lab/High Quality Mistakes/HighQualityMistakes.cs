namespace High_Quality_Mistakes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HighQualityMistakes
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();

            var result = spy.AnalyzeAcessModifiers("Hacker");

            Console.WriteLine(result);
        }
    }
}
