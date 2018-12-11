using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            List<int> numero = new List<int>();
            int[] array = new int[] { 1, 2, 3 };
            numbers.AddRange(array);

            List<string> fruits = new List<string>();

            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("Orange");

            fruits.Remove("banana");
            fruits.RemoveAt(1);
            Console.WriteLine(fruits.Count);
            

            List<string> food = new List<string>();
            food.Add("apple");
            food.Add("banana");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            food.AddRange(vegetables);
            Console.WriteLine(food.Count);

            List<string> phone = new List<string>();
            phone.Add("317-555-001");
            phone.Add("317-555-002");
            phone.Add("317-555-003");
            phone.Add("317-555-004");
            phone.Add("317-555-005");
            phone.Add("317-555-006");
            phone.Add("317-555-007");
            phone.Add("317-555-008");
            phone.Add("317-555-009");
            phone.Add("317-555-010");

            foreach (string number in phone)
            {
                Console.WriteLine(number);
            }

            foreach (string number in phone)
            {
                if (number == "317-555-002")
                {
                    Console.WriteLine("This is Paul's number");
                }
            }

            Console.ReadLine();
        }
    }
}
