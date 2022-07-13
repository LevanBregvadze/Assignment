using System.Net;
using System.Text;
using System.Text.Json;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateCountryDataFiles();
        }





        static IEnumerable<Countries> GetDatafromAPI()
        {

            string html = string.Empty;
            string url = @"https://restcountries.com/v3.1/all";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();

            using (StreamReader reader = new StreamReader(stream))

            {

                html = reader.ReadToEnd();
            }

            var responseData = JsonSerializer.Deserialize<IEnumerable<Countries>>(html);


            return responseData;
        }





        static void GenerateCountryDataFiles()
        {

            var countryData = GetDatafromAPI();

            var textFilePath = @"C:\Assignment\Dotnet\Task8\Countries";

            foreach (var item in countryData)
            {
                var fileName = item.name.common.ToString() + ".txt";
                var fullPath = Path.Combine(textFilePath, fileName);
                using (FileStream fs = File.Create(fullPath))
                {


                    var toBeEntered = $"Region: {item.Region}\n" +
                        $"Subregion: {item.SubRegion}\n" +
                        $"Area: {item.area}\n" +
                        $"Population: {item.population}\n" +
                        $"Latitude: {item.latlng[0]} Longitude: {item.latlng[1]}\n";

                    char[] value = toBeEntered.ToCharArray();
                    fs.Write(Encoding.UTF8.GetBytes(value), 0, value.Length);

                }
            }
        }
    }
}