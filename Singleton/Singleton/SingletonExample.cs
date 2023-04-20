using static System.Console;

namespace Singleton
{
    public class SingletonExample
    {
        private static SingletonExample instance;
        private int numberOfInstance = 0;

        private SingletonExample()
        {
            WriteLine("Incresing number of instance");
            numberOfInstance++;
            WriteLine($"number of instance: {numberOfInstance}");
        }

        public static SingletonExample Instance
        {
            get
            {
                if (instance == null)
                {
                    WriteLine("Creating firts instance");
                    instance = new SingletonExample();
                }

                return instance;
            }
        }
    }
}

