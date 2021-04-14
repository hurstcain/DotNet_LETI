using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head = null; // Первый элемент списка
        private Node<T> tail = null; // Последний элемент списка
        private int count = 0; // Количество элементов в списке

        // Добаление элемента в список
        public void Add(T data)
        {
            // Проверка входных данных на null
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Node<T> node = new Node<T>(data);

            // Если начальный элемент списка пуст, то добавляем новый элемент в начало
            // Иначе присваиваем элемент свойству tail.Next
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            // Устанавливаем новый элемент как конечный в списке
            tail = node;
            // Увеличиваем количество элементов на единицу
            count++;
        }

        // Удаление элемента из списка. Удаляется первый попавшийся элемент со значением data
        public void Remove(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Текущий проверяемый элемент в списке
            Node<T> current = head;
            // Предыдущий элемент в списке
            Node<T> previous = null;

            // Цикл выполняется, пока не пройдется по всем элементам списка,
            // либо пока не будет найден элемент со значением, аналогичным data
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                    break;
                }
                previous = current;
                current = current.Next;
            }
        }

        // Метод реверсирования списка
        public void Reverse()
        {
            Node<T> previous = null;
            Node<T> current = head;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
