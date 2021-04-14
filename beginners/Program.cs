//using System;
//using CSHarpFundamentals.beginners;

//namespace CSHarpFundamentals.beginners
//{

//    // Enums
//    public enum ShippingMethod
//    {
//        RegularAirMail = 1,
//        RegisteredAirMail = 2,
//        Express = 3
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {     

//                var bill = new Person
//                {
//                    firstName = "Billy",
//                    lastName = "Clinton"
//                };

//                bill.Introduce();

//            //Arrays just like in Java, fixed amount when initialized
//            var numbers = new int[3];
//            numbers[0] = 1;

//            // Strings are declared "string" unlike String in Java, can use String when "using System;" import
//            // still not primitive and is a "class" in C#
//            // string Format uses placeholders in {}
//            string name = string.Format("Hello from {0} {1}", bill.firstName, bill.lastName);
//            Console.WriteLine(name);


        
//            var method = ShippingMethod.Express;
//            Console.WriteLine((int) method);

//            var methodId = 3;
//            Console.WriteLine((ShippingMethod)methodId);

//            Console.WriteLine(method.ToString());

//            var methodName = "Express";
//            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
//            Console.WriteLine(shippingMethod);


//            /* 
//             * 2 Types - Value and Reference types
//             * 
//             Value: Structs (structures) - primitive types (no more than 8 bytes) and custom structs. They
//            Are allocated on stack
//            Memory allocation done automatically
//            Immediately removed when out of scope
            

//             Reference: Classes - Arrays, Strings, custom classes
//            Need to allocate memory yourself (initializing with "new")
//            Memory allocated on heap
//            Garbage collected by CLR (clears heap)

//            */

//            var a = 10;
//            var b = a;
//            b++;
//            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

//            var array1 = new int[3] { 1, 2, 3 };
//            var array2 = array1;
//            array2[0] = 0;
//            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


//        }
        
//    }

//}
