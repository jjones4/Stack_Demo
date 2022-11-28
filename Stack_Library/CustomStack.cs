using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Library
{
    public class CustomStack<T>
    {
        StackElement<T>? _top;

        public void PushData(T data)
        {
            Console.WriteLine($"We are pushing {data} onto the stack.");
            _top = new StackElement<T>(_top, data);
        }

        public T PopData()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }

            T result = _top.Data;
            _top = _top.Next;

            return result;
        }
    }
}
