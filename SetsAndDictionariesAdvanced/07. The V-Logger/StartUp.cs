using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._The_V_Logger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string comand;
            var youTube = new Dictionary<string,List<int>>();
            var followers = new Dictionary<string, List<string>>();
            
            while ((comand=Console.ReadLine())!= "Statistics")
            {
                var tokens = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var vloger = tokens[0];
                var toDo = tokens[1];
                if (toDo=="joined")
                {
                    if (!youTube.ContainsKey(vloger))
                    {
                        youTube[vloger] = new List<int>();
                        youTube[vloger].Add(0);
                        youTube[vloger].Add(0);
                        followers[vloger] = new List<string>();
                    }
                }
               //0 folowers 1 folowing
                else if (toDo=="followed")
                {
                    var secondVloger = tokens[2];
                    if (vloger!=secondVloger 
                        && youTube.ContainsKey(vloger) 
                        && youTube.ContainsKey(secondVloger)
                        && !followers[secondVloger].Contains(vloger))
                    {
                        youTube[vloger][1]++;
                        followers[secondVloger].Add(vloger);
                        youTube[secondVloger][0]++;
                    }
                }


            }
            Console.WriteLine($"The V-Logger has a total of {youTube.Count} vloggers in its logs.");
            var famousPerson = 0;
            var counter = 1;
            foreach (var person in youTube.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Value[1]))
            {
                if (person.Value[0]>famousPerson)
                {
                    famousPerson = person.Value[0];
                    Console.WriteLine($"{counter}. {person.Key} : {person.Value[0]} followers, {person.Value[1]} following");
                    foreach (var follower in followers[person.Key].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                else
                {
                    Console.WriteLine($"{counter}. {person.Key} : {person.Value[0]} followers, {person.Value[1]} following");
                }
                counter++;
            }
        }
    }
}
