namespace Learn_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetFullName

            string fullName = Helper.GetFullName();

            Console.WriteLine(fullName);

            // GetWelcomeMessage

            string welcomeMessage = Helper.GetWelcomeMessage();

            Console.WriteLine(welcomeMessage);

            // GetProfile

            string profile = Helper.GetProfile(name: "Erfan", lastName: "Edalati");

            Console.WriteLine(profile);

            // GetNumber

            int number = Helper.GetNumber();

            Console.WriteLine(number);

            // Sum

            int sum = Helper.Sum(num1: 10, num2: 20);

            Console.WriteLine(sum);

            // GetIsThere

            bool isThere = Helper.GetIsThere();

            Console.WriteLine(isThere);
        }
    }
}
