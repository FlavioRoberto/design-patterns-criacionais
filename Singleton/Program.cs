// See https://aka.ms/new-console-template for more information
using Singleton;
using static System.Console;

WriteLine("Trying to create the first singleton instance");
var instance = SingletonExample.Instance;

WriteLine("Trying to create the second singleton instance");
var instance2 = SingletonExample.Instance;

if (instance == instance2)
    WriteLine("Has one instance");
else
    WriteLine("Have two instances");

ReadLine();

