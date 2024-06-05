using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Samuel", "AV. Chiquicollo", "Tiquipaya", "CBBA", "BO");

        order1.AddProduct(new Product("Zandia", "A23", 10, 1));
        order1.AddProduct(new Product("Papaya", "S024", 8, 2));
        order1.AddProduct(new Product("Chiken", "R300", 12, 3));

        // Product product1 = new Product("Zandia", 1234, 10, 1);
        // Product product2 = new Product("Papaya", 2345, 8, 2);
        // Product product3 = new Product("Chiken", 3456, 12, 3);


        // order1.AddProduct(product1);
        // order1.AddProduct(product2);
        // order1.AddProduct(product3);

        order1.PackingLable();

        Order order2 = new Order("Samuel", "AV. Chiquicollo", "Tiquipaya", "CBBA", "US");

        order2.AddProduct(new Product("Tortillas", "A23", 10, 1));
        order2.AddProduct(new Product("Papaya", "S024", 8, 2));
        order2.AddProduct(new Product("Chiken", "R300", 12, 3));
        order2.PackingLable();





    }
}