using System;
using System.Collections.Generic;

namespace ListExample
{
    public class Person{
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public Person(string name, int age, string phoneNumber) {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create list example
            List<Person> list = new List<Person>();

            Person bryce = new Person("Bryce", 26, "(920) 264-4500");
            Person kylie = new Person("Kylie", 22, ("(714) 592-2654"));
            Person everett = new Person("Everett", 1, "None");
            Person owen = new Person("Owen", 29, "(608) 562-5902");
            Person meg = new Person("Meg", 28, "(608) 562-3485");

            list.Add(bryce);
            list.Add(kylie);
            list.Add(everett);
            list.Add(owen);
            list.Add(meg);

            list.Sort(new AgeComparer());

            foreach (Person person in list) {
                Console.WriteLine("Name: {0}\tAge: {1}", person.Name, person.Age);
            }
        }
    }
}
            class AgeComparer : IComparer<(string, int, string)> {
                public int Compare((string, int, string) p1, (string, int, string) p2) {
                    return p1.Item1.Split()[1].CompareTo(p2.Item1.Split()[1]);
                }
            }
