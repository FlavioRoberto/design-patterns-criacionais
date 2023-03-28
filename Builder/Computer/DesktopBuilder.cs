using System;
namespace Builder.Computer
{
	public class DesktopBuilder : ComputerBuilder
	{
        private Computer computer;

		public DesktopBuilder()
		{
            computer = new Computer("Desktop");
		}

        public override void BuildDevices()
        {
            Console.WriteLine("Build devices in Desktop...");
        }

        public override void BuildSO()
        {
            Console.WriteLine("Build S0 in Desktop...");
        }

        public override Computer GetComputerType()
        {
            return computer;
        }
    }
}

