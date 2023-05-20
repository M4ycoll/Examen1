using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroes.Models;

public class Superpower
{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public String? Power_name { get; set; }

    public virtual ICollection<Hero_power> ?Hero_powers { get; set; }
}