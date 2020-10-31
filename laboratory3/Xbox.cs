using System;
namespace Games_Factory
{
    class Xbox : IConsole
    {

        public void sell_console(string name, int price)
        {
            Console.WriteLine("Xbox selled  to: " + name + " and price: " + price.ToString() + "$");
        }
    }
}