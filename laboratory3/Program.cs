using System;

namespace Games_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game_Store store = new Concrete_Game_Store();

            IConsole ps5 = store.GetConsole("Ps5");
            ps5.sell_console("Benito", 500);

            IConsole xbox = store.GetConsole("Xbox");
            xbox.sell_console("juanito", 400);

            Console.ReadKey();
        }
    }
}