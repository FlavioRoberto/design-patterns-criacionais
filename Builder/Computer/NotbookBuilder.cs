using System;
namespace Builder.Computer
{
    public class NotebookBuilder : ComputerBuilder
    {
        private Computer computer;

        public NotebookBuilder()
        {
            computer = new Computer("Notbook");
        }

        public override void BuildDevices()
        {
            Console.WriteLine("Build devices in Notbook...");
        }

        public override void BuildSO()
        {
            Console.WriteLine("Build S0 in Notbook...");
        }

        public override Computer GetComputerType()
        {
            return computer;
        }
    }
}

