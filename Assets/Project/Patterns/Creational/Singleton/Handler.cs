using UnityEngine;

namespace Patterns.Creational.SingletonPattern
{
    public class Handler : MonoBehaviour
    {
        /// <summary>
        /// 
        /// Что тут сказать - паттерн, порождающий и содержащий себя сам, может быть вызван из любой точки проекта.
        /// Удобно. Но не всегда надежно. И лучше слишком часто этим паттерном не разбрасываться, чем меньше - тем лучше.
        /// 
        /// </summary>


        private Singleton _singleton;

        
        void Start()
        {
            _singleton = Singleton.GetInstance();
        }

        
        void Update()
        {
            
        }
    }
}

