using System;
namespace Computers
{
    //-------factory interface
    public interface IComputerFactory
    {
        IComputerBuilder createComputerBuilder();
    }
}