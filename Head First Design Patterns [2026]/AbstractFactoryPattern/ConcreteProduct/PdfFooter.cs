using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class PdfFooter : IFooter
{
    public void AddFooter(string footer)
    {
        Console.WriteLine($"Adding this footer to PDF footer: {footer}");
    }
}
