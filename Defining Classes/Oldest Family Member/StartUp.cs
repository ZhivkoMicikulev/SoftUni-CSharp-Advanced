
namespace OldestFamilyMember
{
  
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);
                family.AddMember(new Person(name, age));
            }

            HashSet<Person> result = family.GetAllPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}