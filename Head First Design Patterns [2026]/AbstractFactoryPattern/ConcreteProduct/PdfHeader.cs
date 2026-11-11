using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class PdfHeader : IHeader
{
    public void AddHeader(string header)
    {
        Console.WriteLine($"Adding this header to PDF header: {header}");
    }
}
