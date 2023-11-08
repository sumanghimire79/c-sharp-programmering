using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;

namespace ItemLendSystemWithLogin.Models
{
    public class ItemLendSystemwithLogin_systemDB:DbContext
    {

        public ItemLendSystemwithLogin_systemDB(DbContextOptions<ItemLendSystemwithLogin_systemDB> options)   : base(options) { }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Lend> Lends { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<ContactForm> contactForm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().HasData(
                new Owner { OID = 1, Name = "Lasse", Email = "testexam@test.dk", Mobile = "27859433" },
                new Owner { OID = 2, Name = "Suman", Email = "suman@test.dk", Mobile = "42308933" },
                new Owner { OID = 3, Name = "Ram", Email = "ram@test.dk", Mobile = "12345678" }
                  );

            modelBuilder.Entity<Item>().HasData(

                  new Item { IID = 1, OID = 1, Name = "Bose bore maskine", UnitPrice = 300.0, Description = "all in one bore maskine", Category = (Item.ItemCategory)0 },
                  new Item { IID = 2, OID = 2, Name = "plastic plate", UnitPrice = 5.0, Description = "reusable party plate", Category = (Item.ItemCategory)1 },
                  new Item { IID = 3, OID = 3, Name = "tent", UnitPrice = 500.0, Description = "light tent for summer", Category = (Item.ItemCategory)2 }
                      );


            modelBuilder.Entity<Lend>().HasData(

                  new Lend { LID = 1, IID = 1, BID = 1, Quantity = 10, LendingDate = DateTime.Now, LendingDays = 1, Note = " thank you for the support." },
                  new Lend { LID = 2, IID = 2, BID = 2, Quantity = 20, LendingDate = DateTime.Now, LendingDays = 3, Note = " thank you for the Lending." },
                  new Lend { LID = 3, IID = 3, BID = 1, Quantity = 5, LendingDate = DateTime.Now, LendingDays = 2, Note = " thank you for the great support." }
                );

            modelBuilder.Entity<Borrower>().HasData(

                  new Borrower { BID = 1, Name = "sher", Mobile = "3333333", Email = "jiwan@test.dk", },
                  new Borrower { BID = 2, Name = "jiwan", Mobile = "44444444", Email = "lovely@test.dk", },
                  new Borrower { BID = 3, Name = "Lasse", Mobile = "66666666", Email = "lost@test.dk", });

            modelBuilder.Entity<ContactForm>().HasData(
                new ContactForm{ CFID = 1, Name = "testName", Email = "testContactEmail@seed.dk", Message = "0.This is test seed message"},
                new ContactForm { CFID = 2, Name = "testName2", Email = "testContactEmail@seed1.dk", Message = "1.This is test seed message" },
                new ContactForm { CFID = 3, Name = "testName3", Email = "testContactEmail@seed2.dk", Message = "2.This is test seed message" }
            );

        }
    }
}
