using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            

            var LFruits = from fruit in fruits
                          where fruit.StartsWith("L")
                          select fruit;

            foreach(var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => (number % 4 == 0 || number % 6 == 0));

            foreach (var foursix in fourSixMultiples)
            {
                Console.WriteLine(foursix);
            }
            Console.ReadLine();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var descend = names.OrderByDescending(name => name);
                         
            foreach(var name in descend)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var ascending = from number in numbers2
                            orderby number
                            select number;

            foreach(var number in ascending)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
