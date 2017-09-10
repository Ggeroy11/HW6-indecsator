using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SquareArray<T>
    {
        private int[] Array;
        public int this[int i] {
            get
            {
                return Array[i]; 
            }
            set
            {
                Array[i] = value*value;
            }
        } 
        public SquareArray(int size){
            Array=new int [size];
            }
    }
}
