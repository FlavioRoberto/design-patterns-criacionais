using System;
namespace Builder.Computer
{
	public class Computer
	{
        public string ComputerType { get; private set; }

        public Computer(string computerType)
        {
            ComputerType = computerType;
        }
	}
}
