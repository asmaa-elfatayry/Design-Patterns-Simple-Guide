
namespace BuilderExample;

public class GamingComputerBuilder : ComputerBuilder
{
    public override void BuildCPU() => computer.CPU = "Intel i9";
    public override void BuildGPU() => computer.GPU = "NVIDIA RTX 4090";
    public override void BuildRAM() => computer.RAM = "32GB";
    public override void BuildStorage() => computer.Storage = "2TB SSD";
}
