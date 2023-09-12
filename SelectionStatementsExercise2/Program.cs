using System;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite school subject?");
            var userSubject = Console.ReadLine();

            switch (userSubject.ToLower())
            {
                case "math":

                    Console.WriteLine("Math is one of my favorites!");

                    break;

                case "science":

                    Console.WriteLine("Science is so fascinating!");

                    break;

                case "history":

                    Console.WriteLine("History is important to learn. If we do not know the past we are doomed to repeat it.");

                    break;

                case "english":

                    Console.WriteLine("English is very important");

                    break;

                case "art":

                    Console.WriteLine("I love art so many ways to be creative!");

                    break;

                default:

                    Console.WriteLine("I don't know that subject, but all are important!");

                    break;
            }


        }
    }
}