// See https://aka.ms/new-console-template for more information
using Singleton;
using static System.Console;

Parallel.Invoke(
    () => InvokeThreadOne(),
    () => InvokeThreadTwo());

ReadLine();


void InvokeThreadOne()
{
    WriteLine("Trying to create the first singleton instance");
    var instance = SingletonLazyLoading.Instance;

}

void InvokeThreadTwo()
{
    WriteLine("Trying to create the second singleton instance");
    var instance2 = SingletonLazyLoading.Instance;
}