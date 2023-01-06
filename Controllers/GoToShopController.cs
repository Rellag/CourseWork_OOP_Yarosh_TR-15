using System;
using CourseWork;
namespace CourseWork.Controllers
{
    public  class GoToShopController: IRun
    {
        public void Run(Customer CurrCustomer)
        {
            
            Console.WriteLine("Товари:");

            MockProduct mockProduct = new MockProduct();
            foreach (Product item in mockProduct.products)
            {
                Console.WriteLine("\n{0}. {1} {2}\nОпис: {3}\nЦіна: {4} " + "\n\n*****************",
                    item.id, item.name, item.Genre, item.desc, item.price.ToString("C"));
            }

            


            while (true)
            {
                Console.WriteLine("\nВведіть 0 щоб повернутися");
                Console.WriteLine("Введіть: 1 - Разова покупка, 2 - взяти кошик");
                int typed = Convert.ToInt32(Console.ReadLine());
                if (typed == 0)
                {
                    break;
                }
                else if (typed == 1)
                {
                    Console.WriteLine("\nВведіть номер товару щоб купити");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index > 0 && index <= mockProduct.products.Count())
                    {
                        index--;
                        if (mockProduct.products[index].price > CurrCustomer.balance)
                        {
                            Console.WriteLine("У Вас недостатньо коштів!");
                            continue;
                        }
                        CurrCustomer.Buying(mockProduct, index);

                    }
                }
                else if (typed == 2)
                {
                    Console.WriteLine("\nВведіть 0 щоб повернутися");
                    Console.WriteLine("\nВведіть номер товару щоб додати до кошика");
                    while (true)
                    {
                        
                        int index = Convert.ToInt32(Console.ReadLine());

                        if (index == 0)
                        {
                            break;
                        }

                        if (index > 0 && index <= mockProduct.products.Count())
                        {
                            index--;
                            CurrCustomer.cart.addToCart(mockProduct.products[index]);
                            Console.WriteLine("Гра " + mockProduct.products[index].name + " в кошику!");
                        }

                    }
                }
                
            }

        }


    }

        
    
}

