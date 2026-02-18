using System.Collections.Generic;


namespace Patterns.Creational.BuilderPattern
{
    public class Product
    {
        private List<object> _partsList;


        public Product()
        {
            _partsList = new List<object>();
        }


        public void AddPart(object part)
        {
            _partsList.Add(part);
        }


        //Место для логики
    }
}