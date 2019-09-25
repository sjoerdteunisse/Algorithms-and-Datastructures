using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Core.ADT
{
    //O1 best case
    //oN avg
    public class MyStack<T> : IMyStack<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        public void Push(T element)
        {
            _list.AddFirst(element);
        }

        public void Pop()
        {
            _list.RemoveFirst();
        }

        public T Peek()
        {
            return _list.First.Value;
        }

        public void RemoveAll()
        {
            _list.Clear();
        }

        public int Size()
        {
            return _list.Count;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }
    }
}
