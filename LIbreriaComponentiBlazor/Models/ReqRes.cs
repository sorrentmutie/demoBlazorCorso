using System.ComponentModel.DataAnnotations;

namespace LIbreriaComponentiBlazor.Models;

public class ReqResNewUser
{
    [Required(ErrorMessage = "Il nome è obbligatorio")]
    public string? name { get; set; }
    [Required(ErrorMessage = "Il lavoro è obbligatorio")]
    public string? job { get; set; }
}


public class ReqResNewUserResponse
{
    public string? name { get; set; }
    public string? job { get; set; }
    public string? id { get; set; }
    public DateTime createdAt { get; set; }
}


public class ReqResData
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public Person[]? data { get; set; }
    public Support? support { get; set; }
}

public class Support
{
    public string? url { get; set; }
    public string? text { get; set; }
}

public class Person
{
    public int id { get; set; }
    public string? email { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public string? avatar { get; set; }

    public override string ToString()
    {
        return first_name + " " + last_name;
    }
}


