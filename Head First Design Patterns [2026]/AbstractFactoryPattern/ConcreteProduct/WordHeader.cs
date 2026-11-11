using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class WordHeader : IHeader
{
    public void AddHeader(string header)
    {
        Console.WriteLine($"Adding this header to Word header: {header}");
    }
}
