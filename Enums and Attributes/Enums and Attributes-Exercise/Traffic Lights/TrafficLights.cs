namespace Traffic_Lights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TrafficLights
    {
        public static void Main(string[] args)
        {
            //read the current trafic lights;
            var currentLights = Console.ReadLine()
                .Split(' ');

            //read the number of iterations of lights;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < currentLights.Length; j++)
                {
                    //take position of the current light;
                    var state = (int)Enum.Parse(typeof(Lights), currentLights[j]);
                    //take lenght of the light enum;
                    var lightsCount = Enum.GetNames(typeof(Lights)).Length;
                    //asigh new position of the light;
                    currentLights[j] = ((Lights)(++state % lightsCount)).ToString();
                }

                //print the current state of the lights;
                Console.WriteLine(string.Join(" ", currentLights));
            }
        }
    }
}
