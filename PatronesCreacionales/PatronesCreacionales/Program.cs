using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Database bd = Database.getInstance();
            Database bd2 = Database.getInstance();

            if (bd == bd2) {
                Console.WriteLine("SAME INSTANCE");
                bd.query("SELECT * FROM BaseDatos");
            }
        }
    }
}
