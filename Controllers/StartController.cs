using System;
namespace CourseWork.Controllers
{
    public class StartController
    {
        public void Run()
        {
            Console.WriteLine("Інтернет магазин");

            List<Customer> customers = new List<Customer>();

            Customer CurrCustomer;
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
                    else if (typed == 1)
                    {
                        BalanceController balance = new BalanceController();
                        balance.Run(CurrCustomer);
                    }
                    else if (typed == 2)
                    {
                        HistoryController history = new HistoryController();
                        history.Run(CurrCustomer);
                    }
                    else if (typed == 3)
                    {
                        GoToShopController shop = new GoToShopController();
                        shop.Run(CurrCustomer);
                    }
                    else if (typed == 4)
                    {
                        ShopCartController cartController = new ShopCartController();
                        cartController.Run(CurrCustomer);
                    }

                }


            }
        }
        
    }
}

