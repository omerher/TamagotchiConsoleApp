using System;
using System.Collections.Generic;
using System.Text;
using TamagotchiConsoleApp.DataTransferObjects;
using System.Linq;

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

            List<Object> ActivitiesHistories = (from activitiesList in UIMain.api.ActivitiesHistories
                                      where activitiesList.AnimalId == a.AnimalId
                                      select new
                                      {
                                          Name = UIMain.api.Activities.Where(a => a.ActivityId == activitiesList.ActivityId).FirstOrDefault().ActivityName,
                                          ActivitiesCategory = UIMain.api.Activities.Where(a => a.ActivityCategoryId == activitiesList.Activity.ActivityCategoryId).FirstOrDefault().ActivityCategory,
                                          Aweight = UIMain.api.ActivitiesHistories.Where(a => a.Aweight == activitiesList.Aweight).FirstOrDefault().Aweight,
                                          Ahunger = UIMain.api.ActivitiesHistories.Where(a => a.Ahunger == activitiesList.Ahunger).FirstOrDefault().Ahunger,
                                          Ahappiness = UIMain.api.ActivitiesHistories.Where(a => a.Ahappiness == activitiesList.Ahappiness).FirstOrDefault().Ahappiness,
                                          Acleanliness = UIMain.api.ActivitiesHistories.Where(a => a.Acleanliness == activitiesList.Acleanliness).FirstOrDefault().Acleanliness,
                                          Date = UIMain.api.ActivitiesHistories.Where(a => a.ActivityDate == activitiesList.ActivityDate).FirstOrDefault().ActivityDate,
                                          AnimalCycleStatus = UIMain.api.ActivitiesHistories.Where(a => a.AnimalCycleStatus == activitiesList.AnimalCycleStatus).FirstOrDefault().AnimalCycleStatus,
                                          HealthStatus = UIMain.api.ActivitiesHistories.Where(a => a.AnimalHealthStatus == activitiesList.AnimalHealthStatus).FirstOrDefault().AnimalHealthStatus,
                                      }).ToList<Object>();
            ObjectsList list = new ObjectsList("Animals", ActivitiesHistories);
            list.Show();

            Console.WriteLine("\nPress any key to go back to the main menu!");
            Console.ReadKey();
            new MainMenu().Show();
        }
    }
}
