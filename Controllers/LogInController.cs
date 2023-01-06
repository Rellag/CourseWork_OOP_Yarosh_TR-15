using System;
namespace CourseWork.Controllers
{
    public class LogInController : IRun
    {
        public Customer Run(List<Customer> customers)
        {
            Customer CurrCustomer = null;


            while (true)
            {


                Console.Clear();
                Console.WriteLine("1 - Створити аккаунт\n2 - Зайти в існуючий");

                int typed = Convert.ToInt32(Console.ReadLine());
                if (typed == 0)
                {
                    break;
                }else if(typed == 1)
                {
                    Console.WriteLine("Введіть своє імʼя:");
                    customers.Add(new Customer { name = Console.ReadLine() });
                    CurrCustomer = customers.Last();
                    customers.Last().custId = customers.Count();
                    break;
                }
                else if (typed == 2)
                {
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
                        Console.WriteLine("Немає такого акаунту");
                        Console.ReadKey();
                    }
                    
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

