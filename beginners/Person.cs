using System;


namespace CSHarpFundamentals.beginners
{

    public class Person
    {

        public int Age;
        public String firstName;
        public String lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }

}