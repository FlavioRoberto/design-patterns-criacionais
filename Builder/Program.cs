// See https://aka.ms/new-console-template for more information

using Builder.Computer;

var producer = new Producer();

var notebookBuilder = new NotebookBuilder();
var desktopBuilder = new DesktopBuilder();

producer.Build(notebookBuilder);
producer.Build(desktopBuilder);

Console.ReadLine();

