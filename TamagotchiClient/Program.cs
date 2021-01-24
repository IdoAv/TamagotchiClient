using System;
using TamagotchiClient.WebClient;
using System.Threading.Tasks;
using TamagotchiClient.UI;

namespace TamagotchiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UIMain main = new UIMain(new HomeScreen());
            main.StartApplication();
        }
    }
}
