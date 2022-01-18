using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var iArr = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(iArr);

            //Print the first number of the array
            Console.WriteLine(iArr[0]);
            //Print the last number of the array
            Console.WriteLine(iArr[iArr.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(iArr);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Array.Reverse(iArr);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(iArr);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            ThreeKiller(iArr);
            Console.WriteLine($"Multiple of three = {iArr.Length}: ");
            NumberPrinter(iArr);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(iArr);
            NumberPrinter(iArr);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var iList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(iList.Count);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(iList);

            //Print the new capacity
            Console.WriteLine(iList.Count);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            var succInput = false;
            var uInput = 0;
            while (succInput == false)
            {
                Console.Write("What number will you search for in the number list? ");
                succInput = int.TryParse(Console.ReadLine(), out uInput);
            }
            NumberChecker(iList, uInput);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(iList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(iList);
            NumberPrinter(iList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            iList.Sort();
            Console.WriteLine("Sorted Evens!!");
            NumberPrinter(iList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var listNowArray = iList.ToArray();

            //Clear the list
            iList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            var count = 0;
            foreach(var n in numberList)
            {
                if (n == searchNumber)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} matches found!");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            var temp = 0;
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            //Used .Sort();
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
