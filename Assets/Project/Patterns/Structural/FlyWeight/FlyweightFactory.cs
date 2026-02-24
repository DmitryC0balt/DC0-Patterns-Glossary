using System.Collections;
using UnityEngine;

namespace Patterns.Structural.FlyweightPattern
{
    public class FlyweightFactory
    {
        private Hashtable _flyweightsHashtable;

        public FlyweightFactory()
        {
            _flyweightsHashtable = new Hashtable();
        }


        public void AddFlyweight(string flyweightName)
        {
            
        }


        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweightsHashtable.ContainsKey(key))
            {
                
            }

            return null;
        }
    }
}

