using System;
using TamagotchiConsoleApp.UI;

namespace TamagotchiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UIMain ui = new UIMain(new LoginRegisterScreen());
            ui.ApplicationStart();
        }
    }
}
