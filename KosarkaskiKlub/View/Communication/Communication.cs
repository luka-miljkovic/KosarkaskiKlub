﻿using Common;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;

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

        internal List<Trening> PretraziTreninge(Trening trening)
        {
            Request request = new Request
            {
                Operation = Operation.PretraziTreninge,
                RequestObject = trening
            };
            client.SendRequest(request);
            return (List<Trening>)client.GetResponseResult();
        }

        internal  Trening UcitajTrening(Trening t)
        {
            Request request = new Request
            {
                Operation = Operation.UcitajTrening,
                RequestObject = t
            };
            client.SendRequest(request);
            return (Trening)client.GetResponseResult();
        }

        internal ClanKluba UcitajClanaKluba(ClanKluba clanKluba)
        {
            Request request = new Request
            {
                Operation = Operation.UcitajClanaKluba,
                RequestObject = clanKluba
            };
            client.SendRequest(request);
            List<ClanKluba> lista = (List<ClanKluba>)client.GetResponseResult();
            return lista[0];
        }

        internal List<ClanKluba> PretreziClana(ClanKluba clanKluba)
        {
            Request request = new Request
            {
                Operation = Operation.PretraziClana,
                RequestObject = clanKluba
            };
            client.SendRequest(request);
            List<ClanKluba> clanovi = (List<ClanKluba>)client.GetResponseResult();
            return clanovi;
        }

        

        internal void SacuvajPrisustva(BindingList<Prisustvo> prisustva)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajPrisustva,
                RequestObject = prisustva
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SacuvajIzmeneClana(ClanKluba clanKluba)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajIzmeneClana,
                RequestObject = clanKluba
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<SalaZaTrening> VratiSale()
        {
            Request request = new Request
            {
                Operation = Operation.VratiSale
            };
            client.SendRequest(request);
            return (List<SalaZaTrening>)client.GetResponseResult();
        }

        internal void EvidentirajPlacanjeClanarine(Clanarina clanarina)
        {
            Request request = new Request
            {
                Operation = Operation.EvidentirajPlacanjeClanarine,
                RequestObject = clanarina
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SacuvajIZmeneTreninga(Trening trening)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajIzmeneTreninga,
                RequestObject = trening
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<GrupaZaTreniranje> VratiGrupe()
        {
            Request request = new Request
            {
                Operation = Operation.VratiGrupe
            };
            client.SendRequest(request);
            return (List<GrupaZaTreniranje>)client.GetResponseResult();
        }

        internal void SacuvajClana(ClanKluba clanKluba)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajClana,
                RequestObject = clanKluba
            };
            client.SendRequest(request);
            client.GetResponseResult();
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

        internal void SacuvajGrupu(GrupaZaTreniranje grupa)
        {
            Request request = new Request
            {
                Operation = Operation.SacuvajGrupu,
                RequestObject = grupa
            };
            client.SendRequest(request);
            client.GetResponseResult();
        }
    }
}
