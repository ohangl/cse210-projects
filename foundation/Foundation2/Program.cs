using System;

class Program
{
    static void Main(string[] args)
    {
        // addresses
        Address address1 = new Address("7500 Pellegrini", "Santa Lucia", "San Juan", "Argentina");
        Address address2 = new Address("19 Maria Teresa", "Rivadavia", "San Juan", "Argentina");

        // customers
        Customer customer1 = new Customer(" Angela Chacon", address1);
        Customer customer2 = new Customer("Yair Fonzalida", address2);

        // products
        Product product1 = new Product("Laptop", "A123", 1000, 1);
        Product product2 = new Product("Mouse", "B456", 25, 2);
        Product product3 = new Product("Keyboard", "C789", 50, 1);

        Product product4 = new Product("Camara Nikon", "D001", 200, 1);
        Product product5 = new Product("Football Ball", "E002", 75, 2);

        // orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // order details 
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}
