using System;

namespace CasseBrique
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CasseBrique())
                game.Run();
        }
    }
}
