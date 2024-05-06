using Microsoft.EntityFrameworkCore;
using aplicatie.Models; // Asigură-te că importi modelele din aplicația ta
using System.Collections.Generic;
using Microsoft.Win32;

namespace aplicatie.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define DbSet pentru fiecare entitate (tabel) din baza de date
        public DbSet<User> Users { get; set; }
      //  public DbSet<Login> Logins { get; set; }
       // public DbSet<Register> Registers { get; set; }

        // Alte configurații specifice contextului pot fi adăugate aici
    }

}
