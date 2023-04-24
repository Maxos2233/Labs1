using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> numbers = new List<float>() { 1, 0, 12, -33, 6};
            var min = numbers[0];
            var max = numbers[0];

            var positionMax = 0;
            var positionMin = 0;
            float copyofi = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                    positionMax = i;
                }

                if (min > numbers[i])
                {
                    min = numbers[i];
                    positionMin = i;
                }

            }

            var averageMinMax = (min + max) / 2;
            
            foreach (int i in numbers)
            {
                copyofi += i;
            }

            var averageNumbers = copyofi / numbers.Count;

            
            Console.WriteLine(min + " " + positionMin);
            Console.WriteLine(max + " " + positionMax);
            Console.WriteLine(averageNumbers);
            Console.WriteLine(averageMinMax);
            Console.ReadKey();
        }
    }
}
