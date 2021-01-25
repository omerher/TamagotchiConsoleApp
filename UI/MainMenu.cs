using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TamagotchiConsoleApp.UI
{
    class MainMenu:Menu
    {
        public MainMenu() : base($"Main Menu - {UIMain.CurrentPlayer.FirstName} is logged in")
        {
            //Build items in main menu!
            AddItem("Player", new PlayerScreen());
            AddItem("Search Animal", new SearchAnimalScreen());
            AddItem("Change Credentials", new ChangeCredentialsScreen());
            AddItem("Active Animal", new ActiveAnimalScreen());
        }
    }
}
