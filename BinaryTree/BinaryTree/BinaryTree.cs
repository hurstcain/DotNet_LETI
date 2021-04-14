using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree
    {
        // Корень дерева
        public Node root
        {
            get;
            set;
        }

        // Метод добавляет элемент в дерево
        public void Add(int key)
        {
            Node parent = null;
            Node current = this.root;
            
            while (current != null)
            {
                parent = current;

                if (key < current.key)
                {
                    current = current.left;
                }
                else if (key > current.key)
                {
                    current = current.right;
                }
                else
                {
                    return;
                }

            }

            Node newNode = new Node();
            newNode.key = key;

            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                if (key < parent.key)
                {
                    parent.left = newNode;
                }
                else
                {
                    parent.right = newNode;
                }
            }

            return;
        }

        // Метод удаляет элемент из дерева
        private Node Remove(int key, Node parent)
        {
            if (parent == null) 
            { 
                return parent; 
            }

            // Если удаляемой значение меньше или больше ключа конкретной вершины,
            // то спускаемся вниз по дереву
            if (key < parent.key)
            {
                parent.left = Remove(key, parent.left);
            }
            else if (key > parent.key)
            {
                parent.right = Remove(key, parent.right);
            }
            else
            {
                // Если у найденной вершины нет или только один потомок
                if (parent.left == null)
                {
                    return parent.right;
                }
                else if (parent.right == null)
                {
                    return parent.left;
                }

                parent.key = GetMin(parent.right);
                parent.right = Remove(parent.key, parent.right);
            }

            return parent;
        }

        public void Remove(int key)
        {
            this.root = Remove(key, this.root);
        }

        // Метод нахождения вершины в дереве с указанный млючом key
        private Node Find(int key, Node parent)
        {
            if (parent != null)
            {
                if (key == parent.key)
                {
                    return parent;
                }
                if (key < parent.key)
                {
                    return Find(key, parent.left);
                }
                else
                {
                    return Find(key, parent.right);
                }
            }
            return null;
        }

        public Node Find(int key)
        {
            return this.Find(key, this.root);
        }

        private int GetMin(Node node)
        {
            int min = node.key;

            while (node.left != null)
            {
                min = node.left.key;
                node = node.left;
            }

            return min;
        }
    }
}
