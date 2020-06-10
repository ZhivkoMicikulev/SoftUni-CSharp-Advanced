using System;

namespace P05.DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();


            var dates= new DateModifier(date1, date2);
            Console.WriteLine(dates.Days(date1,date2));
            

        }
    }
}
