using System;

class FindPrimes
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // 1 or less is not prime
        if (number <= 3) return true;  // 2 and 3 are prime
        if (number % 2 == 0 || number % 3 == 0) return false; // Divisible by 2 or 3 is not prime

        // Only check divisibility up to the square root of the number
        int i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
            i += 6;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers up to 100:");

        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadKey();
    }
}
