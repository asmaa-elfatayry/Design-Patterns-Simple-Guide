using BuilderExample;

ComputerDirector director = new ComputerDirector();

ComputerBuilder gamingBuilder = new GamingComputerBuilder();
director.SetBuilder(gamingBuilder);
Computer gamingPC = director.BuildComputer();
gamingPC.ShowSpecs();


ComputerBuilder officeBuilder = new OfficeComputerBuilder();
director.SetBuilder(officeBuilder);
Computer officePC = director.BuildComputer();
officePC.ShowSpecs();

// without builder design pattern
Computer gamingPC2 = new Computer();
gamingPC2.CPU = "Intel i11";
gamingPC2.GPU = "NVIDIA RTX 4090";
gamingPC2.RAM = "64GB";
gamingPC2.Storage = "2TB SSD";
gamingPC2.ShowSpecs();