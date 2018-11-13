using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Video
{
    enum ConnectionState
    {
        Connecting,
        Connected,
        Disconnecting,
        Disconnected
    }
    class Program
    {
        static void Test(ConnectionState connectionstate)
        {
            switch(connectionstate)
            {
                case ConnectionState.Connected:break;
            }
        }
        static void Main(string[] args)
        {
            ConnectionState connectionstate = new ConnectionState();

            Console.ReadKey();
        }

    }
}
