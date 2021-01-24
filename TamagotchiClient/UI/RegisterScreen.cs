using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TamagotchiClient.UI
{
    class RegisterScreen : Screen
    {
        public RegisterScreen() : base("register") { }
        
        /*
        public override void Show()
        {
            base.Show();
            Console.WriteLine("please enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter your Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("please enter your user Name: ");
            string userName = Console.ReadLine();
            while (UIMain.Db.PlayerExistByUserName(userName))
            {
                Console.WriteLine("user name exists!! type again:");
                userName = Console.ReadLine();
            }
            Console.WriteLine("please enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("please enter your email: ");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            while (!regex.Match(email).Success)
            {
                Console.WriteLine("invalid email!! type again:");
                email = Console.ReadLine();
            }
            while (UIMain.Db.PlayerExistByEmail(email))
            {
                Console.WriteLine("email exists!! type again:");
                email = Console.ReadLine();
                while (!regex.Match(email).Success)
                {
                    Console.WriteLine("invalid email!! type again:");
                    email = Console.ReadLine();
                }
            }
            Console.WriteLine("please enter your gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("do you wanna pass your birth date:");
            string answer = Console.ReadLine();
            while(answer.ToLower() != "yes" && answer.ToLower() != "no")
            {
                Console.WriteLine("invalid answer");
                answer = Console.ReadLine();
            }
            DateTime? birthDate = null;
            if(answer == "yes")
            {
                Console.WriteLine("please enter your birth year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter your birth month:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter your birth day:");
                int day = int.Parse(Console.ReadLine());
                birthDate = new DateTime(year, month, day);
            }
            Player p = new Player()
            {
                PlayerFirstName = firstName,
                PlayerLastName = lastName,
                PlayerUserName = userName,
                PlayerPassword = password,
                PlayerEmail = email,
                PlayerGender = gender,
                PlayerBirthDate = birthDate
            };
            try
            {
                UIMain.Db.Register(p);
                Console.WriteLine("you have registered successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("something went wrong...");
            }
            Console.ReadKey(true);

        }
        */
    }
}
