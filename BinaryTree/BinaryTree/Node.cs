using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    // Класс описывает вершину дерева
    public class Node
    {
        // Левый потомок вершины
        public Node left
        {
            get;
            set;
        }
        // Правый потомок вершины
        public Node right
        {
            get;
            set;
        }
        // Ключ вершины
        public int key
        {
            get;
            set;
        }
    }
}
