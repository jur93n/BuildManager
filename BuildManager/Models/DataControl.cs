using BuildManager.Data;
using System.Collections.Generic;
using System.Linq;

namespace BuildManager.Models
{
    public static class DataControl
    {
        public static List<BuildManagerModel> GetAllBuildManagerModels()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Works.ToList();
                return result;
            }
        }
        //Cтворити клас робіт
        public static string CreateWork(string typeOfWork, string worker, string duration, int totalPrice)
        {
            string result;
            using (ApplicationContext db = new ApplicationContext())
            {
                BuildManagerModel newModel = new BuildManagerModel
                {
                    TypeOfWork = typeOfWork,
                    Worker = worker,
                    Duration = duration,
                    TotalPrice = totalPrice
                };
                db.Works.Add(newModel);
                db.SaveChanges();
                result = "Клас робіт створено";
            }
            return result;
        }

        //Видалити клас робіт
        public static string DeleteWork (BuildManagerModel workModel)
        {
            string result;
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Works.Remove(workModel);
                db.SaveChanges();
                result = "Вид робіт " + workModel.TypeOfWork + " видалено";
            }
            return result;
        }
        //Редагувати клас робіт
        public static string EditWork (BuildManagerModel oldWorkModel, string newTypeOfWork, string newWorker, string newDuration, int newTotalPrice)
        {
            string result = "Такого виду робіт не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                BuildManagerModel buildManagerModel = db.Works.FirstOrDefault(p => p.Id == oldWorkModel.Id);
                buildManagerModel.TypeOfWork = newTypeOfWork;
                buildManagerModel.Worker = newWorker;
                buildManagerModel.Duration = newDuration;
                buildManagerModel.TotalPrice = newTotalPrice;
                db.SaveChanges();
                result = "Вид робіт відредаговано";
            }
            return result;
        }
    }
}
