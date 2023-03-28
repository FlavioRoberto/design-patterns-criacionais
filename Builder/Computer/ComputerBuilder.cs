using System;
namespace Builder.Computer
{
	public abstract class ComputerBuilder
	{
        public abstract Computer GetComputerType();
        public abstract void BuildSO();
        public abstract void BuildDevices();
	}
}

