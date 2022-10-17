using System;
using System.Collections.Generic;

namespace ArraysAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4};

            string[] words = { "Apple", "Ball", "Bat", "Ship", "Sea" };

            List<int> arrayList = new List<int> { 1, 2, 3};
            arrayList.Add(4);
            arrayList.Remove(1);
            arrayList.Insert(0, 1);

            DisplayElements(numbers);
            DisplayElements(words);
            printNums(numbers);
            printList(arrayList);
            AddList(arrayList);
            

        }

        //can use for any data type
        public static void DisplayElements<T>(T[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //can use only for the int data type
        public static int printNums(int[] array)
        {
           for(var i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           return array.Length;
        }

        public static List<int> printList(List<int> arrayList)
        {
            for(int j=0; j<arrayList.Count; j++)
            {
                Console.WriteLine(arrayList[j]);
            }
            return null;
        }

        public static List<int> AddList(List<int> arrayLists)
        {
            List<int> numberList = new List<int>();

            for (int x = 0; x < arrayLists.Count; x++)
            {
                numberList.Add(1);
                Console.WriteLine(numberList[x]);
            }
            return null;
        }
    }
}
