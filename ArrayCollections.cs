using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArrayCollections
    {
        public void ArrayTry()
        {
            //int[] ints = new int[5];
            //Console.WriteLine("Enter 5 numbers");
            //for(int i=0 ; i<ints.Length; i++)
            //{
            //    ints[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The entered array is");
            //foreach (int intt in ints)
            //{
            //    Console.Write(intt+", ");
            //}

            int[] nums = { 23, 56, 12, 67, 59, 67 };
            //int index = Array.IndexOf(nums, 67);
            //Console.WriteLine(index);
            //int lastindex = Array.LastIndexOf(nums, 67);
            //Console.WriteLine(lastindex);
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //int[] copyArr = new int[3];
            //Array.Copy(nums, copyArr, 3);
            //Array.Clear(nums, 0, nums.Length);
            //bool found = Array.Exists(nums, x => x > 12);
            //int high = Array.Find(nums, x => x > 60);
            //Console.WriteLine(high);
            int[] highs = Array.FindAll(nums, x => x > 50);
            Array.ForEach(highs, x => Console.WriteLine(x));
            //int idx = Array.FindIndex(nums, x => x > 90);
            //bool check = Array.TrueForAll(nums, x => x >= 35);
            //Array.Resize(ref nums, 10);
            //Array.ForEach(nums, x => Console.WriteLine(x));
            //foreach (int num in nums)
            //{
            //    Console.Write(num + " ");
            //}
        }

        public void ListTry()
        {
            List<int> nums = new List<int>();
            nums.Insert(0, 23);
            nums.Add(56);
            nums.AddRange(new int[] { 12, 67, 59, 67 });
            nums.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Initial List:");
            nums.ForEach(x => Console.WriteLine(x));

            nums.InsertRange(2, new int[] { 99, 100 });
            Console.WriteLine("\nAfter InsertRange at index 2:");
            nums.ForEach(x => Console.WriteLine(x));

            nums.Remove(67);
            Console.WriteLine("\nAfter Remove(67):");
            nums.ForEach(x => Console.WriteLine(x));

            nums.RemoveAt(0);
            Console.WriteLine("\nAfter RemoveAt(0):");
            nums.ForEach(x => Console.WriteLine(x));

            nums.RemoveRange(1, 2);
            Console.WriteLine("\nAfter RemoveRange(1, 2):");
            nums.ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"\nContains 59? {nums.Contains(59)}");
            Console.WriteLine($"Index of 59: {nums.IndexOf(59)}");
            Console.WriteLine($"Last Index of 67: {nums.LastIndexOf(67)}");

            nums.Sort();
            Console.WriteLine("\nAfter Sort:");
            nums.ForEach(x => Console.WriteLine(x));

            nums.Reverse();
            Console.WriteLine("\nAfter Reverse:");

            Console.WriteLine($"\nFirst number > 50: {nums.Find(n => n > 50)}");
            List<int> bigNums = nums.FindAll(n => n > 50);
            Console.WriteLine("All numbers > 50:");
            bigNums.ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"Any negative numbers? {nums.Exists(n => n < 0)}");

            Console.WriteLine($"\nCapacity: {nums.Capacity}");
            Console.WriteLine($"Count: {nums.Count}");

            int[] arr = nums.ToArray();
            Console.WriteLine("\nArray version:");
            foreach (var n in arr)
                Console.WriteLine(n);

            nums.Clear();
            Console.WriteLine($"\nAfter Clear, Count: {nums.Count}");
        }



        public void DictTry()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Apple");
            dict.Add(2, "Banana");
            dict.Add(3, "Cherry");

            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            dict[4] = "Date";
            dict[2] = "Blueberry";

            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine($"\nContainsKey(3): {dict.ContainsKey(3)}");
            Console.WriteLine($"ContainsKey(10): {dict.ContainsKey(10)}");

            Console.WriteLine($"\nContainsValue(\"Apple\"): {dict.ContainsValue("Apple")}");
            Console.WriteLine($"ContainsValue(\"Mango\"): {dict.ContainsValue("Mango")}");

            if (dict.TryGetValue(1, out string value1))
                Console.WriteLine($"\nTryGetValue(1): Found value '{value1}'");
            else
                Console.WriteLine("\nTryGetValue(1): Key not found");

            if (dict.TryGetValue(99, out string value2))
                Console.WriteLine($"TryGetValue(99): Found value '{value2}'");
            else
                Console.WriteLine("TryGetValue(99): Key not found");

            Console.WriteLine("\nKeys:");
            foreach (var key in dict.Keys)
                Console.WriteLine(key);

            Console.WriteLine("\nValues:");
            foreach (var val in dict.Values)
                Console.WriteLine(val);

            dict.Remove(3);
            Console.WriteLine("\nAfter Remove(3):");
            foreach (var kvp in dict)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            Console.WriteLine($"\nCount: {dict.Count}");

            dict.Clear();
            Console.WriteLine("\nAfter Clear():");
            Console.WriteLine($"Count: {dict.Count}");
        }

        public void HashSetTry()
        {
            HashSet<int> set1 = new HashSet<int>();

            Console.WriteLine("Adding 1: " + set1.Add(1));
            Console.WriteLine("Adding 2: " + set1.Add(2));
            Console.WriteLine("Adding 2 again: " + set1.Add(2));
            Console.WriteLine("Set1: " + string.Join(", ", set1));

            Console.WriteLine("Contains 1? " + set1.Contains(1));
            Console.WriteLine("Contains 5? " + set1.Contains(5));

            Console.WriteLine("Remove 1: " + set1.Remove(1));
            Console.WriteLine("Remove 5: " + set1.Remove(5));
            Console.WriteLine("Set1 after removal: " + string.Join(", ", set1));

            Console.WriteLine("Number of elements: " + set1.Count);

            set1.Clear();
            Console.WriteLine("Set1 after clear: " + string.Join(", ", set1));
            Console.WriteLine("Count after clear: " + set1.Count);

            set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            set1.UnionWith(set2);
            Console.WriteLine("Union: " + string.Join(", ", set1));

            set1 = new HashSet<int>() { 1, 2, 3 };
            set1.IntersectWith(set2);
            Console.WriteLine("Intersection: " + string.Join(", ", set1));

            set1 = new HashSet<int>() { 1, 2, 3 };
            set1.ExceptWith(set2);
            Console.WriteLine("Except: " + string.Join(", ", set1));

            set1 = new HashSet<int>() { 1, 2, 3 };
            set1.SymmetricExceptWith(set2);
            Console.WriteLine("Symmetric Except: " + string.Join(", ", set1));

            Console.WriteLine("{1,2} subset of {1,2,3}? " +
                new HashSet<int>() { 1, 2 }.IsSubsetOf(new HashSet<int>() { 1, 2, 3 }));

            Console.WriteLine("{1,2,3} superset of {1,2}? " +
                new HashSet<int>() { 1, 2, 3 }.IsSupersetOf(new HashSet<int>() { 1, 2 }));

            Console.WriteLine("{1,2,3} overlaps {3,4,5}? " +
                new HashSet<int>() { 1, 2, 3 }.Overlaps(new HashSet<int>() { 3, 4, 5 }));

            Console.WriteLine("{1,2,3} equals {3,2,1}? " +
                new HashSet<int>() { 1, 2, 3 }.SetEquals(new HashSet<int>() { 3, 2, 1 }));
        }

        public void StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder("Hello");

            sb.Append(" World");
            sb.Insert(5, ",");
            sb.Replace("World", "C#");
            sb.Remove(5, 1);

            Console.WriteLine(sb);
            var set =new HashSet<int>();
        }
    }
}