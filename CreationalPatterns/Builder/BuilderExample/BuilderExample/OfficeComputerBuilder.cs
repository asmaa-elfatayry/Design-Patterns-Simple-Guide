
namespace BuilderExample;

public class OfficeComputerBuilder : ComputerBuilder
{
    public override void BuildCPU() => computer.CPU = "Intel i5";
    public override void BuildGPU() => computer.GPU = "Integrated";
    public override void BuildRAM() => computer.RAM = "16GB";
    public override void BuildStorage() => computer.Storage = "512GB SSD";
}
