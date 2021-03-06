﻿using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiClient.DataTransferObjects; 

namespace TamagotchiClient.UI
{
    class ShowPlayerScreen : Screen
    {
        public ShowPlayerScreen() : base("show player") { }


        public override void Show()
        {
            
            base.Show();
            PlayerDTO p = UIMain.CurrentPlayer;
            Object object1 = new
            {
                id = p.PlayerId,
                username = p.PlayerUserName,
                fullName = p.PlayerFirstName + " " + p.PlayerLastName,
                password = p.PlayerPassword,
                email = p.PlayerEmail,
                gender = p.PlayerGender
            };
            ObjectView o = new ObjectView("",object1);
            o.Show();
            Console.ReadKey();
            
            
            
            


        }
    }
}
