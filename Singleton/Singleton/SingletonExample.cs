﻿using static System.Console;

namespace Singleton
{
    public sealed class SingletonExample
    {
        private static SingletonExample instance;
        private static int numberOfInstance = 0;
        private static readonly object lockObject = new object();

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
                if (instance != null)
                    return instance;

                lock (lockObject)
                {
                    if (instance == null)
                    {
                        WriteLine("Creating firts instance");
                        instance = new SingletonExample();
                    }
                }

                return instance;
            }
        }
    }

    public sealed class SingletonExampleWithoutLock
    {
        private static SingletonExampleWithoutLock instance;
        private static int numberOfInstance = 0;

        private SingletonExampleWithoutLock()
        {
        }

        static SingletonExampleWithoutLock()
        {
            WriteLine("Incresing number of instance");
            numberOfInstance++;
            WriteLine($"number of instance: {numberOfInstance}");

            instance = new SingletonExampleWithoutLock();
        }

        public static SingletonExampleWithoutLock Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class SingletonEagerLoading
    {
        private static SingletonEagerLoading instance = new SingletonEagerLoading();
        private static int numberOfInstance = 0;

        private SingletonEagerLoading()
        {
            WriteLine("Incresing number of instance");
            numberOfInstance++;
            WriteLine($"number of instance: {numberOfInstance}");
        }

        public static SingletonEagerLoading Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class SingletonLazyLoading
    {
        private static readonly Lazy<SingletonLazyLoading> Instancelock =
            new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());

        private static int numberOfInstance = 0;

        private SingletonLazyLoading()
        {
            WriteLine("Incresing number of instance");
            numberOfInstance++;
            WriteLine($"number of instance: {numberOfInstance}");
        }

        public static SingletonLazyLoading Instance
        {
            get
            {
                return Instancelock.Value;
            }
        }
    }
}

