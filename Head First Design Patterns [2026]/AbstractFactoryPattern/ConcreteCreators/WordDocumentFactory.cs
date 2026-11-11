using AbstractFactoryPattern.AbstractCreator;
using AbstractFactoryPattern.AbstractProducts;
using AbstractFactoryPattern.ConcreteProduct;

namespace AbstractFactoryPattern.ConcreteCreators;

public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }

    public override IHeader CreateHeader()
    {
        return new WordHeader();
    }

    public override IFooter CreateFooter()
    {
        return new WordFooter();
    }

    public override IRenderer CreateRenderer()
    {
        return new WordRenderer();
    }
}
