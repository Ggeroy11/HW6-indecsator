using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
          
            SquareArray<int> array = new SquareArray<int> (size);
            array[0]=2;
            Console.WriteLine("Число 2 возведенное в квадрат ={0}",array[0]);
            Console.ReadLine();
        }
    }
}
