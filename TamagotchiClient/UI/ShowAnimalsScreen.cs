using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TamagotchiClient.DataTransferObjects;

namespace TamagotchiClient.UI
{
    class ShowAnimalsScreen : Screen
    {
        public ShowAnimalsScreen() : base("show animals") { }


        public override void Show()
        {
            base.Show();
            List<AnimalDTO> list = UIMain.Client.GetAnimals().Result;
            List<Object> lst = list.Select(a => new
            {
                id = a.AnimalId,
                Name = a.AnimalName,
                Life_Cycle = a.LifeCycleName,
                Status = a.StatusName,
                BirthDay = a.AnimalBirthDate.ToShortDateString() + " " + a.AnimalBirthDate.ToShortTimeString(),
                Age = a.AnimalAge,
                Weight = a.AnimalWeight,
                Happiness = a.AnimalHappiness,
                Cleaness = a.AnimalCleaness,
                Hunger = a.AnimalHunger

            }).ToList<Object>();
            ObjectsList objectsList = new ObjectsList("animals", lst);
            objectsList.Show();
            Console.ReadKey(true);
        }
       
    }
}
