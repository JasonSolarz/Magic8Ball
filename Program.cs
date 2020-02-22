using System;
using System.Collections.Generic;
using System.Threading;

namespace Magic8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------/Magic 8 Ball/---------");
            Console.Title = "Magic 8 Ball";

            List<string> answers = new List<string>();
            Random rand = new Random();
            string answer = "";
            string userInput = "";
            bool isPlaying = true;

            answers.Add("As I see it, yes.");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            answers.Add("Don’t count on it.");
            answers.Add("It is certain.");
            answers.Add("It is decidedly so.");
            answers.Add("Most likely.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Outlook good.");
            answers.Add("Reply hazy, try again.");
            answers.Add("Signs point to yes.");
            answers.Add("Very doubtful.");
            answers.Add("Without a doubt.");
            answers.Add("Yes.");
            answers.Add("Yes – definitely.");
            answers.Add("You may rely on it.");

            while (isPlaying)
            {
                //The 8 ball knows the answer before the user asks his question. ;)
                answer = answers[rand.Next(0, answers.Count)];

                //Ask user to enter their question.
                Console.Write("\nPlease Enter Your Question: ");
                userInput = Console.ReadLine();

                Console.WriteLine("\nThe 8 Ball Shakes To Life... and speaks!\n");
                Thread.Sleep(3000);
                Console.WriteLine(": " + answer + "\n");

                //Ask the user if they would like to ask another question.                
                Console.Write("Would you like to ask another questions(y, n): ");
                userInput = Console.ReadLine();

                if(userInput.ToUpper() != "Y" && userInput.ToUpper() != "YES")
                {
                    isPlaying = false;
                }
   
            }
        }
    }
}
