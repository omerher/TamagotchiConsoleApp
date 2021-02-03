using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using TamagotchiConsoleApp.WebServices;
using System.Linq;

namespace TamagotchiConsoleApp.UI
{
    class UIMain
    {
        //UI Main object is perfect for storing all UI state as it is initialized first and detroyed last.
        public static PlayerDTO CurrentPlayer { get; set; }
        public static TamagotchiWebAPI api { get; private set; }

        private Screen initialScreen;
        public UIMain(Screen initial)
        {
            this.initialScreen = initial;
        }
        public void ApplicationStart()
        {
            //Initialize db context and current player
            api = new TamagotchiWebAPI(@"https://localhost:44364/api");
            CurrentPlayer = null;
            //Show Screen and start app!
            initialScreen.Show();
        }
    }
}
