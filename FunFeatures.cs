using System;

namespace Assignment2
{
    class FunFeatures
    {
        private string name = "";
        private string email = "";

        public void Start()
        {
            //Introduce();
            Console.WriteLine("Let me know about yourself");
        
            Console.WriteLine("What is your full name? (first and last)");
            name = Console.ReadLine();


            Console.WriteLine("What is your email adress?");
            email = Console.ReadLine();

            Console.WriteLine("Here is your name and email adress:");
            Console.WriteLine(name + email);

            bool done = false;
            do
            {
                //Call method to read a number 1 to 7 and display the
                //name of the day (1 = Monday, up to 7 = Sunday) with a comment
                PredictTheDay();

                //Calculate the length of a given text
                CalculateStrengthLength

                //Run again or Exit
                done = RunAgain();
            } while (!done);

            Console.WriteLine("Welcome back, " + name);
        }
    }
}
