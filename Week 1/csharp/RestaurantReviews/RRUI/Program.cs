using System;
using System.Collections.Generic;
using RRModels;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            menu.Start();
        }
    }
}
