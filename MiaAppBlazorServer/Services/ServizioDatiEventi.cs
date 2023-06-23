using LIbreriaComponentiBlazor.Interfaces;
using LIbreriaComponentiBlazor.Models;

namespace MiaAppBlazorServer.Services
{
    public class ServizioDatiEventi : IGestioneEventi
    {
        public ServizioDatiEventi()
        {
                

        }
        int contatore = 0;
        public int DammiContatore()
        {
            contatore += 2;
            return contatore;
        }

        public List<Evento> EstraiEventi()
        {
            return new List<Evento>
        {
            new Evento { Id = 1, Data = DateTime.Today.AddDays(+7), Località = "Napoli Futuro", Titolo = "Prima lezione Blazor" },
            new Evento { Id = 2, Data = DateTime.Today.AddDays(+14), Località = "Futuro Remoto", Titolo = "Seconda lezione Blazor" }
        };
        }

        public void Aggiungi(Evento evento)
        {
            throw new NotImplementedException();
        }

        public void Modifica(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}
