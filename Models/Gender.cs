using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;

public class Gender
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public _Gender gender { get; set; } 
    public enum _Gender{
        Male,
        Female,
        dontSpecify,

    }



    public virtual ICollection<SuperHero> ?SuperHeros { get; set; }
}

