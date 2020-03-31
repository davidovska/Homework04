using System;

namespace Homework04
{
    class Program
    {

        //Task 7
        //Create a class Dog
    
        public class Dog
        {
            public string Name;
            public string Breed;
            public string Color;

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating now.");
            }
            public void Play()
            {
                Console.WriteLine($"{Name} color is {Color}. {Name} is playing now.");
            }
            public void ChaseTail()
            {
                Console.WriteLine($"{Name} is a {Breed}. the dog is happy now.");
            }
        }
        //Task 8
        //Create a class Human
     

        public class Human
        {
            public string FirstName;
            public string LastName;
            public string Age;

          
            public void GetPersonStats()
            {
                Console.WriteLine($"Your fullname is {FirstName} {LastName} and is {Age} years old!");
            }
        }
        static void Main(string[] args)
        {

            //            Task 1
            //  * Print individual characters of the string in reverse order.
            Console.WriteLine("This program print individual characters of the string in reverse order : ");
            string reverse = "we love c#";
            char[] charReverse = reverse.ToCharArray();
            Array.Reverse(charReverse);
            Console.WriteLine("\b\b\b\b\b");
            Console.WriteLine(new string(charReverse)) ;

            Console.ReadLine();

            //Task 2
            //* Count the total number of words in a string entered by the user. 
            //* Example: user enters "I love C#" * Expected output: "I love c#" contains 3 words.

            Console.WriteLine("Please input a phrase so I can tell you how many words there are in: ");
            string userInput = Console.ReadLine();
            string[] wordCount = userInput.Trim().Split(' ');

            Console.WriteLine($@"""{userInput} "" contains  {wordCount.Length} words." );

            Console.ReadLine();

            

        //    //   Task 3
        //    //   * Find maximum occurring character in a string* 
        //         Example: "We want this situation with covid-19 to ends!" 
        //        * Expected Output: The highest frequency of character 't' appears number of times : 6


            string a;
            int maximum = 0, i = 0, L;
            
            Console.WriteLine("Enter some phrase so I can tell you the highest frequency of character 't' : ");
            a = Console.ReadLine();
            L = a.Length;
            while (i < L)
            {
                if (a[i] == 't')
                {
                    maximum++;
                }

                i++;
            }
            Console.WriteLine("The highest frequency of character 't' appears number of times:{0}", maximum);

            Console.ReadLine();


            //Task 4
            //* Print the whole text after "," in the console. 
            //*Bonus - Try to do that without counting the characters till "," by yourself :)

            Console.WriteLine(@"This will print whole text after "" , "" : ");

            string phrase = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            string[] splitedText = phrase.Split(", ");

            Console.WriteLine(splitedText[splitedText.Length - 1]);

            Console.ReadLine();



            //Task 5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. 
            // sega koga go isprintav namesto 00.33 mi dade 0.33. Neznam kako da go popravam :-)

            Console.Write("This is today's date : ");

            DateTime today = DateTime.Now;
            Console.WriteLine($" \n year = {today.Year}\n month = {today.Month}\n day = {today.Day}\n hour = {today.Hour}\n minute = {today.Minute}\n second = {today.Second}");

            Console.ReadLine();


            //Task 6
            //* Find the leap years between 2008 and 2020.

            Console.WriteLine("This is the leap years : ");

            for (int year = 2008; year <= 2020; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                    
                }
            }
            Console.ReadLine();

            // Task 7

            Dog puppy = new Dog();

            Console.WriteLine("Input dogs name: ");
            puppy.Name = Console.ReadLine();

            Console.WriteLine("Input dogs rase: ");
            puppy.Breed = Console.ReadLine();

            Console.WriteLine("Input dogs color: ");
            puppy.Color = Console.ReadLine();

            Console.WriteLine("Choose the action of your dog: ");
            Console.WriteLine("1 - Eat");
            Console.WriteLine("2 - Play");
            Console.WriteLine("3 - ChaseTail");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    puppy.Eat();
                    break;
                case "2":
                    puppy.Play();
                    break;
                case "3":
                    puppy.ChaseTail();
                    break;
                default:
                    Console.WriteLine("Dogs can't do that!");
                    break;
            }

            // Task 8

            Human firstHuman = new Human();
            Console.WriteLine("Please enter your first name: ");
            firstHuman.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            firstHuman.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            firstHuman.Age = Console.ReadLine();

            firstHuman.GetPersonStats();

        }
    }
}
