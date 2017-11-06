﻿using System;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }
            prime[0] = false;
            prime[1] = false;
            
            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {                    
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int p = 2; p <= n; p++)
                if (prime[p])
                {
                    Console.Write(p + " ");
                }
        }
    }
}