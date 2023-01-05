using System;
namespace CourseWork
{
    public class ShopCart
    {
        public List<Product> productsInCart = new List<Product>();

        public void addToCart(Product product)
        {
            productsInCart.Add(product);
        }

        public void removeProduct(Product product)
        {
            productsInCart.Remove(product);
        }

        public void removeProduct(int index)
        {
            if(productsInCart.Count() >= index && index >= 0)
            {
                productsInCart.Remove(productsInCart[index]);
            }
            
        }
    }
}

