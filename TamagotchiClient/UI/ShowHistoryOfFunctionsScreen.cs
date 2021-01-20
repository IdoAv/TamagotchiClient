using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServicesProject.UI
{
    class ShowHistoryOfFunctionsScreen : Screen
    {
        public ShowHistoryOfFunctionsScreen() : base("show history of functions") { }

        public override void Show()
        {
            /*
            base.Show();
            if(UIMain.CurrentPlayer.GetAnimals().Count != 0)
            {
                ChooseAnimalsScreen chooseAnimalsScreen = new ChooseAnimalsScreen();
                chooseAnimalsScreen.Show();
                Animal a = chooseAnimalsScreen.Animal;
                List<Object> lst = a.GetHistoryOfFunctions()
                    .Select(h => new
                    {
                        function = h.Function.ToString(),
                        date = h.FunctionDate.ToShortDateString() + " " + h.FunctionDate.ToShortTimeString(),
                        lifeCycle = h.LifeCycle.LifeCycleName,
                        cleaness = h.AnimalCleaness,
                        happiness = h.AnimalHappiness,
                        hunger = h.AnimalHunger,
                        weight = h.AnimalWeight
                    }).ToList<Object>();
                ObjectsList objectsList = new ObjectsList("functions", lst);
                Console.Clear();
                objectsList.Show();
                Console.ReadKey(true);
            
            }
            */

        }
    }
}
