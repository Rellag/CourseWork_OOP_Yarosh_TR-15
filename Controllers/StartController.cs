using System;
namespace CourseWork.Controllers
{
    public class StartController
    {
        

        public void Run()
        {

            Console.WriteLine("Hello, World!");

            List<Customer> customers = new List<Customer>();
            int id = 0;
            Customer CurrCustomer = null;
            bool flag = true;


            while (flag)
            {
                Console.Clear();
                Console.WriteLine("1 - Створити аккаунт\n2 - Зайти в існуючий");



                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Введіть своє імʼя:");
                        customers.Add(new Customer { custId = ++id, name = Console.ReadLine() });
                        CurrCustomer = customers.Last();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Оберіть:");
                        foreach (Customer item in customers)
                        {
                            Console.WriteLine(item);
                        }
                        int indexCust = Convert.ToInt32(Console.ReadLine());

                        if (indexCust >= 1 && indexCust <= customers.Count())
                        {
                            CurrCustomer = customers.ElementAt(indexCust - 1);

                            break;
                        }
                        else
                        {
                            continue;
                        }
                            

                    default:
                        continue;
                }

                
                while (true)
                {
                    Console.Clear();


                    Console.WriteLine("Оберіть команду:");
                    Console.WriteLine("1 - Поповнити баланс\n2 - Подивитись історію покупок\n3 - Перейти до магазину\n0 - Назад");

                    
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 0:
                            
                            break;
                        case 1:
                            bool flag2 = true;
                            while (flag2)
                            {
                                flag2 = false;
                                Console.Clear();
                                Console.WriteLine("На скільки поповнити баланс?");
                                int add = Convert.ToInt32(Console.ReadLine());
                                if (add > 0)
                                {
                                    CurrCustomer.balance += add;
                                    Console.WriteLine("Баланс успішно поповнено на " + add.ToString("C") +
                                        "\nБаланс дорівнює " + CurrCustomer.balance.ToString("C"));
                                   

                                }
                                else
                                {
                                    flag2 = true;
                                }
                            }
                            Console.WriteLine("\nВведіть 0 щоб повернутися");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 0:
                                    break;
                            }


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



                        default:
                            continue;

                    }
                    break;
                }


            }
        }
        
    }
}

