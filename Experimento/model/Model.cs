using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Model
    {

        private HeapSort heap;
        private MergeSort merge;

        public Model()
        {
            heap = new HeapSort();
            merge = new MergeSort();
        }

        public long MergeSort(int[] numbers, int left, int right)
        {
            long time = nanoTime();
            int[] arrC = new int[numbers.Length];
            numbers.CopyTo(arrC, 0);
            int[] arr = merge.Sort(numbers,left,right);
            if (Enumerable.SequenceEqual(arr, arrC))
            {
                return nanoTime() - time;
            }
            return -1L;
        }

        public long HeapSort(int[] numbers)
        {
            long time = nanoTime();
            int[] arrC = new int[numbers.Length];
            numbers.CopyTo(arrC,0);
            int[] arr = heap.Sort(numbers);
            Array.Sort(arrC);
            if (Enumerable.SequenceEqual(arr,arrC))
            {
                return nanoTime()-time;
            }
            return -1L;
        }

        private static long nanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        static void Main(string[] args)
        {
            
        }

    }
}
