using System;
namespace CSHarpFundamentals.beginners.math
{
    public class RandomExamples
    {
        //public RandomExamples()
        //{

            static void Main(String[] args)
            {

                var random = new Random();

                char[] buffer = new char[10];

                for (var i = 0; i < 10; i++)
                    buffer[i] = (char)('a' + random.Next(0, 26));

                var password = new string(buffer);

                Console.WriteLine(password);




            }
        //}
    }
}
