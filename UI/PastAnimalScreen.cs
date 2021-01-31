using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiConsoleApp.UI
{
    class PastAnimalScreen : Screen
    {
        public int animalID;
        public PastAnimalScreen(int AnimalID) : base("Past Animal")
        {
            this.animalID = AnimalID;
        }
        public override void Show()
        {
            base.Show();


            
            Task<AnimalDTO> T = UIMain.api.PastAnimalAsync(animalID);
            T.Wait();
            AnimalDTO animal = T.Result;

            ObjectView showAnimal = new ObjectView("", animal); 

            showAnimal.Show(); //printing animal

            //if player chooses go to activities history
            Console.WriteLine("Press H to see activities history or any other key to go back!");
            char pScreenChoice = Console.ReadKey().KeyChar;
            if (pScreenChoice == 'H' || pScreenChoice == 'h')
            {
                new ActivitiesHistoryScreen(animal).Show();
            }
        }
    }
}
