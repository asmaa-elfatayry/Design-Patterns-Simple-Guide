

namespace CommandExample;

//Concrete Commands
public class PrintImageCommand : IPrintCommand
{
    private readonly Printer _printer;

    public PrintImageCommand(Printer printer)
    {
        _printer = printer;
    }
    public void Execute()
    {
      _printer.PrintImage();
    }
}
