namespace Stack_Library
{
    public class StackElement<T>
    {
        public StackElement<T>? Next { get; set; }
        public T Data { get; set; }

        public StackElement(StackElement<T>? next, T data)
        {
            Next = next;
            Data = data;
        }
    }
}
