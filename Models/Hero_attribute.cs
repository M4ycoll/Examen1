
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;
public class Hero_attribute{

    [ForeignKey("Id")]
    public Guid Hero_id { get; set; }

    [ForeignKey("Id")]
    public Guid Attribute_id { get; set; }

    [MaxLength(250)]
    public string? Attribute_value { get; set; }


    public virtual ICollection<SuperHero> ?SuperHeros { get; set; }
    public virtual ICollection<Attribute> ?Attributes { get; set; }
}