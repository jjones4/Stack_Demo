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
            Console.WriteLine(intStack.PopData());
            Console.WriteLine(intStack.PopData());
            Console.WriteLine(intStack.PopData());
            Console.WriteLine();

            CustomStack<string> stringStack = new CustomStack<string>();
            stringStack.PushData("A");
            stringStack.PushData("B");
            stringStack.PushData("C");
            Console.WriteLine(stringStack.PopData());
            Console.WriteLine(stringStack.PopData());
            Console.WriteLine(stringStack.PopData());
        }
    }
}