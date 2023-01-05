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
           
            foreach (Product item in CurrCustomer.cart.productsInCart)
            {
                
                
                sum += item.price;
                Console.WriteLine("\n{0}. {1} {2}\nЦіна: {3}" +
                    "\n\n-----------------------------------",
                     CurrCustomer.cart.productsInCart.IndexOf(item), item.name, item.Genre, item.price.ToString("C"));
            }

            Console.WriteLine("Загальна вартість: " + sum.ToString("C"));

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nВведіть 1 - щоб купити продукти з кошику, 2 - видалити товар з кошику, 0 - назад");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        if (CurrCustomer.balance >= sum)
                        {
                            CurrCustomer.BuyingCart();
                            Console.WriteLine("Поточний баланс:" + CurrCustomer.balance);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У вас не достатнь грошей на рахунку, поповніть баланс або видаліть декілька товарів з кошику");
                            continue;
                        }

                    case 2:
                        Console.WriteLine("Введіть номер товару, що хочете видалити");
                        int typed = Convert.ToInt32(Console.ReadLine());
                       
                        CurrCustomer.cart.removeProduct(typed-1);
                        
                        break;
                }
            }
        }
    }
}

