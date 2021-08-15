using System;

namespace AGLW_CSharp_BasicChatServerSample
{
    class Program
    {
        static private ChatServer server = null;
        static void Main(string[] args)
        {
            server = new ChatServer();
            server.Start();

            // It might be looping forever.
            // It's just a test for the build,
            // we will terminate the GameLift fleet manually ourself.
            // So nothing to worry here.
            while (server.IsAlive)
            {

            }

            Console.WriteLine("Program ends.");
        }
    }
}
