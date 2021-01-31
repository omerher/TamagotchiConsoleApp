using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiConsoleApp.UI
{
    class ActivitiesHistoryScreen : Screen
    {
        AnimalDTO a;

        public ActivitiesHistoryScreen(AnimalDTO a) : base("Activities History Screen")
        {
            this.a = a; 
        }

        public override void Show()
        {
            base.Show();

            Task<List<Object>> ActivitiesHistories = UIMain.api.ActivitiesHistoryAsync(a.AnimalId);
            ActivitiesHistories.Wait();
            List<Object> lst = ActivitiesHistories.Result;
            List<Object> activities = lst.ToList<Object>();
            ObjectsList list = new ObjectsList("Animals", activities);
            list.Show();

            Console.WriteLine("\nPress any key to go back to the main menu!");
            Console.ReadKey();
            new MainMenu().Show();
        }
    }
}
