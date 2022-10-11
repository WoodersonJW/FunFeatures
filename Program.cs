namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "Strings, selection and iteration in C#";
            FunFeatures funObj = new FunFeatures();
            funObj.Start();

            ContinueToNextPart(); //Call the method below
        }
        private static void ContinueToNextPart()
        //Static is class related and can be acessed without creating an instance/object of class
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.ReadLine();
            Console.Clear();
        }
    }
}