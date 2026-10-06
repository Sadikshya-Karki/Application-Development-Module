class SDArray
{
    static void Main()
    {
        int[] numbers = { 57, 23, 12, 38, 74 };
        
        Array.Sort(numbers);
        Console.WriteLine("Sorted arrays:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        Array.Reverse(numbers);
        Console.WriteLine("Reversed arrays:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Index of 12: " + Array.IndexOf(numbers, 12));
    }
}