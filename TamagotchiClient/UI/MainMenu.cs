using System;
using System.Collections.Generic;
using System.Text;

namespace WebServicesProject.UI
{
    class MainMenu : Menu
    {
        public MainMenu(string title, List<Tuple<Screen, string>> lst) : base(title)
        {
            foreach (Tuple<Screen, string> item in lst)
            {
                AddItem(item.Item2, item.Item1);
            }
        }
    }
}
