using System;
namespace AbstractFactory
{
	public class Custumer
	{
		private ISuv _suv;
		private ISedan _sedan;

		public Custumer(IFactory factory)
		{
			_suv = factory.CreateSuv();
			_sedan = factory.CreateSedan();
		}

		public string GetSuvDetails()
		{
			return _suv.ShowDetails();
		}

		public string GetSedanDetails()
		{
			return _sedan.ShowDetails();
		}
	}
}

