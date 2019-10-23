using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Write an Array");
                var stringArray = Console.ReadLine();
                Console.WriteLine("Your Аrray: ");
                Console.WriteLine(stringArray);


                var intArray = stringArray.Split(' ').Select(x => int.Parse(x.Trim())).ToList();

                var resultArray = new int[5, 3];
                var index = 0;
                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        resultArray[i, j] = intArray[index];
                        index++;
                    }
                }

                for (int i = 0; i < resultArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < resultArray.GetLength(1); j++)
                    {
                        Console.WriteLine("Таблица: ");
                        Console.Write("{0,4} ", resultArray[i, j] + " ");
                    }
                }
            }
        }
    }
}
