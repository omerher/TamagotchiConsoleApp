using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Threading.Tasks;


namespace TamagotchiConsoleApp.UI
{
    class PlayerScreen : Screen
    {
        public PlayerScreen() : base("Show Player")
        {

        }

        public override void Show()
        {
            base.Show();
            ObjectView showPlayer = new ObjectView("", UIMain.CurrentPlayer);
            showPlayer.Show();
            Console.WriteLine("Press A to see Player animals or other key to go back!");
            char c = Console.ReadKey().KeyChar;
            if (c == 'a' || c == 'A')
            {
                Console.WriteLine();
                //Create list to be displayed on screen
                //Format the desired fields to be shown! (screen is not wide enough to show all)
                Task<List<AnimalDTO>> t = UIMain.api.GetPlayerAnimalsAsync();
                t.Wait();
                List<AnimalDTO> l = t.Result;
                List<Object> animals = new List<Object>();
                foreach (AnimalDTO animal in l)
                {
                    animals.Add((Object)animal);
                }

                ObjectsList list = new ObjectsList("Animals", animals);
                list.Show();
                Console.WriteLine("\nPress I to see more info about the animal or any other key to go back!");
                char c2 = Console.ReadKey().KeyChar;
                if (c2 == 'I' || c2 == 'i')
                {
                    if (animals.Count() == 1)
                    {
                        Task<AnimalDTO> tt = UIMain.api.ActiveAnimalAsync();
                        tt.Wait();

                        AnimalDTO a = tt.Result;
                        Task<bool> t1 = UIMain.api.CheckIfDeadAsync(a.AnimalId);
                        t1.Wait();
                        bool isDead = t1.Result;
                        if (isDead)
                            new PastAnimalScreen(a.AnimalId);
                        else
                            new ActiveAnimalScreen().Show();
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the ID of the animal you want to see more info:");
                        int aID = int.Parse(Console.ReadLine());
                        Task<AnimalDTO> t2 = UIMain.api.GetAnimalByIdAsync(aID);
                        t2.Wait();
                        AnimalDTO a = t2.Result;
                        if (a == null)
                        {
                            Console.WriteLine("\nInvalid animal ID! Press any key to go back to the main menu");
                            Console.ReadKey();
                            new MainMenu().Show();
                        }
                        else
                        {
                            Task<bool> t1 = UIMain.api.CheckIfDeadAsync(a.AnimalId);
                            t1.Wait();
                            bool isDead = t1.Result;
                            if (isDead)
                            {
                                PastAnimalScreen screen = new PastAnimalScreen(a.AnimalId);
                                screen.Show();
                            }
                            else
                                new ActiveAnimalScreen().Show();
                        }
                    }
                }

                else
                    new MainMenu().Show();
            }
        }
    }
}