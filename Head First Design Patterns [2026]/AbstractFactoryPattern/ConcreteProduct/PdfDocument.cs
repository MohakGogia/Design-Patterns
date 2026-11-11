using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class PdfDocument : IDocument
{
    public void AddContent(string body)
    {
        Console.WriteLine($"Adding this body to PDF document: {body}");
    }
}
