using Newtonsoft.Json;

namespace Api
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            //TODO Ask the user for a category and show the joke accordingly
            //TODO Display list of categories before asking the user to select a category
            //TODO Add some validation rules so the user can only select a category based on those available
            var joke = GetJoke<Joke>("https://api.chucknorris.io/jokes/random");
            Console.WriteLine(joke!.value);
        }


        #region ApiClasses
        private static T? GetJoke<T>(string url)
        {
            var result = CallApi(url).Content.ReadAsStringAsync();
            return DeserializeApiResponseJson<T>(result.Result);
        }
        private static T? DeserializeApiResponseJson<T>(string result)
        {
            return JsonConvert.DeserializeObject<T>(result);
        }
        private static HttpResponseMessage CallApi(string url)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url);
            return response.Result;
        }
        #endregion
    }

    public class Joke
    {
        public string value { get; set; }
    }

}