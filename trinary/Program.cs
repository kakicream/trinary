using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace trinary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Solution(int n)
            {
                int answer = 0;

                List<int> trinary = new List<int>();
                // Calculate how many times to divide
                int divideCount = 0;
                int dividingNum = n;

                for (int i = 0; i < int.MaxValue; i++)
                {
                    Console.WriteLine($"n before division : {dividingNum}");
                    if (dividingNum > 0)
                    {
                        divideCount++;
                        dividingNum /= 3;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine($"divideCount : {divideCount}");

                // Convert to trinary >> Add to List
                for (int i = 0; i < divideCount; i++)
                {
                    if (n / 3 >= 0)
                    {
                        trinary.Add(n % 3);
                        Console.WriteLine($"Remainder Added : {n % 3}");
                        n /= 3;
                    }
                }

                // Reverse the List 
                for (int i = 0; i < trinary.Count; i++)
                {
                    Console.WriteLine($"Number at Index{i} : {trinary[i]}");
                }

                trinary.Reverse();
                Console.WriteLine("Reversed");

                for (int i = 0; i < trinary.Count; i++)
                {
                    Console.WriteLine($"Number at Index{i} : {trinary[i]}");
                }

                /* If you don't want to reverse the list, then use below
                for (int i = 0; i < trinary.Count; i++)
                {
                    answer += (int)(trinary[i] * Math.Pow(3, trinary.Count - i-1));
                }
                */

                // Convert back to 10 digits
                for (int i = 0; i < trinary.Count; i++)
                {
                    answer += (int)(trinary[i] * Math.Pow(3, i));
                    Console.WriteLine($"Add : {answer}");
                }
                return answer;
            }
        }
    }
}
