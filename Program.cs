using System;

namespace Arrays_Bruner_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a whole number aor the array size
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
                // Enter a whole number to add to the array
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                // Takes the sum and numbers together
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            // is the sum of the array
            Console.WriteLine($"The sum of the array is {sum}\n");
            // sorts the numbers for each int 
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
