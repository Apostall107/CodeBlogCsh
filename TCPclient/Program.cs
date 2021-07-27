using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPclient
{
    class Program
    {


        //ip and port of server we will connectiong to.
        const string ip = "127.0.0.1";
        const int port = 8080;
        static void Main(string[] args)
        {



            try
            {
                //geting socket address to launch socket
                IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                // creating socket
                Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                

                tcpSocket.Connect(tcpEndPoint);

                Console.WriteLine("Enter the message: ");
                string message = Console.ReadLine();

                var buffer = Encoding.UTF8.GetBytes(message);
                tcpSocket.Send(buffer);

                buffer = new byte[256];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;


                do
                {
                    bytes = tcpSocket.Receive(buffer, buffer.Length, 0);
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                }
                while (tcpSocket.Available > 0);
                Console.WriteLine("Server responce: " + builder.ToString());

                // закрываем сокет
                tcpSocket.Shutdown(SocketShutdown.Both);
                tcpSocket.Close();

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();

        }
    }
}
