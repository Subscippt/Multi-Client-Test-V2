using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Net;
using System.Net.Sockets;
namespace Multi_Client_Server
{
    class Program
    {
        static Listener l;
        static List<Socket> sockets;
        static void Main(string[] args)
        {
            Console.WriteLine("started");
            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAcceptedHandler(l_SocketAccepted);
            l.Start();
            Console.Read();
        }
        static void l_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Console.WriteLine("new connection " + e.RemoteEndPoint + " at " + DateTime.Now);
            sockets.Add(e);
        }
    }

}