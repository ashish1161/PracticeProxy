using System;

namespace ProxyDemo
{
    interface IService
    {
        void Login(int age);
    }

    class Concreteclass : IService
    {
        public void Login(int age)
        {
            Console.WriteLine("Welcome");
        }
    }
    class Proxy : IService
    {
        private IService _service;
        public Proxy(IService service)
        {
            _service = service;
        }
        public void Login(int age)
        {
            if (age < 18)
            {
                Console.WriteLine($"Your are {age} years which is restricted to enter");
            }
            else
            {
                _service.Login(age);
            }
        }
    }
    class Demo
    {
        public static void Main(string[] args)
        {
           // var conc = new Concreteclass();
             var proxy = new Proxy(new Concreteclass());
            //conc.Login(15);
            proxy.Login(15);

            proxy.Login(18);
        }
    }
}
