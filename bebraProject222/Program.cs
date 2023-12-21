using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebraProject222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] existingArray = { -2, -4, 0, 1, 2, 3, 4, 5 };
            List<int> numbersList = existingArray.ToList();

            for (int i = 0; i  < numbersList.Count; i++)
            {
                if (numbersList[i] > 0)
                {
                    numbersList.Remove(numbersList[i]);
                }
            }

            Console.WriteLine("Положительные элементы: ");
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
