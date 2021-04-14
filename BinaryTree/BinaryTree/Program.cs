using System;

namespace BinaryTree
{

    class Program
    {
        static readonly int COUNT = 5;

        static void PrintTree(Node root, int space_count = 0)
        {
            // Если корень пустой, то ничего не выводим
            if (root == null)
                return;

            space_count += COUNT;

            PrintTree(root.right, space_count);

            Console.Write("\n");
            for (int i = COUNT; i < space_count; i++)
                Console.Write(" ");
            Console.Write(root.key + "\n");

            PrintTree(root.left, space_count);
        }

        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
 
            binaryTree.Add(10);
            binaryTree.Add(2);
            binaryTree.Add(22);
            binaryTree.Add(4);
            binaryTree.Add(12);
            binaryTree.Add(11);
            binaryTree.Add(6);
            binaryTree.Add(13);
            binaryTree.Add(5);
            binaryTree.Add(1);

            PrintTree(binaryTree.root);
            Console.Write("-----------------------------------------------------------");

            binaryTree.Remove(22);
            PrintTree(binaryTree.root);
            Console.Write("-----------------------------------------------------------");

            PrintTree(binaryTree.Find(4));
            Console.Write("-----------------------------------------------------------");
        }
    }
}
