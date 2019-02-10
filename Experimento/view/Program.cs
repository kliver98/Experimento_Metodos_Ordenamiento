using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace view
{
    class Program
    {

        private Model model;

        public Program()
        {
            model = new Model();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int size = (int)Math.Pow(10, 6);

            Console.WriteLine("El merge sort con un arreglo de tamaño {0}, Se demoro {1}Ns",size ,p.model.MergeSort(size));
            Console.WriteLine("El heap sort con un arreglo de tamaño {0}, Se demoro {1}Ns", size, p.model.HeapSort(size));
        }
    }
}
