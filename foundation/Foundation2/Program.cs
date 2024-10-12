using System;

class Program
{
    static void Main(string[] args)
    {
      //getting the customer name and address
      Customer customer = new Customer("Emmanuel Lambert",new Address("Norman", "Nungua", "Accra", "Ghana"));
      Customer customer1 = new Customer("Empress Tabitha", new Address("Marple", "New York", "New Jersey", "USA"));

      //getting the product for customer 
      Order order = new Order(customer);
      order.ProductList(new Product("Milo", "MIL", 20, 5));
      order.ProductList(new Product("Cowbell", "COW", 30, 5 ));
      order.ProductList(new Product("This Way", "THI", 10, 3));

      //getting the product for customer 1
      Order order1 = new Order(customer1);
      order1.ProductList(new Product("Nano", "NAN", 15, 4));
      order1.ProductList(new Product("Lovan", "LOV", 0.5, 6));

      Console.WriteLine($"Order: ");
      Console.WriteLine($"Shipping Information: \n{order.GetShippingInformation(customer.ShippingInformation())} \n");
      Console.WriteLine($"Packing Label Information:\n{order.GetPackingLable()}\n");   
      Console.WriteLine($"Total Cost is: {order.TotalPrice(order.ShippingFee(customer.GetAddress()))}");

      Console.WriteLine();

      Console.WriteLine($"Order One: ");
      Console.WriteLine($"Shipping Information: \n{order1.GetShippingInformation(customer1.ShippingInformation())} \n");
      Console.WriteLine($"Packing Label Information:\n{order1.GetPackingLable()}\n");   
      Console.WriteLine($"Total Cost is: {order1.TotalPrice(order1.ShippingFee(customer1.GetAddress()))}");
    }
}