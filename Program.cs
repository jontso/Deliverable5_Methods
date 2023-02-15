/*
Author: Jonathan Tsokos
Date: 2/14/2023
Description: C# Console Application using Methods
*/


using System;

namespace deliverable_5_Methods
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 15");
            try
            {
                int input = int.Parse(Console.ReadLine());

                if ((input >= 5) && (input <= 15))
                {
                    int[] sampleArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in sampleArray)
                    {
                        Console.WriteLine(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                else
                {
                    Console.WriteLine("This program only accepts numbers between 5 and 15");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value next time");
            }
        }
    }
}