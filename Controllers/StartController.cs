using System;
namespace CourseWork.Controllers
{
    public class StartController
    {
        public void Run()
        {
            Console.WriteLine("Hello, World!");

            List<Customer> customers = new List<Customer>();
            
            Customer CurrCustomer = null;
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                LogInController logIn = new LogInController();
                CurrCustomer = logIn.Run(CurrCustomer, customers);

                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("Оберіть команду:");
                    Console.WriteLine("1 - Поповнити баланс\n2 - Подивитись історію покупок\n3 - Перейти до магазину\n4 - Переглянути кошик\n0 - Назад");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 0:
                            
                            break;
                        case 1:
                            Console.Clear();
                            BalanceController balance = new BalanceController();
                            balance.Run(CurrCustomer);
                            continue;
                        case 2:
                            Console.Clear();
                            HistoryController history = new HistoryController();
                            history.Run(CurrCustomer);
                            continue;
                        case 3:
                            Console.Clear();
                            GoToShopController shop = new GoToShopController();
                            shop.Run(CurrCustomer);
                            continue;
                        case 4:
                            Console.Clear();
                            ShopCartController cartController = new ShopCartController();
                            cartController.Run(CurrCustomer);
                            continue;

                        default:
                            continue;

                    }
                    break;
                }


            }
        }
        
    }
}

