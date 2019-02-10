using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace UnitTestProject
{
    /// <summary>
    /// Descripción resumida de MergeSortTest
    /// </summary>
    [TestClass]
    public class MergeSortTest
    {

        private MergeSort merge;

        [TestMethod]
        public void Initialize()
        {
            merge = new MergeSort();
        }

        [TestMethod]
        public void SortTest1()
        {
            Initialize();
            //Generate array of length 100
            int[] arr = Model.generateArray(Convert.ToInt16(Math.Pow(10, 2)));
            int[] arr1 = new int[arr.Length];
            arr.CopyTo(arr1, 0);
            Array.Sort(arr1);
            //Sorting by the algorithm
            int[] arr2 = merge.Sort(arr,0,arr.Length-1);
            //Assert that verifies if both arr1 and arr2 are equal (their values at every position)
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(arr1, arr2));
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
            int[] arr2 = merge.Sort(arr, 0, arr.Length - 1);
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
            int[] arr2 = merge.Sort(arr,0,arr.Length-1);
            //Assert that verifies if both arr1 and arr2 are equal (their values at every position)
            Assert.IsTrue(System.Linq.Enumerable.SequenceEqual(arr1, arr2));
        }

    }
}
