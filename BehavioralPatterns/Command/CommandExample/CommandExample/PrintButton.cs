
namespace CommandExample;

//Invoker (زرار Print)
/// <summary>
///  الزرار:
//لا يعرف PDF
//لا يعرف Image
//بس ينفّذ الأمر اللي معاه
/// </summary>
public class PrintButton
{

    private IPrintCommand _command;

    public void SetCommand(IPrintCommand command)
    {
        _command = command;
    }

    public void Click()
    {
        _command.Execute();
    }
}
