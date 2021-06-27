﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Common;
using View.Exceptions;

namespace View.Communication
{
    public class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException ex)
            {
                throw new System.Runtime.Remoting.ServerException(ex.Message);
            }
            catch (SocketException ex)
            {

                throw new System.Runtime.Remoting.ServerException(ex.Message);
            }
        }
        public object GetResponseResult()
        {
            Response response = (Response)receiver.Receive();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Error);
            }
        }
    }
}
