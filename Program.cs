using System;
using Computers;
namespace Singleton{
    class Program{
        public static void Main(string[] args)
        {
            //---get the singleton instance
            Logger instance= Logger.Instance;

            //---use logger to log message
            instance.log("Application is just started");

            //--simulate the logging from different parts of the application
            performTask1();
            performTask2();

            //Closing the application 
            instance.log("Application is finally closed !!!!!");

            var gamingComputerFactory=new GamingComputerFactory();
            var computerBuilder=gamingComputerFactory.createComputerBuilder();

            computerBuilder.setCpu("Intel i10");
            computerBuilder.setGraphics("NVIDIA RTX 3880");
            computerBuilder.setStorage("2TB ssd");
            computerBuilder.setRam("16 GB");
            var gamingComputer=computerBuilder.Build();

            var laptop=new GamingComputerFactory();
            var laptopBuilder=laptop.createComputerBuilder();
            
            laptopBuilder.setCpu("Intel i10");
            laptopBuilder.setGraphics("NVIDIA RTX 3880");
            laptopBuilder.setStorage("2TB ssd");
            laptopBuilder.setRam("16 GB");
            var laptopComputer=laptopBuilder.Build();

            Console.WriteLine($"\n\nGaming computer specification:\n CPU:{gamingComputer.Cpu}\n RAM:{gamingComputer.Ram}\n Storage:{gamingComputer.Storage}\n Graphics card: {gamingComputer.GraphicsCard}");
            Console.WriteLine($"\n\n Laptop's specification:\n CPU:{laptopComputer.Cpu}\n RAM:{laptopComputer.Ram}\n Storage:{laptopComputer.Storage}\n Graphics card: {laptopComputer.GraphicsCard}");
        }
        public static void performTask1()
        {
            Logger.Instance.log("Task-1 is completed.");
        }
        public static void performTask2()
        {
            Logger.Instance.log("Task-2 is completed");
        }
    }
}