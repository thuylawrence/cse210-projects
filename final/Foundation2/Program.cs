using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Customer customer = new Customer("David Jensen", "1 Boulevard, Bountiful, Utah, USA");
        Order order = new Order(customer);

        Product product1 = new Product("Shoes", 1, 1, 15.6);
        Product product2 = new Product("Shirt", 2, 1, 8.5);
        Product product3 = new Product("Dress", 3, 1, 17.8);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);


        Order order1 = new Order(customer);
        Product product4 = new Product("Book", 4, 1, 7.5);
        Product product5 = new Product("Pen", 5, 1, 1);
        Product product6 = new Product("Notebook", 6, 1, 2);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order1.AddProduct(product6);

        order.DisplayFinalOrder();
        order1.DisplayFinalOrder();
        

    }
}