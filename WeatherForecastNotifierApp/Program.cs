namespace WeatherForecastNotifierApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Weather Notifier App");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. User Information  | 2. Get Current Weather  ");
            int userAnswer = Convert.ToInt32(Console.ReadLine()); 

            if(userAnswer == 1)
            {
                UserInformation userInformation = new UserInformation();
                userInformation.StartUserInfo();
            }
            else
            {
                Console.WriteLine("Its Under Construction");
            }

        }
    }
}