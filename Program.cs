using System;
using DesignPattern;
namespace Singleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            //---get the singleton instance
            Logger instance = Logger.Instance;

            //---use logger to log message
            instance.log("Application is just started");

            //--simulate the logging from different parts of the application
            performTask1();
            performTask2();

            //Closing the application 
            instance.log("Application is finally closed !!!!!");




            //----- This is for testing GameConfiguration manager
            GameConfigurationManger game = GameConfigurationManger.Instance;
            

            do
            {
                Console.WriteLine("Choose any option below: \n 1. for setting a new configuration \n 2. for getting the configuration setting \n 3. To get all the configuration setting\n 4. for exit.");
                int i=int.Parse(Console.ReadLine());    
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter key:");
                        string key=Console.ReadLine();
                        Console.WriteLine("Ente value:");
                        string value=Console.ReadLine();
                        game.setConfigurationSettting(key,value);
                        break;
                    case 2:
                        Console.WriteLine("Enter key:");
                        string key1=Console.ReadLine();
                        string value1=game.getConfigurationSetting(key1);
                        Console.WriteLine(value1);
                        break;
                    case 3:
                        game.getAllList();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose the right option");
                        break;
                }
            } while (true);


            // game.setConfigurationSettting()
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