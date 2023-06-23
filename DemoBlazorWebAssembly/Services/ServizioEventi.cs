using LIbreriaComponentiBlazor.Interfaces;
using LIbreriaComponentiBlazor.Models;

namespace DemoBlazorWebAssembly.Services;

public class ServizioEventi: IGestioneEventi
{
    private int contatore = 0;
    private List<Evento>? listaEventi;

    public ServizioEventi()
    {
         listaEventi = new List<Evento>
        {
            new Evento { Id = 1, Data = DateTime.Today.AddDays(+7), Località = "Napoli Futuro", Titolo = "Prima lezione Blazor" },
            new Evento { Id = 2, Data = DateTime.Today.AddDays(+14), Località = "Futuro Remoto", Titolo = "Seconda lezione Blazor" }
        };
    }

    public int DammiContatore()
    {
        contatore++;
        return contatore;
    }

    public List<Evento>? EstraiEventi()
    {
        return listaEventi!.OrderBy(x=> x.Id).ToList();
    }

    public void Aggiungi(Evento evento)
    {
        var id = listaEventi!.Max(x => x.Id);
        evento.Id = id + 1;
        listaEventi!.Add(evento);
    }

    public void Modifica(Evento evento)
    {
       var eventoInDb = listaEventi!.Find(x => x.Id == evento.Id);
        if(eventoInDb != null)
        {
            listaEventi.Remove(eventoInDb);
            listaEventi.Add(evento);
        }
    }
}
