using System;

public class Program
{
    public static void Main(string[] args)
    {
        var products = ProductCatalog.Catalog;


        var electronics = ProductOperations.SearchProducts(
            products,
            product => product.Category == "Electronics"
        );

        foreach (var product in electronics)
        {
            Console.WriteLine(product.Name);
        }

        var cheapProducts = ProductOperations.SearchProducts(
            products,
            product => product.Price < 50
        );

        foreach (var product in cheapProducts)
        {
            Console.WriteLine(product.Name);
        }

        var inStock = ProductOperations.SearchProducts(
            products,
            product => product.Stock > 0
        );

        foreach (var product in inStock)
        {
            Console.WriteLine(product.Name);
        }

        var clothingUnder100 = ProductOperations.SearchProducts(
            products,
            product => product.Category == "Clothing" && product.Price < 100
        );

        foreach (var product in clothingUnder100)
        {
            Console.WriteLine(product.Name);
        }



        ProductOperations.PrintReport(
            products,
            product => Console.WriteLine($"{product.Name} - ${product.Price}")
        );

        ProductOperations.PrintReport(
            products,
            product => Console.WriteLine(
                $"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}"
            )
        );


        var summaryList = ProductOperations.TransformProducts(
            products,
            product => $"{product.Name} (${product.Price})"
        );

        foreach (var item in summaryList)
        {
            Console.WriteLine(item);
        }

        var priceLabels = ProductOperations.TransformProducts(
            products,
            product => product.Price > 100 ? "Expensive!" : "Affordable"
        );

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{products[i].Name}: {priceLabels[i]}");
        }


        var lowStockProducts = ProductOperations.FilterProducts(
            products,
            product => product.Stock < 20
        );

        foreach (var product in lowStockProducts)
        {
            Console.WriteLine(
                $"[LOW STOCK] {product.Name}: only {product.Stock} left!"
            );
        }
    }
}