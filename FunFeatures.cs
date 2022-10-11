using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    class FunFeatures
    {
        private string name = "";
        private string email = "";

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Hello I'm Slim Shady"); //Greeting message
            Console.WriteLine(); //blankline
        }
            public void ReadName()
            {
            Console.WriteLine("Let me know about yourself");
            
            Console.WriteLine("What is your full name? (first and last)");
            name = Console.ReadLine();


            Console.WriteLine("What is your email adress?");
            email = Console.ReadLine();

            Console.WriteLine("Here is your name and email adress:");
            Console.WriteLine(name + email);
            }

        
    }
}
