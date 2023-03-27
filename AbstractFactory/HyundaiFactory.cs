using System;
namespace AbstractFactory
{
	public class HyundaiFactory : IFactory
	{
		public HyundaiFactory()
		{
		}

        public ISedan CreateSedan()
        {
            return new HB20Hyundai();
        }

        public ISuv CreateSuv()
        {
            return new CretaHyundai();
        }
    }
}

