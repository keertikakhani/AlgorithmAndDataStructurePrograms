using System;

namespace AlgorithmAndDataStructurePrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            InsertionSort insertion = new InsertionSort();
            insertion.Display();

            BubbleSort bubble = new BubbleSort();
            bubble.DisplayNumbers();
        }
    }

}
