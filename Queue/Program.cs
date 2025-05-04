class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Müşteri 1");
        queue.Enqueue("Müşteri 2");
        queue.Enqueue("Müşteri 3");

        Console.WriteLine("Queue İçeriği:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Dequeue: " + queue.Dequeue());
    }
}