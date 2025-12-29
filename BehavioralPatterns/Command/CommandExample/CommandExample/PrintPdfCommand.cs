
namespace CommandExample;

//Concrete Commands
public class PrintPdfCommand : IPrintCommand
{
    private readonly Printer _printer;

    public PrintPdfCommand(Printer printer)
    {
        _printer = printer;
    }
    public void Execute()
    {
        _printer.PrintPdf();
    }
}
