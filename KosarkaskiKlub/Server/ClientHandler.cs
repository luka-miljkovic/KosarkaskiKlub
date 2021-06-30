using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private readonly BindingList<Trener> treneri;
        private Trener ulogovanTrener;

        public ClientHandler(Socket clientSocket, BindingList<Trener> treneri)
        {
            this.clientSocket = clientSocket;
            this.treneri = treneri;
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
                        System.Windows.Forms.MessageBox.Show(ex.Message);
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
                treneri.Remove(ulogovanTrener);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                treneri.Remove(ulogovanTrener);
 
            }
        }

        internal void Stop()
        {
            clientSocket.Close();
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;

            switch (request.Operation)
            {
                case Operation.Login:
                    Trener trener = Controller.Controller.Instance.Login((Trener)request.RequestObject);
                    if(trener != null)
                    {
                        foreach(Trener t in treneri)
                        {
                            if(t.KorisnickoIme == trener.KorisnickoIme && t.Lozinka == trener.Lozinka)
                            {
                                //System.Windows.Forms.MessageBox.Show("Vec ste ulogovani!");
                                trener = null;
                                break;
                            }
                        }
                        if(trener != null)
                        {
                            ulogovanTrener = trener;
                            treneri.Add(ulogovanTrener);
                        }
                    }
                    response.Result = trener;
                    break;
                case Operation.VratiSale:
                    List<SalaZaTrening> rez =(List<SalaZaTrening>)Controller.Controller.Instance.VratiSveSale(new SalaZaTrening());
                    response.Result = rez;
                    break;
                case Operation.SacuvajGrupu:
                    Controller.Controller.Instance.SacuvajGrupu((GrupaZaTreniranje)request.RequestObject);
                    break;
                default:
                    break;
            }
            return response;
        }
    }
}
