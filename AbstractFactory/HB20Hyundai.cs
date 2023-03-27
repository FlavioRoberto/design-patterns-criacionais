using System;
namespace AbstractFactory
{
    public class HB20Hyundai : ISedan
    {
        public string ShowDetails()
        {
            return nameof(HB20Hyundai);
        }
    }
}

