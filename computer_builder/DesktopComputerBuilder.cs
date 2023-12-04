using System;
namespace Computers
{
    public class DesktopComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void setCpu(string cpu)
        {
            computer.Cpu=cpu;
            // throw new NotImplementedException();
        }

        public void setGraphics(string graphics)
        {
            computer.GraphicsCard=graphics;
            // throw new NotImplementedException();
        }

        public void setRam(string ram)
        {
            computer.Ram=ram;
            // throw new NotImplementedException();
        }

        public void setStorage(string storage)
        {
            computer.Storage=storage;
            // throw new NotImplementedException();
        }

        Computer IComputerBuilder.Build()
        {
            return computer;
            // throw new NotImplementedException();
        }
    }
}