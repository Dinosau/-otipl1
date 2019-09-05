

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
      static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                    Console.Write("*" + " ");
                Console.WriteLine();
            }
        }
      
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        DrawPyramid(a);
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
      static void outputar(int[] a)
      {
          for(int i = 0; i < a.Length; ++i)
              Console.WriteLine(a[i] + " ");
          Console.WriteLine();
      }
      
      int summ(int[] a)
      {
          int sum = 0;
          for(int i = 0; i < a.Length; ++i)
              sum += a[i];
          return sum;
      }
      
  /*    static void inputar(out int[] mas)
      {
          int n = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int [n];
        for(int i = 0; i < mas.Length; ++i)
            mas[i] = Convert.ToInt32(Console.ReadLine());
        outputar(mas);
        Console.Write(summ(mas));
      }
    */ 
    static void Main(string[] args)
    {
  //      inputar();
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
      static void my_sqrt(out bool h,  out int sqrtN, int n)
      {
          int k = Convert.ToInt32(Math.Sqrt(n));
          if(k * k == n)
          {
              h = true;
              sqrtN = k;
          }
          else 
          {
              h = false;
              sqrtN = 0;
          }
      }
    static void Main(string[] args)
    {
        int n, a, b;
        n = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        bool h;
        int sqrtN;
        if(n < 0)
            n *= -1;
        my_sqrt(out h, out sqrtN, n);
        if(n == 0)
            h = false;
        if(h)
            Console.WriteLine("true " + sqrtN);
        else
            Console.WriteLine("false");
        while(a <= b)
        {
           // bool h1;
            my_sqrt(out h, out sqrtN, a);
            if(h)
                Console.Write(a + " ");
            ++a;
        }
    }
  }
}


