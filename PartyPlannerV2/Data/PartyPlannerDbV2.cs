using Microsoft.EntityFrameworkCore;
using PartyPlannerV2.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace PartyPlannerV2.Data
{
    public class PartyPlannerDbV2 : DbContext
    {
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.;Initial Catalog=PartyPlannerDbV2;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                // Configure the primary key
                entity.HasKey(e => e.EventId);

                // Configure property constraints
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.InfoText).IsRequired();
                entity.Property(e => e.Category).IsRequired();
                entity.Property(e => e.Location).IsRequired();
                entity.Property(e => e.DateTime).IsRequired();
                entity.Property(e => e.Costs).IsRequired();
                entity.Property(e => e.Maxparticipants).IsRequired();
            });

            modelBuilder.Entity<Organizer>(entity =>
            {
                entity.HasKey(o => o.OrganizerId);
                entity.Property(o => o.Name).IsRequired();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.OrderId);
                entity.Property(o => o.DateTime).IsRequired();
                entity.Property(o => o.EventId).IsRequired();
                entity.Property(o => o.Payed).IsRequired();
            });

            modelBuilder.Entity<Cashier>(entity =>
            {
                entity.HasKey(c => c.CashierId);
                entity.Property(c => c.Name).IsRequired();
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(p => p.ParticipantId);
                entity.Property(p => p.Name).IsRequired();
            });
        }
    }
}
