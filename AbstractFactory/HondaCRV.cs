using System;
namespace AbstractFactory
{
	public class HondaCRV : ISuv
	{
        public string ShowDetails()
        {
            return nameof(HondaCRV);
        }
    }
}

