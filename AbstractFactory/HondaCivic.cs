using System;
namespace AbstractFactory
{
	public class HondaCivic : ISedan
	{
        public string ShowDetails()
        {
            return nameof(HondaCivic);
        }
    }
}

