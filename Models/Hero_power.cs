
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;

public class Hero_power
{
    [ForeignKey("Id")]
    public Guid Hero_id { get; set; }

    [ForeignKey("Id")]
    public Guid Power_id { get; set; }

    public virtual ICollection<SuperHero> ?SuperHeros { get; set; }
    public virtual ICollection<Superpower> ?Superpowers { get; set; }
}