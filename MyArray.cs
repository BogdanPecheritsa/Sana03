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

        public int SumNegative()
        {
            int negativeSum = 0;
            foreach (int num in arr)
            {
                if (num < 0)
                {
                    negativeSum += num;
                }
            }
            return negativeSum;
        }

        public int MinElement()
        {
            int minElement = arr[0];
            foreach (int num in arr)
            {
                if (num < minElement)
                {
                    minElement = num;
                }
            }
            return minElement;
        }

        public int MaxIndex()
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int MaxAbs()
        {
            int maxAbs = 0;
            foreach (int num in arr)
            {
                int absValue = Math.Abs(num);
                if (absValue > maxAbs)
                {
                    maxAbs = absValue;
                }
            }
            return maxAbs;
        }

        public int SumPositiveIndices()
        {
            int positiveIndexSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveIndexSum += i;
                }
            }
            return positiveIndexSum;
        }

        public int CountIntegers()
        {
            int integerCount = 0;
            foreach (int num in arr)
            {
                if (num == (int)num)
                {
                    integerCount++;
                }
            }
            return integerCount;
        }
    }
}