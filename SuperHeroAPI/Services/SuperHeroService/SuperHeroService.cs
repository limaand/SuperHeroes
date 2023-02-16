namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero> {
              new SuperHero
              {
                  Id= 1,
                  Name="Batman",
                  FirstName= "Bruce",
                  LastName= "Wane",
                  Place="Goty City"
              },

              new SuperHero
              {
                  Id= 2,
                  Name="SpiderMan",
                  FirstName= "Peter",
                  LastName= "Paker",
                  Place="New York City"
              },


              new SuperHero
              {
                  Id= 3,
                  Name="IronMan",
                  FirstName= "Stark",
                  LastName= "Joson",
                  Place="California City"
              }
        };


        List<SuperHero> ISuperHeroService.GetAllHeroes()
        {
            return superHeroes;
        }

        SuperHero? ISuperHeroService.GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            return hero;
        }

        List<SuperHero> ISuperHeroService.AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        List<SuperHero>? ISuperHeroService.UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            hero.Name = request.Name;

            return superHeroes;
        }

        List<SuperHero>? ISuperHeroService.DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            superHeroes.Remove(hero);
            return superHeroes;
        }
    }
}
