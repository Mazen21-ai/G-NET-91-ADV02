using System;
using System.Collections.Generic;

public class ProductOperations
{
    // Func: receives a Product and returns true or false.
    public static List<Product> SearchProducts(
        List<Product> products,
        Func<Product, bool> filter)
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (filter(product))
            {
                result.Add(product);
            }
        }

        return result;
    }

    // Action: performs an operation without returning a value.
    public static void PrintReport(
        List<Product> products,
        Action<Product> action)
    {
        foreach (Product product in products)
        {
            action(product);
        }
    }

    // Func: transforms each Product into a string.
    public static List<string> TransformProducts(
        List<Product> products,
        Func<Product, string> transform)
    {
        List<string> result = new List<string>();

        foreach (Product product in products)
        {
            result.Add(transform(product));
        }

        return result;
    }

    // Predicate: checks whether a Product satisfies a condition.
    public static List<Product> FilterProducts(
        List<Product> products,
        Predicate<Product> condition)
    {
        List<Product> result = new List<Product>();

        foreach (Product product in products)
        {
            if (condition(product))
            {
                result.Add(product);
            }
        }

        return result;
    }
}