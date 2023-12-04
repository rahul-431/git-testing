using System;
namespace Singleton{
    class Program{
        public static void Main(string[] args)
        {
            //---get the singleton instance
            Logger instance= Logger.Instance;

            //---use logger to log message
            instance.log("Application started");

            //--simulate the logging from different parts of the application
            performTask1();
            performTask2();

            //Closing the application 
            instance.log("Application closed");
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