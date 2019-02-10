using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace UnitTestProject
{
    [TestClass]
    public class HeapSortTest
    {

        private HeapSort heap;

        [TestMethod]
        public void Initialize()
        {
            heap = new HeapSort();
        }

        [TestMethod]
        public void SortTest1()
        {
            Initialize();
            //Generate array of length 100
            int[] arr = Model.generateArray(Convert.ToInt16(Math.Pow(10,2)));
            int[] arr1 = new int[arr.Length];
            arr.CopyTo(arr1,0);
            Array.Sort(arr1);
            //Sorting by the algorithm
            int[] arr2 = heap.Sort(arr);
            //Assert that verifies if both arr1 and arr2 are equal (their values at every position)
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(arr1,arr2));
        }

        [TestMethod]
        public void SortTest2()
        {
            Initialize();
            //Generate array of length 10000
            int[] arr = Model.generateArray(Convert.ToInt16(Math.Pow(10, 4)));
            int[] arr1 = new int[arr.Length];
            arr.CopyTo(arr1, 0);
            Array.Sort(arr1);
            //Sorting by the algorithm
            int[] arr2 = heap.Sort(arr);
            //Assert that verifies if both arr1 and arr2 are equal (their values at every position)
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(arr1, arr2));
        }

        [TestMethod]
        public void SortTest3()
        {
            Initialize();
            //Generate array of length 1000000
            int[] arr = Model.generateArray(Convert.ToInt32(Math.Pow(10, 6)));
            int[] arr1 = new int[arr.Length];
            arr.CopyTo(arr1, 0);
            Array.Sort(arr1);
            //Sorting by the algorithm
            int[] arr2 = heap.Sort(arr);
            //Assert that verifies if both arr1 and arr2 are equal (their values at every position)
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(arr1, arr2));
        }

    }
}
