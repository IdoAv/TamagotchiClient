using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiClient.UI
{
    class MenuItem
    {
        public string MenuTitle { get; set; }
        public Screen Screen { get; set; }
        public MenuItem() { }
        public MenuItem(string title, Screen screen)
        {
            MenuTitle = title;
            Screen = screen;
        }
    }
}
