using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);

            if (userEntry == "Maria")
            {
                Console.WriteLine("You are awesome!");
            }
            else
            {
                Console.WriteLine("You are awesome, but not as much. :(");
            }

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of j is {j}...");
            }

            foreach (var currentChar in userEntry)
            {
                if (currentChar == 'M' || currentChar == 'm')
                {
                    continue;
                }

                Console.WriteLine($"the current character is {currentChar}...");
            }

            switch (userEntry)
            {
                case "Maria":
                    Console.WriteLine("It's a-me, Maria!");
                    break;
                default:
                    Console.WriteLine("It's not a-me, Maria.");
                    break;
            }

            var isMaria = userEntry == "Maria" ? true : false;

            Console.ReadLine();

        }
    }
}
