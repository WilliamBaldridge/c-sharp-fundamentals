using System;
using System.Collections.Generic;
using System.Text;

namespace CSHarpFundamentals.beginners
{
    public class Strings
    {
        public Strings()
        {

            var fullName = "William Baldridge ";
            Console.WriteLine("Trime: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: ", firstName);
            Console.WriteLine("LastName: ", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: ", names[0]);
            Console.WriteLine("LastName: ", names[1]);

            Console.WriteLine(fullName.Replace("William", "Baldridge"));


            // IsNullOrWhiteSpace was added later to replace " ".Trim()
            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" ".Trim()))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.99f;
            price.ToString("C");
            price.ToString("C0"); // currency with no decimals



            // Summarizing Text:

            var sentence = "This is an example sentence to demonstrate a very long piece of text, such as a paragraph of blog post.";
            const int maxLength = 20;
            var summaryWords = new List<string>();

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                //sentence.Substring(0, maxLength);
                var words = sentence.Split(' ');
                var totalCharacters = 0;

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }


            // StringBuilder

            var builder = new StringBuilder("Hello World");

            // StringBuilder returns a stringBuilder, so you can chain all the methods...

            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);

        }
    }
}
