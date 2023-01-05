using System;
namespace CourseWork.Controllers
{
    public class BalanceController : IRun
    {
        public void Run(Customer CurrCustomer)
        {
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


        }
    }
}

