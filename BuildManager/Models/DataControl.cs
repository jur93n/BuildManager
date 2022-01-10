using BuildManager.Data;

namespace BuildManager.Models
{
    public static class DataControl
    {
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
                db.Add(newModel);
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
                db.Remove(workModel);
                db.SaveChanges();
                result = "Вид робіт " + workModel.TypeOfWork + " видалено";
            }
            return result;
        }
        //Редагувати клас робіт
        public static string EditWork (BuildManagerModel workModel, string newTypeOfWork, string newWorker, string newDuration, int newTotalPrice)
        {
            string result;
            using (ApplicationContext db = new ApplicationContext())
            {
                workModel.TypeOfWork = newTypeOfWork;
                workModel.Worker = newWorker;
                workModel.Duration = newDuration;
                workModel.TotalPrice = newTotalPrice;
                db.SaveChanges();
                result = "Вид робіт відредаговано";
            }
            return result;
        }
    }
}
