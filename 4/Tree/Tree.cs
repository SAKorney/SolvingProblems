using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTree
{
    class Tree<T>
    {
        public Tree<T> Left { get; set; }
        public Tree<T> Right { get; set; }
        public T Value { get; set; }

        public Tree(T value)
        {
            Value = value;
        }        

        public static IEnumerable<T> TreeTraversal(Tree<T> root, Func<Tree<T>, IEnumerable<T>> algorithm)
        {
            return algorithm(root);
        }

        public static IEnumerable<T> PreOrdered(Tree<T> root)
        {
            yield return root.Value;

            if (root.Left != null)
            {
                foreach (var value in PreOrdered(root.Left))
                {
                    yield return value;
                }
            }

            if (root.Right != null)
            {
                foreach (var value in PreOrdered(root.Right))
                {
                    yield return value;
                }
            }
        }
        public static IEnumerable<T> InOrdered(Tree<T> root)
        {
            if (root.Left != null)
            {
                foreach (var value in InOrdered(root.Left))
                {
                    yield return value;
                }
            }

            yield return root.Value;

            if (root.Right != null)
            {
                foreach (var value in InOrdered(root.Right))
                {
                    yield return value;
                }
            }
        }
        public static IEnumerable<T> PostOrdered(Tree<T> root)
        {
            if (root.Left != null)
            {
                foreach (var value in PostOrdered(root.Left))
                {
                    yield return value;
                }
            }

            if (root.Right != null)
            {
                foreach (var value in PostOrdered(root.Right))
                {
                    yield return value;
                }
            }

            yield return root.Value;
        }
    }
}
