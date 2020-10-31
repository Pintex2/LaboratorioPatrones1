using System;

namespace Games_Factory
{
    public class Concrete_Game_Store : Game_Store
    {
        public override IConsole GetConsole(string console)
        {

            switch (console)
            {
                case "Xbox":
                    return new Xbox();

                case "Ps5":
                    return new Ps5();

                default:
                    throw new Exception(string.Format("Console '{0}' cannot be created", console));


            }
        }
    }
}