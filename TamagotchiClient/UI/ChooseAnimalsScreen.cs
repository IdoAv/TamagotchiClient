using System;
using System.Collections.Generic;
using System.Text;

namespace WebServicesProject.UI
{
    class ChooseAnimalsScreen : Screen
    {
        //public Animal Animal { get; private set; }
        
        public ChooseAnimalsScreen() : base("choose animals") { }
        /*
        public override void Show()
        {
            base.Show();
            if (UIMain.CurrentPlayer.GetAnimals().Count != 0)
            {
                ShowAnimalsScreen showAnimalsScreen = new ShowAnimalsScreen();
                showAnimalsScreen.Show();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("choose animal by id:");
                int animalId = int.Parse(Console.ReadLine());
                Animal = UIMain.CurrentPlayer.GetAnimal(animalId);
                while (Animal == null)
                {
                    Console.WriteLine("invalid id!! choose again:");
                    animalId = int.Parse(Console.ReadLine());
                    Animal = UIMain.CurrentPlayer.GetAnimal(animalId);
                }
            }
        */
    }

}

