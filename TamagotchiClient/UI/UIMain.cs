using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiClient.DataTransferObjects;
using TamagotchiClient.WebClient;

namespace TamagotchiClient.UI
{
    class UIMain
    {
        private readonly Screen initialScreen;
        public static PlayerDTO CurrentPlayer { get; set; }
        public static TamagotchiClient.WebClient.TamagotchiClient Client { get; set; }

        public UIMain(Screen initialScreen)
        {
            this.initialScreen = initialScreen;
        }

        public void StartApplication()
        {
            CurrentPlayer = null;
            Client = new TamagotchiClient.WebClient.TamagotchiClient(@"https://localhost:44335/Tamagotchi");
            this.initialScreen.Show();
        }
        

    }
}
