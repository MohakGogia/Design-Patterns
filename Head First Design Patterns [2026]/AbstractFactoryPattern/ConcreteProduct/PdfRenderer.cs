using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class PdfRenderer : IRenderer
{
    public void Render()
    {
        Console.WriteLine($"Rendering PDF...");
    }
}
