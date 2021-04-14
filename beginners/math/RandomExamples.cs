using System;
namespace CSHarpFundamentals.beginners.math
{
    public class RandomExamples
    {
        public RandomExamples()
        {

            //static void Main(String[] args)
            //{

            var random = new Random();

            const int passwordLength = 10;

                char[] buffer = new char[passwordLength];

                for (var i = 0; i < passwordLength; i++)
                    buffer[i] = (char)('a' + random.Next(0, 26));

                var password = new string(buffer);

                Console.WriteLine(password);




            }
        //}
    }
}
