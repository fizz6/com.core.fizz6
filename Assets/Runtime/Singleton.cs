namespace Fizz6.Core
{
    public class Singleton<T> where T : class, new()
    {
        private static T _instance;
        public static T Instance => _instance ??= new T();
    }
}