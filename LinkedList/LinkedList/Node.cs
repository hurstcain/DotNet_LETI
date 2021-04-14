using System;

namespace LinkedList
{
    // Класс описывает элемент связного списка
    public class Node<T>
    {
        // Элемент списка
        public T Data
        {
            get;
            set;
        }
        // Указатель на следующий элемент в списке
        public Node<T> Next
        {
            get;
            set;
        }
        public Node(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data;
        }
    }
}
