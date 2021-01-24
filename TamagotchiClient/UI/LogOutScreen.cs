using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiClient.UI
{
    class LogOutScreen : Screen
    {
        public LogOutScreen() : base("log out") { }
        
        public override void Show()
        {
            base.Show();
            if(UIMain.CurrentPlayer != null)
            {
                UIMain.CurrentPlayer = null;
                UIMain.Client.LogoutAsync().Wait();
                Console.WriteLine("you are successfully logged out");
            }
            else
                Console.WriteLine("you are not logged in");
            Console.ReadKey(true);
        }
        
    }
}
