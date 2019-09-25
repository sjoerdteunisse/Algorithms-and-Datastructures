using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ADS.Core.ADT
{
    interface IMyStack<T>
    {
        void Push(T element);
        void Pop();
        T Peek();
        int Size();
        bool IsEmpty();

    }
}
