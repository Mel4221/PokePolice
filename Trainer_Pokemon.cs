using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; 
using System; 
using System.ComponentModel.DataAnnotations;
namespace PokePolice
{
   // [Keyless]
   public class Trainer
    {
        [Key]
        public int Code;
        public string Name = null; 
        public string City;
        public string Phone;
        public string Email;
        public List<Pokemon> Pokemons;
    }

   // [Keyless]
    public class Pokemon
    {
        [Key]
        public int Code;
        public string Name;
        public string Color;
        public string Tipo;
        public double Latitude;
        public double Longitude;
    }
       public class PokeContext : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlite("Data Source=PokeDB.db");
        }
    }
}
