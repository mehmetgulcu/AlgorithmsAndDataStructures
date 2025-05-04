class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("Kitap 1");
        stack.Push("Kitap 2");
        stack.Push("Kitap 3");

        Console.WriteLine("Stack içeriği:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Pop: " + stack.Pop()); // Son giren çıkar 
    }
}