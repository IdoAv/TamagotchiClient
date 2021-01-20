using System;
using System.Collections.Generic;
using System.Linq;

namespace WebServicesProject.UI
{
    class ChooseFunctionScreen : Screen
    {
        
        public ChooseFunctionScreen() : base("choose function for active animal") {
        
        }
        /*
        public override void Show()
        {
            base.Show();
            if(UIMain.CurrentPlayer.PlayerActiveAnimalNavigation == null)
                Console.WriteLine("you dont have active animal");
            else
            {
                List<Function> functions = UIMain.Db.GetFirstFunctions();
                ShowFunctions(functions);
                Console.WriteLine("please enter the id of the function you want to turn on");
                int id = int.Parse(Console.ReadLine());

                while (!UIMain.Db.ExistInFirstFunctions(id))
                {
                    Console.WriteLine("invalid id! please type a valid id of a function");
                    id = int.Parse(Console.ReadLine());
                }
                Function f = UIMain.Db.GetFirstFunction(id);
                while (f.IsCategory())
                {
                    base.Show();
                    functions = f.GetFunctions();
                    ShowFunctions(functions);
                    Console.WriteLine("please enter the id of the function you want to turn on");
                    id = int.Parse(Console.ReadLine());
                    while (!f.Exist(id))
                    {
                        Console.WriteLine("invalid id! please type a valid id of a function");
                        id = int.Parse(Console.ReadLine());
                    }
                    f = f.GetFunction(id);
                }
                try
                {
                    UIMain.CurrentPlayer.PlayerActiveAnimalNavigation.ApplyFunction(f);
                    UIMain.Db.AddHistoryOfFunctions(UIMain.CurrentPlayer.PlayerActiveAnimalNavigation, f);
                    UIMain.Db.SaveChanges();
                    Console.WriteLine("function is done");
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong");
                }
            }
            


            
        }

        private void ShowFunctions(List<Function> functions)
        {
            List<Object> lst = functions.Select(f => new
            {
                Id = f.FunctionId,
                Name = f.FunctionName,
                Hunger = f.HungerImpact,
                Cleanless = f.CleanessImpact,
                Happiness = f.HappinessImpact,
                Wieght = f.GainWeight,
                Category = f.FunctionOf == null ? false : true,

            }).ToList<Object>();
            ObjectsList objectsList = new ObjectsList("functions", lst);
            objectsList.Show();
        }
        */
    }
}