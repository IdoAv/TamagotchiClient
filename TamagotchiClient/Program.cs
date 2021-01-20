using System;
using TamagotchiClient.WebClient;
using System.Threading.Tasks;

namespace TamagotchiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TamagotchiClient.WebClient.TamagotchiClient client = new WebClient.TamagotchiClient(@"https://localhost:44335/Tamagotchi");
            Task<string> t = client.TestAsync();
            t.Wait();
            Console.WriteLine(t.Result);
        }
    }
}
