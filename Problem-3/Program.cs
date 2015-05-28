/*
 *   Project Euler: Problem 3
 *   Alex Curran 
 *   
 *   The prime factors of 13195 are 5, 7, 13 and 29.
 *   What is the largest prime factor of the number 600851475143 ?
 *   
 *  https://projecteuler.net/problem=3
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
           long number = 600851475143;
           long largest = primeFactorization(number);

           Console.WriteLine("Largest prime factor is {0}", largest);

        }

        /// <summary>
        /// Trial division prime factorization method
        /// </summary>
        /// <param name="number">Number to be factorerd</param>
        private static long primeFactorization(long number)
        {
            long tempNumber = number;
            long largestFact = 0;

            int counter = 2;
            while (counter * counter <= tempNumber)
            {
                if (tempNumber % counter == 0)
                {
                    tempNumber = tempNumber / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (tempNumber> largestFact)
            { 
                largestFact = tempNumber;
            }

            return largestFact;
               
        }
    }
}
