using System;
namespace CourseWork
{
    public class Customer
    {
        public int custId { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
        public ShopCart cart = new ShopCart();

        public List<BoughtProduct> history = new List<BoughtProduct>();



        public void Buying(MockProduct mockProduct, int id)
        {
           
            BoughtProduct bought = new BoughtProduct();
            bought.setByAnotherProduct(mockProduct.products[id], DateTime.Now);

            balance -= bought.price;
            Console.WriteLine("Поточний баланс:" + balance);

            history.Add(bought);
        }

        public void Buying(Product product)
        {
            BoughtProduct bought = new BoughtProduct();
            bought.setByAnotherProduct(product, DateTime.Now);

            balance -= bought.price;
            

            history.Add(bought);
        }


        public void BuyingCart()
        {
            foreach(Product item in cart.productsInCart)
            {
                Buying(item);
            }
        }


        public override string? ToString()
        {
            return (custId +": " +name);
        }
    }

    public class BoughtProduct: Product
    {
        public DateTime time { get; set; }

        public void setByAnotherProduct(Product product, DateTime dateTime)
        {
            id = product.id;
            name = product.name;
            desc = product.desc;
            price = product.price;
            Genre = product.Genre;
            time = dateTime;

        }
    }




}



