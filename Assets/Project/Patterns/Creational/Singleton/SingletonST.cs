namespace Patterns.Creational.SingletonPattern
{
    public class SingletonST
    {
        //Версия Safety Thread (Потокобезопасная)
        private static readonly SingletonST _instance = new SingletonST();

        public static SingletonST GetInstance() => _instance;

        private SingletonST()
        {
            //Конструктор для инициализации всякой всячины
        }

    }

}