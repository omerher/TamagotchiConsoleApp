using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;


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

            AnimalDTO a = new AnimalDTO()
            {
                AnimalName = name,
                PlayerId = UIMain.CurrentPlayer.PlayerId
            };
            a.Player = UIMain.CurrentPlayer;
            
            //** change to use api
            //UIMain.api.Add(a);
            //UIMain.api.SaveChanges();

            //UIMain.CurrentPlayer.ActiveAnimal = a;
            //UIMain.CurrentPlayer.ActiveAnimalId = a.AnimalId;
            //UIMain.api.SaveChanges();

            //MainMenu mm = new MainMenu();
            //mm.Show();
        }
    }
}
