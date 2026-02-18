namespace Patterns.Creational.SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            //Конструктор
            //Тут может быть инициализировано все, что угодно
        }


        public static Singleton GetInstance()
        {
            //Кусок "синтаксического сахара"
            _instance ??= new Singleton();
            return _instance;
        }
    }
}