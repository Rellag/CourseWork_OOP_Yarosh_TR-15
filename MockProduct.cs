namespace CourseWork
{
    public class MockProduct
    {

       public List<Product> products { get; set; }
        public MockProduct()
        {
            products = new List<Product>();
            int i = 0;
            products.AddRange(new Product[]   {
                new Product
                {
                    id = ++i,
                    name = "Control",
                    desc = "Бігаєш за руденьку дівчину с телікінезом",
                    price = 25,
                    Genre = "Action"
                },

                    new Product
                    {
                        id = ++i,
                        name = "Chivalry2",
                        desc = "Бігаєш за лицаря та всіх стукаєш",
                        price = 40,
                        Genre = "Action"
                    },
                    new Product
                    {
                        id = ++i,
                        name = "Bannerlord",
                        desc = "Бігаєш по великій карті, наймаєш собі армю та стукаєш інші армії",
                        price = 65,
                        Genre = "RPG"
                    },
                    new Product
                    {
                        id = ++i,
                        name = "Dishonored2",
                        desc = "Бігаєш та пригаєш від першого лиця та вбиваєш/вирубає по стелсу/не по стелсу",
                        price = 40,
                        Genre = "Action"
                    },
                    new Product
                    {
                        id = ++i,
                        name = "Skyrim",
                        desc = "Бігаєш по відкритому світу, стукаєш драконів, лутаєшся та прокачуєшся",
                        price = 15,
                        Genre = "RPG"
                    },
                    new Product
                    {
                        id = ++i,
                        name = "SnowRunner",
                        desc = "Симулятор позашляховика на екстримальному покритті",
                        price = 25,
                        Genre = "Simulator"
                    },
                    new Product
                    {
                        id = ++i,
                        name = "goatSimulator3",
                        desc = "Симулятор екстримальної кози",
                        price = 40,
                        Genre = "Simulator"
                    }}) ;
            
        }


       







    }
}

