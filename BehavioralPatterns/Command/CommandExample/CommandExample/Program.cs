using CommandExample;

Printer printer = new Printer();

IPrintCommand pdfCommand = new PrintPdfCommand(printer);
IPrintCommand imageCommand = new PrintImageCommand(printer);

PrintButton button = new PrintButton();

// Print PDF
button.SetCommand(pdfCommand);
button.Click();

// Print Image
button.SetCommand(imageCommand);
button.Click();

//One Button – Many Actions
//❌ The button did NOT change
//❌ The printer did NOT change
//✅ Only the command reference changed