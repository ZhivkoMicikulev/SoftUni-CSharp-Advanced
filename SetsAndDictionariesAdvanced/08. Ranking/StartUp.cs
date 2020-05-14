using System;
using System.Collections.Generic;
using System.Linq;
namespace _08._Ranking
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            string comandOne;
            
            while ((comandOne=Console.ReadLine())!= "end of contests")
            {
                ImportingInformationForContests(contests, comandOne);
            }
            string comandTwo;
            var infoStudents = new Dictionary<string, Dictionary<string, int>>();
            while ((comandTwo=Console.ReadLine())!= "end of submissions")
            {
                ImportingInformationForStudents(contests, comandTwo, infoStudents);

            }
            var bestStudent = string.Empty;
            var bestPoints = 0;
            foreach (var student in infoStudents)
            {
                var tempPoints = 0;
                var cont = student.Value;
                foreach (var clas in cont)
                {
                    tempPoints += clas.Value;
                }
                if (tempPoints>bestPoints)
                {
                    bestPoints = tempPoints;
                    bestStudent = student.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in infoStudents.OrderBy(n=>n.Key))
            {
                Console.WriteLine(student.Key);
                var clas = student.Value;
                foreach (var cl in clas.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {cl.Key} -> {cl.Value}");
                }
            }
        }

        private static void ImportingInformationForStudents(Dictionary<string, string> contests, string comandTwo, Dictionary<string, Dictionary<string, int>> infoStudents)
        {
            var tokens = comandTwo.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var contest = tokens[0];
            var password = tokens[1];
            var student = tokens[2];
            var points = int.Parse(tokens[3]);
            if (contests.ContainsKey(contest) && contests[contest] == password)
            {
                if (!infoStudents.ContainsKey(student))
                {
                    infoStudents[student] = new Dictionary<string, int>();
                }
               
                if (!infoStudents[student].ContainsKey(contest))
                {

                    infoStudents[student][contest] = 0;
                }
                if (points > infoStudents[student][contest])
                {
                    infoStudents[student][contest] = points;
                }
            }
        }

        private static void ImportingInformationForContests(Dictionary<string, string> contests, string comandOne)
        {
            var tokens = comandOne.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
            var contest = tokens[0];
            var password = tokens[1];
            if (!contests.ContainsKey(contest))
            {
                contests[contest] = string.Empty;
            }
            contests[contest] = password;
        }
    }
}
