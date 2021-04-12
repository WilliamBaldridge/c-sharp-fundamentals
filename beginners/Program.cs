using System;
using CSHarpFundamentals.beginners;

namespace CSHarpFundamentals.beginners
{
    class Program
    {
        static void Main(string[] args)
        {     

                var bill = new Person
                {
                    firstName = "Billy",
                    lastName = "Clinton"
                };

                bill.Introduce();

            }
        
    }

}
