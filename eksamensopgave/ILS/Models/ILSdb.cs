using Microsoft.EntityFrameworkCore;

namespace ILS.Models
{
    public class ILSdb: DbContext
    {
        public ILSdb( DbContextOptions<ILSdb> options):base (options) { }

        DbSet<Item> items { get; set; }
        DbSet<Lend> lends { get; set; }
        DbSet<ContactForm> contactForms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().HasData(
                 new Item { IID = 1, Name = "Bose bore maskine", UnitPrice = 300.0, Description = "all in one bore maskine", Category = 0 },
                 new Item { IID = 2,  Name = "plastic plate", UnitPrice = 5.0, Description = "reusable party plate", Category = (ItemCategories.ItemCategory?)1 },
                 new Item { IID = 3,  Name = "tent", UnitPrice = 500.0, Description = "light tent for summer", Category = (ItemCategories.ItemCategory?)2 });

            modelBuilder.Entity<Lend>().HasData(
                new Lend { LID = 1, IID = 1, LendingDate = DateTime.Now, LendingDays = 1, TotalAmount = 100.00, Note = " thank you for the support." },
                new Lend { LID = 2, IID = 2, LendingDate = DateTime.Now, LendingDays = 3, TotalAmount = 200.00, Note = " thank you for the Lending." },
                new Lend { LID = 3, IID = 3, LendingDate = DateTime.Now, LendingDays = 2, TotalAmount = 300.00, Note = " thank you for the great support." });

            modelBuilder.Entity<ContactForm>().HasData(
               new ContactForm { CFID = 1, Name = "testName", Email = "testContactEmail@seed.dk", Message = "0.This is test seed message" },
               new ContactForm { CFID = 2, Name = "testName2", Email = "testContactEmail@seed1.dk", Message = "1.This is test seed message" },
               new ContactForm { CFID = 3, Name = "testName3", Email = "testContactEmail@seed2.dk", Message = "2.This is test seed message" } );
        }

    }
}
