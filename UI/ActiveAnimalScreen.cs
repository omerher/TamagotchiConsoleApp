using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Linq;
using System.Threading.Tasks;
namespace TamagotchiConsoleApp.UI
{
    class ActiveAnimalScreen : Screen
    {
        public ActiveAnimalScreen() : base("Active Animal")
        {

        }
        public override void Show()
        {
            base.Show();
            //checking if player has an active Animal
            if (UIMain.CurrentPlayer.ActiveAnimalId.Equals(null))
            {
                Console.WriteLine("Looks like you dont have an animal :(\nTo create one press any key");
                Console.ReadKey();
                CreateAnimalScreen nAS = new CreateAnimalScreen();
                nAS.Show();//moving to animal creation screen
            }

            Task<AnimalDTO> tt = UIMain.api.ActiveAnimalAsync();
            tt.Wait();

            AnimalDTO AAnimal = tt.Result;
            ObjectView showAnimal = new ObjectView("", AAnimal);
            showAnimal.Show();//printing active animal

            //choosing to either play 
            Console.WriteLine("Press 1 to see activities history or any other key to go back!");
            char PscreenChoice = Console.ReadKey().KeyChar;
            if (PscreenChoice == '1')//if chose to see history
            {
                ActivitiesHistoryScreen aAH = new ActivitiesHistoryScreen(AAnimal);
                aAH.Show();
            }

            //making sure animal isnt dead after playing, if dead move to create animal
            Task<bool> t1 = UIMain.api.CheckIfDeadAsync(AAnimal.AnimalId);
            t1.Wait();
            bool isDead = t1.Result;
            if (isDead)
            {
               Console.WriteLine("Uh oh, your animal is dead!");
                Console.WriteLine("Press C to create a new animal or any other key to go back to the main menu!");
                char c = Console.ReadKey().KeyChar;
                if (c == 'C' || c == 'c')
                    new CreateAnimalScreen().Show();
            }
        }
    }
}
