using System;
using System.Collections.Generic;
using System.Text;

namespace CommandExample;

//Receiver الكائن اللي هينفذ الأمر
public class Printer
{
    public void PrintPdf()
    {
        Console.WriteLine("Printing PDF file...");
    }

    public void PrintImage()
    {
        Console.WriteLine("Printing Image file...");
    }
}
