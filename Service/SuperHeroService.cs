using System;
using SuperHeroes.Models;

namespace SuperHeroes.Service
{
    public class SuperHero :  ISuperHeroService
    {
        context context;
        public SuperHeroService(context _context)
        {
            context = _context;
        }

        //CRUD
        public async Task CreateAsync(SuperHero newSuperHero)
        {
            newSuperHero.id = Guid.NewGuid();
            await context.AddAsync<SuperHero>(newSuperHero);
            await context.SaveChangesAsync();
        }

        public IEnumerable<SuperHero> Get()
        {
            return context.SuperHero;
        }

        public async Task Update(Guid id, SuperHero updSuperHero)
        {
            var country = context.SuperHero.Find(id);
            if (country != null)
            {
                country.country_name = updSuperHero.SuperHero_name;
                context.Update(country);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            var country = context.SuperHero.Find(id);
            if (country != null)
            {
                context.Remove(SuperHero);
                await context.SaveChangesAsync();
            }
        }
    }
}

public interface IcountryService
{
    Task CreateAsync(SuperHero newSuperHero);
    IEnumerable<SuperHero> Get();
    Task Update(Guid id, SuperHero updSuperHero);
    Task Delete(Guid id);
}