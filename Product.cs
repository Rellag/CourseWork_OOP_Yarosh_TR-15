using System;
namespace CourseWork
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int price{ get; set; }
        public string Genre { get; set; }

        public void setByAnotherProduct(Product product)
        {
            id = product.id;
            name = product.name;
            desc = product.desc;
            price = product.price;
            Genre = product.Genre;
        }


    }
}

