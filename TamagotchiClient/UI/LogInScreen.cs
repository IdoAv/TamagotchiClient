using System;
using System.Collections.Generic;
using System.Text;

namespace WebServicesProject.UI
{
    class LogInScreen : Screen
    {
        public LogInScreen() : base("log in") { }
        /*
        public override void Show()
        {
            //Clear screen and set title (implemented by Screen Show)
            base.Show();

            //Check if we should logout first
            if (UIMain.CurrentPlayer != null)
            {
                Console.WriteLine($"Currently, {0} is logged in. Press Y to log out or other key to go back to menu!");
                char c = Console.ReadKey().KeyChar;
                if (c == 'Y' || c == 'y')
                {
                    //Save all changes to DB before logging out
                    UIMain.Db.SaveChanges();
                    UIMain.CurrentPlayer = null;
                }
            }

            //if user is still logged in, we should go out!= back to menu
            while (UIMain.CurrentPlayer == null)
            {
                //Clear screen again
                base.Show();

                Console.WriteLine($"Please enter your email: ");
                string email = Console.ReadLine();
                Console.WriteLine($"Please enter your password: ");
                string password = Console.ReadLine();

                UIMain.CurrentPlayer = UIMain.Db.LogIn(email,password);

                if (UIMain.CurrentPlayer == null)
                {
                    Console.WriteLine("Login fail!! Press any key to try again!");
                    Console.ReadKey();
                }

            }
            MainMenu menu = CreateMenu();
            menu.Show();
        }

        private MainMenu CreateMenu()
        {
            List<Tuple<Screen, string>> lst = new List<Tuple<Screen, string>>();
            lst.Add(new Tuple<Screen, string>(new ShowPlayerScreen(), "show player"));
            lst.Add(new Tuple<Screen, string>(new ShowAnimalsScreen(), "show animals"));
            lst.Add(new Tuple<Screen, string>(new ChooseFunctionScreen(), "choose function for active animal"));
            lst.Add(new Tuple<Screen, string>(new ShowHistoryOfFunctionsScreen(), "show history of functions"));
            return new MainMenu("menu", lst);
        }
        */
    }
}
