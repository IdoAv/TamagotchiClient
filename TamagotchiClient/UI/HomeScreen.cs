using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiClient.UI
{
    class HomeScreen : Screen
    {
        public HomeScreen() : base("home")
        {

        }
        public override void Show()
        {
            base.Show();
            MainMenu menu = CreateMenu();
            menu.Show();
        }
        private MainMenu CreateMenu()
        {
            List<Tuple<Screen, string>> lst = new List<Tuple<Screen, string>>();
            lst.Add(new Tuple<Screen, string>(new LogInScreen(), "log in"));
            lst.Add(new Tuple<Screen, string>(new LogOutScreen(), "log out"));
            lst.Add(new Tuple<Screen, string>(new RegisterScreen(), "register"));
            return new MainMenu("home menu", lst);
        }
    }
}
