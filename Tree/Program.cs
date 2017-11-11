using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree Data = new Tree();
            //Adding Data in a tree
            Data.Add(12);
            Data.Add(4);
            Data.Add(9);
            Data.Add(50);
            Data.Add(1);

            Console.WriteLine("PreOrder");
            Data.Print();

            Console.WriteLine("Level Order");
            Data.PrintLevelOrder();

            Console.WriteLine("Spiral Order");
            Data.PrintSpiralOrder();
            Data.Search(-1);

            Console.ReadKey();
        }
    }
}
