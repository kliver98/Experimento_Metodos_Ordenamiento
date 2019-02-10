using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    //Implementation taked it from http://csharpexamples.com/c-merge-sort-algorithm-implementation/
    public class MergeSort
    {
        private void Merge(int[] numbers, int left, int mid, int right)
        {

            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            Array.Copy(numbers, left, leftArray, 0, mid - left + 1);
            Array.Copy(numbers, mid + 1, rightArray, 0, right - mid);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    numbers[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    numbers[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    numbers[k] = leftArray[i];
                    i++;
                }
                else
                {
                    numbers[k] = rightArray[j];
                    j++;
                }
            }
        }

        public int[] Sort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(numbers, left, middle);
                Sort(numbers, middle + 1, right);

                Merge(numbers, left, middle, right);
            }
            return numbers;
        }

    }
}
