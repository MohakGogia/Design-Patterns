using AbstractFactoryPattern;
using AbstractFactoryPattern.AbstractCreator;
using AbstractFactoryPattern.ConcreteCreators;

const string header = "Header";
const string footer = "Footer";
const string body = "Body content";

DocumentFactory pdfFactory = new PdfDocumentFactory();

var pdfService = new DocumentService(pdfFactory);
pdfService.CreateDocument(header, footer, body);

Console.WriteLine("\n--------------------------\n");

DocumentFactory wordFactory = new WordDocumentFactory();

var wordService = new DocumentService(wordFactory);
wordService.CreateDocument(header, footer, body);
