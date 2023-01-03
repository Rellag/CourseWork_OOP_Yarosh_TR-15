using System;
namespace CourseWork
{
    public class Customer
    {
        public int custId { get; set; }
        public string name { get; set; }
        public int balance { get; set; }

        public List<BoughtProduct> history = new List<BoughtProduct>();

        

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



