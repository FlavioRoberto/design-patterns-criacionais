using System;
namespace AbstractFactory
{
	public interface IFactory
	{
		ISuv CreateSuv();
		ISedan CreateSedan();
	}
}

