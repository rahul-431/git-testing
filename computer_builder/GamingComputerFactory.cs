using System;
namespace Computers
{
    //concrete factory class
    class GamingComputerFactory : IComputerFactory
    {
        public IComputerBuilder createComputerBuilder()
        {
            return new DesktopComputerBuilder();   
            // throw new NotImplementedException();
        }
    }
}