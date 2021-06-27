﻿using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void Stop()
        {
            serverSocket.Close();
        }
    }
}
