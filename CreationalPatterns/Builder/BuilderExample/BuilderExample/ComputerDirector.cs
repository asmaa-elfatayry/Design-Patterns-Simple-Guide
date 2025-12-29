

namespace BuilderExample;

public class ComputerDirector
{
    private ComputerBuilder _builder;

    public void SetBuilder(ComputerBuilder builder) => _builder = builder;

    public Computer BuildComputer()
    {
        _builder.BuildCPU();
        _builder.BuildGPU();
        _builder.BuildRAM();
        _builder.BuildStorage();
        return _builder.GetComputer();
    }
}
