using AbstractFactoryPattern.AbstractCreator;
using AbstractFactoryPattern.AbstractProducts;
using AbstractFactoryPattern.ConcreteProduct;

namespace AbstractFactoryPattern.ConcreteCreators;

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }

    public override IHeader CreateHeader()
    {
        return new PdfHeader();
    }

    public override IFooter CreateFooter()
    {
        return new PdfFooter();
    }

    public override IRenderer CreateRenderer()
    {
        return new PdfRenderer();
    }
}
