using System;
namespace CSHarpFundamentals.beginners
{
    public class DateTimeSpan
    {
        public DateTimeSpan()
        {
            // DateTime
            var dateTime = new DateTime(2021, 4, 14);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);


            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


            // TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);


            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);


            // Add & Subtract
            Console.WriteLine("Add ex.: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract ex.: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());


            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));



        }
    }
}
