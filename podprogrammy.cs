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
