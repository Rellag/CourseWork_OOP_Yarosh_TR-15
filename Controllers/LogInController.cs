using System;
namespace CourseWork.Controllers
{
    public class LogInController : IRun
    {
        public Customer Run(Customer CurrCustomer, List<Customer> customers)
        {

            int id = 0;
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("1 - Створити аккаунт\n2 - Зайти в існуючий");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Введіть своє імʼя:");
                        customers.Add(new Customer {  name = Console.ReadLine() });
                        CurrCustomer = customers.Last();
                        customers.Last().custId = customers.Count();
                        flag = false;
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

                            flag = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }


                    default:
                        continue;
                }
            }
            return CurrCustomer;

        }

        public void Run(Customer CurrCustomer)
        {
            throw new NotImplementedException();
        }
    }
}

