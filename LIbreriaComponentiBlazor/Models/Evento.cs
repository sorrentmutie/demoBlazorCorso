using System.ComponentModel.DataAnnotations;

namespace LIbreriaComponentiBlazor.Models;

public class Evento
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il titolo è obbligatorio")]
    public string? Titolo { get; set; }
    public DateTime Data { get; set; }
    [Required(ErrorMessage = "La località è obbligatorio")]
    [StringLength(20, ErrorMessage = "La lunghezza può essere al massimo di {1} caratteri")]
    public string? Località { get; set; }
}
