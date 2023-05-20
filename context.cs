using Microsoft.EntityFrameworkCore;
using SuperHeroes.Models;

namespace SuperHeroes
{
    public class context:DbContext
    {
        public DbSet<SuperHero> SuperHeroe {get;set;}

        public context(DbContextOptions<context> options) : base(options){}
    }
}