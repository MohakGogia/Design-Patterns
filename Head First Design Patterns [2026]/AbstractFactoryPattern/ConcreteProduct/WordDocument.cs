using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class WordDocument : IDocument
{
    public void AddContent(string body)
    {
        Console.WriteLine($"Adding this body to Word document: {body}");
    }
}
