﻿using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace View.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {

        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            client = new CommunicationClient(socket);

        }

        internal Trener Login(string korisnickoIme, string lozinka)
        {
            Request request = new Request
            {
                Operation = Operation.Login,
                RequestObject = new Trener { KorisnickoIme = korisnickoIme, Lozinka = lozinka }
            };
            client.SendRequest(request);
            return (Trener)client.GetResponseResult();
        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }
    }
}
