using System;
namespace Singleton{
    public sealed class Logger
    {
        private static Logger instance;
        private Logger()
        {
            Console.WriteLine("Logger instance is created.");
        }
        public static Logger Instance{
            get{
                if(instance==null)
                {
                    instance=new Logger();
                }
                return instance;
            }
        }
        public void log(string logMessage)
        {
            Console.WriteLine($"[{DateTime.Now}] : {logMessage}");
        }
    }
}