using System;

namespace Program
{
    class Program
    {
        /*
         in C# programming, the main Method
         */
        static void Main(string[] args)
        {
            Human.Person person = new Human.Person();
            person.WriteInfo();
            person.PrintInfo();
        }
    }

    class Check
    {

        float numb, percent;
        public void accept()
        {
            Console.Write("\nEnter your marks. (Total Marks = 850):\t");
            numb = float.Parse(Console.ReadLine());
        }

        public void print()
        {
            percent = (float)numb / 850 * 100;
            if (percent < 35)
            {
                Console.WriteLine("Sorry! You're fail. Your mark is " + percent);
            }
            else if (percent > 35 && percent < 50)
            {
                Console.WriteLine("You got grade D and your percent mark is " + percent);
            }
            else if (percent > 50 && percent < 60)
            {
                Console.WriteLine("You got grade C and your percent mark is " + percent);
            }
            else if (percent > 60 && percent < 75)
            {
                Console.WriteLine("You got grade B and your percent mark is " + percent);
            }
            else
            {
                Console.WriteLine("You got grade A and your percent mark is " + percent);
            }
        }
    }
}

namespace Human
{
    class Person
    {
        string name;
        int age;

        public void WriteInfo()
        {
            Console.WriteLine("Hey type your name here:");
            name = Console.ReadLine();

            Console.WriteLine("Hey type your age here:");
            age = int.Parse(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine("Your name is '{0}' with the age of {1}", name, age);
        }
    }
}

namespace Animal
{
    class Dog
    {
        
    }
}