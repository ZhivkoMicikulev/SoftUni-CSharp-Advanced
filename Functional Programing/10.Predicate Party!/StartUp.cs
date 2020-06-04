using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Predicate_Party_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var peopleComing = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string comand;
            while ((comand=Console.ReadLine())!="Party!")
            {
                var tokens = comand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cmdType = tokens[0];
               var predicateArgs = tokens
                    .Skip(1)
                    .ToArray();
                Predicate<string> predicate = GetPredicate(predicateArgs);
                if (cmdType=="Remove")
                {
                    peopleComing.RemoveAll(predicate);
                }
                else if (cmdType=="Double")
                {
                    DoubleGuests(peopleComing, predicate);
                }
            }
            if (peopleComing.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else 
            {
                Console.WriteLine(string.Join(", ",peopleComing)+" are going to the party!");
            }
        }

        private static void DoubleGuests(List<string> peopleComing, Predicate<string> predicate)
        {
            for (int i = 0; i < peopleComing.Count; i++)
            {
                var currGuest = peopleComing[i];
                if (predicate(currGuest))
                {
                    peopleComing.Insert(i + 1, currGuest);
                    i++;
                }
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            var prType = predicateArgs[0];
            var prArg = predicateArgs[1];
            Predicate<string> predicate = null;
            if (prType=="StartsWith")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.StartsWith(prArg);
  
                  });
            }
            else if (prType=="EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.EndsWith(prArg);
                  });
            }
            else if (prType=="Length")
            {
                predicate = new Predicate<string>((name) =>
                  {
                      return name.Length == int.Parse(prArg);
                  });
            }
            return predicate;
        }
    }
}
