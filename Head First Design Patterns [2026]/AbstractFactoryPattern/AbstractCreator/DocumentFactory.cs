using AbstractFactoryPattern.AbstractProducts;

namespace AbstractFactoryPattern.AbstractCreator;

public abstract class DocumentFactory
{ 
    public abstract IDocument CreateDocument();
    public abstract IHeader CreateHeader();
    public abstract IFooter CreateFooter();
    public abstract IRenderer CreateRenderer();
}
