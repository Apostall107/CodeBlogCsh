using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _18socketsClientServer
{
    class Program
    {

        const string ip = "127.0.0.1";
        const int port = 8080;
        static void Main(string[] args)
        {

            //geting socket address to launch socket
            IPEndPoint tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            // creating socket
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            try
            {

                //binding socken and local point through wich we will get data
                listenSocket.Bind(tcpEndPoint);
                // starting to listen
                listenSocket.Listen(8);

                Console.WriteLine("Server has been launched.");

                while (true)
                {

                    Socket listener = listenSocket.Accept();
                    //geting message
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // quantity of bytes we get
                    byte[] buffer = new byte[256]; // buffer for receiving data

                    do
                    {
                        bytes = listener.Receive(buffer);
                        builder.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
                    } while (listener.Available > 0);

                    Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString()); // TODO: check without ToString 


                    // sendong an answer
                    string message = "Message received.";
                    buffer = Encoding.UTF8.GetBytes(message);
                    listener.Send(buffer);
                    //closing or socket
                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }





        }
    }
}
