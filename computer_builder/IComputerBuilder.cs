using System;
namespace Computers
{
    public interface IComputerBuilder
    {
        void setCpu(string cpu);
        void setRam(string ram);
        void setStorage(string storage);
        void setGraphics(string graphics);
        Computer Build();
    }
}