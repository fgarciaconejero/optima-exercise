using System;

namespace Interfaces
{
    public interface IConsoleHandler
    {
        string ReadString();
        int ReadInt(bool format);
    }
}
