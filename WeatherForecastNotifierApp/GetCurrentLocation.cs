using WeatherForecastNotifierApp.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherForecastNotifierApp
{
    public class GetCurrentLocation
    {
        public async Task<string> GetUserCurrentLocation()
        {
            string getLocationUrl = "http://api.openweathermap.org/geo/1.0/zip?zip=E14,GB&appid=59037e9e323d8d64dc5b26ae93b20e88";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(getLocationUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        return json;
                    }
                    else
                    {
                        // Handle the error case if the request fails
                        // You can return an empty string or throw an exception, depending on your requirements
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Print or log the exception details for debugging
                Console.WriteLine($"An error occurred: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
