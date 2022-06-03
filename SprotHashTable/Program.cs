using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BadHashTable");
            var table = new BadHashTable<int>(100);
            table.Add(5);
            table.Add(18);
            table.Add(777);


            Console.WriteLine(table.Search(6));
            Console.WriteLine(table.Search(18));

            Console.WriteLine("HashTable:");

            var hashtable = new HashTable<int,string>(100);
            hashtable.Add(5, "Привет");
            hashtable.Add(18, "Мир");
            hashtable.Add(777, "Здравствуй");
            hashtable.Add(7, "Программист");


            Console.WriteLine(hashtable.Search(6, "Вася"));
            Console.WriteLine(hashtable.Search(18, "Мир"));

            Console.WriteLine("SuperHashTable");
            var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
            var Hashtable = new SuperHashTable<Person>(100);
            Hashtable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0});
            Hashtable.Add(new Person() { Name = "Андрей", Age = 15, Gender = 0 });
            Hashtable.Add(new Person() { Name = "Катя", Age = 18, Gender = 1 });
            Hashtable.Add(person);

            Console.WriteLine(Hashtable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(Hashtable.Search(person));
            Console.ReadLine();

        }
    }
}
