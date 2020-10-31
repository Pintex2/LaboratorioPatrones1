using System;
namespace Games_Factory
{
    class Xbox : IConsole
    {

        public void sell_console(int consoleCode,string name, int price)
        {
            Console.WriteLine("Console code:"+consoleCode.ToString()+"Xbox selled  to: " + name + " and price: " + price.ToString() + "$");
        }
    }
}
