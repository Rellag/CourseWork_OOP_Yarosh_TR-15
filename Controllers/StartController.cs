using System;
namespace CourseWork.Controllers
{
    public class StartController
    {
        List<Customer> customers = new List<Customer>();
        List<IRun> runs = new List<IRun>();

        public void Run()
        {
            Console.WriteLine("Інтернет магазин");

            runs.Add(new BalanceController());
            runs.Add(new HistoryController());
            runs.Add(new GoToShopController());
            runs.Add(new ShopCartController());


            Customer CurrCustomer;
            {
                while (true)
                {

                    Console.Clear();
                    LogInController logIn = new LogInController();
                    CurrCustomer = logIn.Run(customers);

                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("Оберіть команду:");
                        Console.WriteLine("1 - Поповнити баланс\n2 - Подивитись історію покупок\n3 - Перейти до магазину\n4 - Переглянути кошик\n0 - Назад");
                        int typed = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (typed == 0)
                        {
                            break;
                        }
                        else if (typed > 0 && typed <= runs.Count())
                        {
                            typed--;
                            runs[typed].Run(CurrCustomer);
                        }


                    }
                }


            }
        }
        
    }
}

