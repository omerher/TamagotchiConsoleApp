using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Linq;

namespace TamagotchiConsoleApp.UI
{
    class SearchAnimalScreen:Screen
    {
        public SearchAnimalScreen():base("Search Animal")
        {

        }

        public override void Show()
        {
            base.Show();
            
            Console.WriteLine("Please enter animal name: ");
            string animalN = Console.ReadLine();

            //** change to use api
            //List<AnimalDTO> animals = UIMain.api.Animals.Where(a => a.AnimalName == animalN).ToList();
            

            //if (animals.Count() == 1)
            //{
            //    AnimalDTO a = animals.FirstOrDefault();
            //    if (a.LifeCycleId == 5)
            //    {
            //        PastAnimalScreen s = new PastAnimalScreen(a.AnimalId);
            //        s.Show();
            //    }

            //    else
            //    {
            //        if (UIMain.CurrentPlayer.ActiveAnimal.AnimalId == a.AnimalId)
            //            new ActiveAnimalScreen().Show();
            //        else
            //            new PastAnimalScreen(a.AnimalId).Show();
            //    }
            //}

            //else if (animals.Count() == 0)
            //{
            //    Console.WriteLine("No animals found! Press any key to go back to the main menu!");
            //    Console.ReadKey();
            //}

            //else if (animals.Count() > 1)
            //{
            //    Console.WriteLine("Uh oh, we got more than 1 animal with this name...");
            //    List<Object> animalsID = (from animalList in UIMain.api.Animals
            //                              where animalList.AnimalName == animalN
            //                            select new
            //                            {
            //                                ID = animalList.AnimalId,
            //                                PlayerName = animalList.Player.FirstName,
            //                                Name = animalList.AnimalName,
            //                                BirthDate = animalList.CreationDate.Value.ToShortDateString()
            //                            }).ToList<Object>();
            //    ObjectsList list = new ObjectsList("Animals", animalsID);
            //    list.Show();

            //    Console.WriteLine("Please enter animal id: ");
            //    int animalID = int.Parse(Console.ReadLine());

            //    AnimalDTO a = UIMain.api.Animals.Where(a => a.AnimalId == animalID).FirstOrDefault();

            //    if (a.LifeCycleId == 5)
            //    {
            //        PastAnimalScreen s = new PastAnimalScreen(a.AnimalId);
            //        s.Show();
            //    }

            //    else
            //    {
            //        ActiveAnimalScreen s = new ActiveAnimalScreen();
            //        s.Show();
            //    }

            //}

        }

    }
}
