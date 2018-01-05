using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> root = new Tree<int>(0);
            Tree<int> l0 = new Tree<int>(1);
            Tree<int> r0 = new Tree<int>(2);
            root.Left = l0;
            root.Right = r0;

            Tree<int> l1 = new Tree<int>(3);
            Tree<int> r1 = new Tree<int>(4);
            Tree<int> l2 = new Tree<int>(5);            
            l0.Right = r1;
            l0.Left = l1;
            r0.Left = l2;

            foreach (var item in Tree<int>.TreeTraversal(root, Tree<int>.InOrdered))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
