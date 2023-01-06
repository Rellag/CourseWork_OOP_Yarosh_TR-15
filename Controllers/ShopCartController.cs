using System;
namespace CourseWork.Controllers
{
    public class ShopCartController : IRun
    {
        public void Run(Customer CurrCustomer)
        {
            Console.WriteLine("***********************************" +
                "\n\t{0}\tВ Кошику зараз\n***********************************", CurrCustomer.name);
            int sum = 0;
            int index = 0;
           
            foreach (Product item in CurrCustomer.cart.productsInCart)
            {
                index++;
                
                sum += item.price;
                Console.WriteLine("\n{0}. {1} {2}\nЦіна: {3}" +
                    "\n\n-----------------------------------",
                   index, item.name, item.Genre, item.price.ToString("C"));
            }

            Console.WriteLine("Загальна вартість: " + sum.ToString("C"));

            
            while (true)
            {
                Console.WriteLine("\nВведіть 1 - щоб купити продукти з кошику, 2 - видалити товар з кошику, 0 - назад");

                int typed = Convert.ToInt32(Console.ReadLine());
                if (typed == 0)
                {
                    break;
                }
                else if (typed == 1)
                {
                    if (CurrCustomer.balance >= sum)
                    {
                        CurrCustomer.BuyingCart();
                        Console.WriteLine("Поточний баланс:" + CurrCustomer.balance.ToString("C"));
                        Console.WriteLine("введіть будь-що, щоб продовжити");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("У вас не достатнь грошей на рахунку, поповніть баланс або видаліть декілька товарів з кошику");
                       
                    }
                }
                else if (typed ==2)
                {
                    Console.WriteLine("Введіть номер товару, що хочете видалити");
                    typed = Convert.ToInt32(Console.ReadLine());

                    CurrCustomer.cart.removeProduct(typed - 1);
                }

               
            }
        }
    }
}

