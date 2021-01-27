using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Threading.Tasks;

namespace TamagotchiConsoleApp.UI
{
    class CreateAnimalScreen : Screen
    {
        public CreateAnimalScreen() : base("Create Animal")
        {

        }

        public override void Show()
        {
            base.Show();
            
            Console.WriteLine("Enter new animal name: ");
            string name = Console.ReadLine();
            while (name == "")
            {
                Console.WriteLine("Can't have a blank name! Enter a different name:");
                name = Console.ReadLine();
            }

            Task<AnimalDTO> t = UIMain.api.CreateAnimalAsync(name);
            t.Wait();
            AnimalDTO animal = t.Result;
            if (animal != null)
                Console.WriteLine("Success!");
            else
                Console.WriteLine("Failed!");

            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
