using System;

namespace CouplingDemo
{
    class Program
    {
        public Program()
        {
            var deviceManager = new DeviceManager();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class DeviceManager 
    {
         public DeviceManager()
        {
            var serviceManager = new ServiceManager();
        }
    }

    class ServiceManager 
    {
        
    }
}
