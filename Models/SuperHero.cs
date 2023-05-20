using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroes.Models;

    public class SuperHero{
    [ForeignKey("Id")]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(250)]
    public String? superhero_name { get; set; }

    [MaxLength(250)]
    public String? full_name { get; set; }

    [MaxLength(250)]
    public int? gender_id { get; set; }

    [MaxLength(250)]
    public int? eye_colour_id { get; set; }

    [MaxLength(250)]
    public int? hair_colour_id { get; set; }
    
    [MaxLength(250)]
    public int? skin_colour_id { get; set; }

    [MaxLength(250)]
    public int? race_id { get; set; }

    [MaxLength(250)]
    public int? publisher_id { get; set; }

    [MaxLength(250)]
    public int? alignment_id { get; set; }

    [MaxLength(250)]
    public int? height_cm { get; set; }

    [MaxLength(250)]
    public int? weight_kg { get; set; }


    public virtual ICollection<Colour> ?Colours { get; set; }
    public virtual ICollection<Hero_attribute> ?Hero_attributes { get; set; }
    public virtual ICollection<Hero_power> ?Hero_powers { get; set; }
    public virtual ICollection<Alignment> ?Alignments { get; set; }
    public virtual ICollection<Gender> ?Genders { get; set; }
    public virtual ICollection<Publisher> ?Publishers { get; set; }
    public virtual ICollection<Race> ?Races { get; set; }

    }
