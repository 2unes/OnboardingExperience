using System;


namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Bank!");

            var user = new User();

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Great! Your first name is" + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Thank you! Your full name is " + user.FirstName +" " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("You are: " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What is your 4 digit pin?", 4);
            Console.WriteLine("Thanks! You entered: " + user.PinNumber);

            Console.ReadLine();

        }

        static string AskQuestion(string question) 
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;

            while (!hasAnswered)
            {
                var response = AskQuestion(question + "(y/n)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }    
                else if (response == "n")
                {
                    responseBool = false;
                    hasAnswered = true;
                }
            }
            return responseBool;
        }

        static string AskPinNumber(string question, int length)
        {
           string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }
            }
            return numberString;
        }

    }
}