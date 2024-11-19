using System;

namespace LAb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set1 = new Set<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Set1: " + set1);
            Console.WriteLine("Count of Set1: " + set1.Count);

            Set<int> setWithDuplicates = new Set<int>(new[] { 1, 2, 2, 3, 3, 4 });
            Set<int> uniqueSet = setWithDuplicates.RemoveDuplicates();
            Console.WriteLine("Set with duplicates: " + setWithDuplicates);
            Console.WriteLine("Set without duplicates: " + uniqueSet);
        }
    }
}