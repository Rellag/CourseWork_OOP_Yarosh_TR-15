using System;
namespace CourseWork.Controllers
{
    public class HistoryController : IRun
    {


        public void Run(Customer CurrCustomer)
        {
            Console.WriteLine("***********************************" +
                "\n\t{0}\tІсторія покупок\n***********************************", CurrCustomer.name);
            int sum = 0;
            foreach (BoughtProduct item in CurrCustomer.history)
            {
                sum += item.price;
                Console.WriteLine("\n{0} {1}\nОпис: {2}\nЦіна: {3}\nДата покупки: {4}" +
                    "\n\n-----------------------------------",
                     item.name, item.Genre, item.desc, item.price.ToString("C"), item.time);
            }

            Console.WriteLine("Загалом було витрачено: " + sum.ToString("C"));
            Console.WriteLine("\nВведіть 0 щоб повернутися");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    break;
            }
        }
    }
}
