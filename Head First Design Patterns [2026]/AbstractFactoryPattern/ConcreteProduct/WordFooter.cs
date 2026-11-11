using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class WordFooter : IFooter
{
    public void AddFooter(string footer)
    {
        Console.WriteLine($"Adding this footer to Word footer: {footer}");
    }
}
