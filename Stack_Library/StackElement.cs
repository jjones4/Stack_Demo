using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library
{
    internal class StackElement<T>
    {
        internal StackElement<T>? Next { get; set; }
        internal T Data { get; set; }

        internal StackElement(StackElement<T>? next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
