using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite school subject?");
            string userInput = Console.ReadLine();
            string subject = userInput;
            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("Great, math is a fun but hard subject.");
                    break;
                case "english":
                    Console.WriteLine("Wow, English I never really liked but that's great you do.");
                    break;
                case "art":
                    Console.WriteLine("That's awesome, that's my favorite subject as well!");
                    break;
                case "pe":
                    Console.WriteLine("Good for you, I didn't start liking it until I joined the military.");
                    break;
                case "science":
                    Console.WriteLine("That's a fun and hard subject, I like it as well.");
                    break;
                default:
                    Console.WriteLine("That's great! Unfortunately there were a lot of great subjects and I couldn't list them all.");
                    break;
            }
        }
    }
}