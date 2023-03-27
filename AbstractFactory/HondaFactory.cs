using System;
namespace AbstractFactory
{
	public class HondaFactory : IFactory
	{
		public HondaFactory()
		{
		}

        public ISedan CreateSedan()
        {
            return new HondaCivic();
        }

        public ISuv CreateSuv()
        {
            return new HondaCRV();
        }
    }
}

