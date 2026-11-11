using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.ConcreteProduct;

public class WordRenderer : IRenderer
{
    public void Render()
    {
        Console.WriteLine($"Rendering Word document...");
    }
}
