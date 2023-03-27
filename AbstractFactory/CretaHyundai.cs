using System;
namespace AbstractFactory
{
	public class CretaHyundai : ISuv
	{
		public CretaHyundai()
		{
		}

        public string ShowDetails()
        {
            return nameof(CretaHyundai);
        }
    }
}

