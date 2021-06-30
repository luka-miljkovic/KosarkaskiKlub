using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket serverSocket;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<Trener> treneri = new BindingList<Trener>();

        public BindingList<Trener> Treneri { get { return treneri; } }

        public Server()
        {

        }

        public void Start()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            serverSocket.Bind(ep);
            
        }

        public void Listen()
        {
            serverSocket.Listen(10);

            try
            {
                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler clientHandler = new ClientHandler(clientSocket, treneri);
                    clients.Add(clientHandler);
                    Thread thread = new Thread(clientHandler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (SocketException)
            {
                System.Windows.Forms.MessageBox.Show("Kraj rada!");
            }
        }

        public void Stop()
        {
            serverSocket.Close();
            foreach(ClientHandler c in clients)
            {
                c.Stop();
            }
            clients.Clear();
        }
    }
}
