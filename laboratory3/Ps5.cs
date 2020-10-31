using System;

namespace Games_Factory
{
    class Ps5 : IConsole
    {
        public void sell_console(int consoleCode,string name, int price)
        {

            Console.WriteLine("Console code:"+consoleCode.ToString()+"Ps5 selled to : " + name + " and price: " + price.ToString() + "$");
        }
    }
}
