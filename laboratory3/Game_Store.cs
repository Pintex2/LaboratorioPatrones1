using System;

namespace Games_Factory
{
    public abstract class Game_Store
    {
        public abstract IConsole GetConsole(string console);
    }
}