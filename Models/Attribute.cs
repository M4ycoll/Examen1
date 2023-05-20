

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;
public class Attribute{

    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [MaxLength(250)]
    public string? Attribute_name { get; set; }

    

    public virtual ICollection<Hero_attribute> ?Hero_attributes { get; set; }
}