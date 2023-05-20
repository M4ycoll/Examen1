using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;

public class Alignment
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public String? alignment{ get; set; }

    public virtual ICollection<SuperHero> ?SuperHeros { get; set; }
}