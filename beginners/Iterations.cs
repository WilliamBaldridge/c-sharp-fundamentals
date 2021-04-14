using System;
namespace CSHarpFundamentals.beginners
{
    public class Iterations
    {
        public Iterations()
        {

        //    static void Main(string[] args)
        //{
            // for, while, and do-while loops has same syntax

            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var j = 0;

            while (j < 10)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
                j++;
            };


            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {

                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

            //do
            //{
            //    ...
            //    i++;
            //} while (if< 10);


            // Foreach is similar to Java shorthand "for (this as : from that)"

            String name = "John Smith";

                foreach (var character in name)
                {
                    Console.Write(character);
                }


            //}
        }
    }
}
