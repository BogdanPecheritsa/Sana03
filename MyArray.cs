using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana03
{
    public class MyArray
    {
        public int[] arr;

        public MyArray(int count)
        {
            arr = new int[count];
            Random rand = new();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
        }
    }
}