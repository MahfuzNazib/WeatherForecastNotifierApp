using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastNotifierApp
{
    public class UserInformation
    {
        public void StartUserInfo()
        {
            Console.WriteLine("1. Setup Your Profile    |  2. Skip For Now");
            Console.WriteLine("-------------------------------------------");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            
            if(userAnswer == 1)
            {
                SetupUserProfile();
            }
            else if(userAnswer == 2)
            {
                SkipForNow();
            }
            else
            {
                Console.WriteLine("Invalid Input. Accept only 1 or 2.");
            }
        }

        public bool SetupUserProfile()
        {
            Console.WriteLine("Enter Your Name : ");
            string FullName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter City Name : ");
            string CityName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Your State Code : ");
            return true;
        }

        public bool SkipForNow()
        {
            return true;
        }
    }
}
