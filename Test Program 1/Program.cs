using System;

namespace Test_Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            int year = 0;
            string answer = "";

            print("Hey, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hey, {0}, I'm Alan. How old are you?", name);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wow, you're {0}! I've been asleep a long time, what year is it?", age);
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So your name is {0}, you're {1} years old, and the year is {2}?", name, age, year);
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Ah, good!");
            }
            else
            {
                print("Oh no!");
                print("I've been alseep for a long time, my memory must be getting worse! What did I get wrong?");
                answer = Console.ReadLine();
                Console.WriteLine("Darn, getting {0} wrong... That's pretty bad...", answer);
            }
            Console.ReadLine();
        }
      
        static void print(string str)
        {
            Console.WriteLine(str);
        }          
    }
}
