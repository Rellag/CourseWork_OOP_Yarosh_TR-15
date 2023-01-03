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
            Console.WriteLine("Оберіть номер гри, яку хочете купити");

            bool flag = true;
            while (flag){

                int typed = (Convert.ToInt32(Console.ReadLine()));
                switch (typed)
                {
                    case 0:
                        flag = false;
                      
                        break;
                }

                if(typed > 0 && typed < mockProduct.products.Count())
                {
                    if(mockProduct.products[typed - 1].price > CurrCustomer.balance)
                    {
                        Console.WriteLine("У Вас недостатньо коштів!");
                        continue;
                    }
                    BoughtProduct bought = new BoughtProduct();
                    bought.setByAnotherProduct(mockProduct.products[typed - 1], DateTime.Now);

                    CurrCustomer.balance -= bought.price;
                    Console.WriteLine("Поточний баланс:" + CurrCustomer.balance);

                    CurrCustomer.history.Add(bought);
                }

            }

            
            
           
        }


    }

        
    
}

