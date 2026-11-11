using AbstractFactoryPattern.AbstractCreator;
using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern;

public class DocumentService
{
    private readonly DocumentFactory _factory;

    public DocumentService(DocumentFactory factory)
    {
        _factory = factory;
    }

    public void CreateDocument(string headerContent, string footerContent, string body)
    {
        IHeader header = _factory.CreateHeader();
        IFooter footer = _factory.CreateFooter();
        IDocument document = _factory.CreateDocument();
        IRenderer renderer = _factory.CreateRenderer();

        header.AddHeader(headerContent);
        footer.AddFooter(footerContent);
        document.AddContent(body);

        renderer.Render();

        Console.WriteLine("Document creation complete.");
    }
}
