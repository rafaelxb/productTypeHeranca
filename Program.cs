// See https://aka.ms/new-console-template for more information
using teste.Entities;
using System.Globalization;


CultureInfo Culture = new CultureInfo("pt-BR");
List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int quantity = int.Parse(Console.ReadLine());

for(int i = 1; i <= quantity; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)?");
    char productType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    
    if (productType == char.Parse("c")){
        Product product = new Product(name,price);
        products.Add(product);
    }
    else if (productType == char.Parse("i")){
        Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine(), Culture);
        ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
        products.Add(importedProduct);

    } else {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = Convert.ToDateTime(Console.ReadLine(),Culture);                
        UsedProduct usedProduct = new UsedProduct(name, price,manufactureDate);
        products.Add(usedProduct);
    }
}

foreach(Product product in products)
{
    Console.WriteLine(product.priceTag().ToString());
}

