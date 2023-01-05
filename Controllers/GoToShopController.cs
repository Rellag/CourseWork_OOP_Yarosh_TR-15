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

            Console.WriteLine("\nВведіть 0 щоб повернутися");
            Console.WriteLine("Введіть: 1 - Разова покупка, 2 - взяти кошик");

            bool flag = true;

            while (flag)
            {
                int typed = Convert.ToInt32(Console.ReadLine());
                switch (typed)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("\nВведіть номер товару щоб купити");
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index > 0 && index < mockProduct.products.Count())
                        {
                            index--;
                            if (mockProduct.products[index].price > CurrCustomer.balance)
                            {
                                Console.WriteLine("У Вас недостатньо коштів!");
                                continue;
                            }
                            CurrCustomer.Buying(mockProduct, index);

                        }
                        break;

                    case 2:
                        

                       
                        while (true)
                        {

                            Console.WriteLine("\nВведіть 0 щоб повернутися");
                            Console.WriteLine("\nВведіть номер товару щоб додати до кошика");
                            index = Convert.ToInt32(Console.ReadLine());

                            if (index == 0)
                            {
                                break;
                            }

                            if (index > 0 && index < mockProduct.products.Count())
                            {
                                CurrCustomer.cart.addToCart(mockProduct.products[index]);
                                Console.WriteLine("Гра " + mockProduct.products[index].name + " в кошику!");
                            }
                            
                        }
                        break;
                }
                flag = false;
            }

                

            

            
            
           
        }


    }

        
    
}

