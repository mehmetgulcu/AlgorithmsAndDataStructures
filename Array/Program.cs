class Program
{
    static void Main()
    {
        int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

        Console.WriteLine("Dizi Elemanları: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Eleman Arama
        int search = 30;
        int index = Array.IndexOf(numbers, search);

        Console.WriteLine($"{search} değeri dizide {index}. indexte bulundu.");
    }
}