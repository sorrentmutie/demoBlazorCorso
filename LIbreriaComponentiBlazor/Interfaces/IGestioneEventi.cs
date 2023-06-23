
using LIbreriaComponentiBlazor.Models;

namespace LIbreriaComponentiBlazor.Interfaces;

public interface IGestioneEventi
{
    List<Evento>? EstraiEventi();
    int DammiContatore();
    void Aggiungi(Evento evento);
    void Modifica(Evento evento);
}
