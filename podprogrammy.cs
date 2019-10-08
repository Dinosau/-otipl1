

4.1 Задача - нарисовать треугольник из звёздочек
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void LineStar(int n)
        {
            for (int k = 1; k <= n; k++)
                Console.Write("*" + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type the Lenght of the triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {

                LineStar(i);

            }

        }
    }
}




4.2
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {

        static int[] inputar()
        {

            string text0;
            text0 = Console.ReadLine();

            string[] arr1 = text0.Split(' ');
            int n = arr1.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(arr1[i]);
            return arr;

        }

        static void outputar(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            Console.Write(a[i] + " ");
            Console.WriteLine();
        }

    

        static int summ(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; ++i)
                sum += a[i];
            return sum;
        }



        static void Main(string[] args)
        {  

           for (int i = 0; i <= 3; i++)
            {
         
                Console.WriteLine("Type an array: ");
                int[] num = inputar();
                outputar(num);
                Console.Write("Sum is "); 
                Console.WriteLine(summ(num));
             }


            Console.WriteLine("Sum of all");
        }
    }
}




4.3
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{

    class Program
    {
        static bool IsFullSquare(int n, out int root)
        {
            root = 0;

            if (n < 0)
                return false;

            root = (int)Math.Sqrt(n);

            return root * root == n;
        }

        static void Main(string[] args)
        {
            Console.Write("Input low bound: ");
            int low = int.Parse(Console.ReadLine());

            Console.Write("Input hi bound: ");
            int hi = int.Parse(Console.ReadLine());

            for (int n = low; n <= hi; n++)
            {
                if (IsFullSquare(n, out int root))
                    Console.WriteLine("{0} {1}", n, root);
            }
        }
    }
}
