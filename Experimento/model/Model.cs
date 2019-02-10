using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Model {

        private HeapSort heap;
        private MergeSort merge;


        public Model() {
            heap = new HeapSort();
            merge = new MergeSort();
        }

        public long MergeSort(int size) {
            int[] numbers = generateArray(size);
            int[] arrC = new int[numbers.Length];
            numbers.CopyTo(arrC, 0);
            Array.Sort(arrC);
            long time = nanoTime();
            int[] arr = merge.Sort(numbers, 0, numbers.Length - 1);
            if (Enumerable.SequenceEqual(arr, arrC)) {
                return nanoTime() - time;
            }
            return -1L;
        }

        public long HeapSort(int size) {
            int[] numbers = generateArray(size);
            int[] arrC = new int[numbers.Length];
            numbers.CopyTo(arrC, 0);
            Array.Sort(arrC);
            long time = nanoTime();
            int[] arr = heap.Sort(numbers);
            if (Enumerable.SequenceEqual(arr, arrC)) {
                return nanoTime() - time;
            }
            return -1L;
        }

        private static long nanoTime() {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        public static int[] generateArray(int size) {
            Random random = new Random(DateTime.Now.Millisecond);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++) {
                arr[i] = random.Next();
            }
            return arr;
        }

        static void Main(string[] args) {
        }

    }
}
