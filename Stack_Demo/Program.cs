using Stack_Library;

namespace Stack_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> intStack = new CustomStack<int>();
            intStack.PushData(1);
            intStack.PushData(2);
            intStack.PushData(3);

            Console.WriteLine();

            Console.WriteLine($"We are popping {intStack.PopData()} from the stack.");
            Console.WriteLine($"We are popping {intStack.PopData()} from the stack.");
            Console.WriteLine($"We are popping {intStack.PopData()} from the stack.");

            Console.WriteLine();

            CustomStack<string> stringStack = new CustomStack<string>();
            stringStack.PushData("A");
            stringStack.PushData("B");
            stringStack.PushData("C");

            Console.WriteLine();

            Console.WriteLine($"We are popping {stringStack.PopData()} from the stack.");
            Console.WriteLine($"We are popping {stringStack.PopData()} from the stack.");
            Console.WriteLine($"We are popping {stringStack.PopData()} from the stack.");
        }
    }
}