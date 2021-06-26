using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket clientSocket;

        public ClientHandler(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(clientSocket);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                //users.Remove(loggedInUser);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                //users.Remove(loggedInUser);

            }
        }

        private Response ProcessRequest(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
