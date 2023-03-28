using Cijferregistratie.Models;
using Microsoft.EntityFrameworkCore;

namespace Cijferregistratie.Data;

public class CijferContext : DbContext
{
    public DbSet<Vak> DbVak { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseSqlite("Data source=S1159362.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Models.Vak>().HasData(
            new Models.Vak()
            {
                Naam = "server",
                EC = 4
            });
        new Models.Vak()
        {
            Naam = "C#",
            EC = 4
        };
        new Models.Vak()
        {
            Naam = "Databases",
            EC = 3
        };
        new Models.Vak()
        {
            Naam = "UML",
            EC = 3
        };
        new Models.Vak()
        {
            Naam = "KBS",
            EC = 9
        };
    }
}