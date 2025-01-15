using System;

class Program
{
    static void SieveOfEratosthenes(int limit)
    {
        bool[] prime = new bool[limit + 1];

        for (int i = 2; i <= limit; i++)
        {
            prime[i] = true;
        }

        for (int p = 2; p * p <= limit; p++)
        {
            if (prime[p] == true)
            {
                for (int i = p * p; i <= limit; i += p)
                {
                    prime[i] = false;
                }
            }
        }

        Console.WriteLine($"Prime numbers between 1 and {limit}:");
        for (int i = 2; i <= limit; i++)
        {
            if (prime[i] == true)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a number to find all prime numbers between 1 and that number: ");
        int limit = int.Parse(Console.ReadLine());

        if (limit < 2)
        {
            Console.WriteLine("There are no prime numbers less than 2.");
        }
        else
        {
            SieveOfEratosthenes(limit);
        }
    }
}