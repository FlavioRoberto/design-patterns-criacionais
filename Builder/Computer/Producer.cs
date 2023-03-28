using System;
namespace Builder.Computer
{
	public class Producer
	{
		public void Build(ComputerBuilder builder)
		{
			builder.BuildDevices();
			builder.BuildSO();
		}
	}
}

