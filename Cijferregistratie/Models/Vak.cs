using System.ComponentModel.DataAnnotations;

namespace Cijferregistratie.Models;

public class Vak
{
    [Required]
    public string Naam { get; set; }
    
    [Required, MinLength(6)]
    public int EC { get; set; }

}