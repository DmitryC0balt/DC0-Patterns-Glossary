using UnityEngine;

namespace Patterns.Structural.ProxyPattern
{
    public class Handler : MonoBehaviour
    {
        //Ничего необыного, просто предоставление объекта-заместителя, управляющего доступностью другого объекта.
        //Чаще используется при передаче данных через сеть, чтобы имитировать поведение замещаемого класса, до получения ответа
        //А еще есть защитное замещение, виртуальное замещение или создание потокобезопасного исполнения в иногопоточной среде

        private AbstractObject _formular;
       
        void Start()
        {
            _formular = new ProxyObject();
            _formular.Action();
        }
        

        void Update()
        {
            //Всякая другая логика
        }
    }

}
