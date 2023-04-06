using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            //int[] array = new int[50];

            ////TODO: Create a method to populate the number array with 50 random numbers
            ////that are between 0 and 50
            //Populater(array);

            ////TODO: Print the first number of the array
            ////Console.WriteLine($"First number: {numbers[0]}");
            //Console.WriteLine($"First number of the array: ");
            //Console.WriteLine(array[0]);

            ////TODO: Print the last number of the array. This can be done in different ways
            ////Console.WriteLine("Last number of the array: ");
            ////Console.WriteLine($"Last number: {numbers[49]}");
            //Console.WriteLine("Last number of the array: ");
            //Console.WriteLine(array[array.Length - 1]);
            ////or Console.WriteLine({^1});

            //Console.WriteLine("All Numbers Original");
            ////UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter(array);
            //Console.WriteLine("-------------------");

            ////TODO: Reverse the contents of the array and then print the array out to the console.
            ////Try for 2 different ways
            ///*  1) First way, using a built-in method => Hint: Array._____(); 
            //    2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            //*/
            ////Array.Reverse(numbers);
            //var copiedArray = array;

            //Console.WriteLine("All Numbers Reversed:");
            //Array.Reverse(array);
            //NumberPrinter(array);

            //Console.WriteLine("---------REVERSE CUSTOM------------");
            //ReverseArray(array);

            //Console.WriteLine("-------------------");


            ////TODO: Create a method that will set numbers that are a multiple
            ////of 3 to zero then print to the console all numbers
            //Console.WriteLine("Multiple of three = 0: ");
            //ResetMultiplesOfThreeToZero(array);
            //NumberPrinter(array);
            
            //Console.WriteLine("-------------------");

            ////TODO: Sort the array in order now
            ///*      Hint: Array.____()      */
            //Console.WriteLine("Sorted numbers:");
            //Array.Sort(array);
            //NumberPrinter(array);

            //Console.WriteLine("\n************End Arrays*************** \n");


            #endregion 

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"The capacity of my list: ");
            Console.WriteLine(list.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("All numbers in my list: ");
            Populater(list);
            NumberPrinter(list);

            //TODO: Print the new capacity
            Console.WriteLine($"The new capacity of my list: ");
            Console.WriteLine(list.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" by accident your app should handle that!
            Console.WriteLine("What number are you looking for in the number list?");
            bool isNumber = int.TryParse(Console.ReadLine(), out int numberToLookFor);
            NumberChecker(list, numberToLookFor); 
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);
            
            Console.WriteLine("------------------");


            //TODO: Convert the list to an array and store that into a variable
            int[] converted = list.ToArray();


            //TODO: Clear the list
            list.Clear();
            Console.WriteLine("The list is clear");
            NumberPrinter(list);
            

            #endregion
        }

        private static void ResetMultiplesOfThreeToZero(int[] numbers)
        {
            for(var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            string message = "Yes, your number is in the list.";
            for (int i = 0; i < numberList.Count; i++)
            {

                if (numberList[i] == searchNumber)
                {
                    message = "Yes, your number is in the list.";
                }
            }
            Console.WriteLine(message);
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 1; i <= 50; i++)
            {
                int randomNumber = rng.Next(1, 51);
                numberList.Add(randomNumber);
            }
        }

        private static void Populater(int[] numbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers
            //that are between 0 and 50

            Random rng = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                int randomNumber = rng.Next(0, 51);
                numbers[i] = randomNumber;
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }

            NumberPrinter(newArray);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
