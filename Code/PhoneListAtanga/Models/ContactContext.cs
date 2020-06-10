using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneListAtanga.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note { NoteId = "A", Name = "Aquintance" },
                new Note { NoteId = "B", Name = "Business" },
                new Note { NoteId = "F", Name = "Friend" },
                new Note { NoteId = "C", Name = "Family" }
                );


            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, Name = "Joe Struss", Phone = "515-225-6050", Adress = "5225 SE Gateway Johnston IA 50131", NoteId = "B" },
                new Contact { ContactId = 2, Name = "Jill Dawkins", Phone = "515-225-6525", Adress = "201 Way St Des Moines Iowa 50310", NoteId = "A" },
                new Contact { ContactId = 3, Name = "Jay Atanga", Phone = "515-226-9060", Adress = "1252 Millway WaukeeIowa 50222", NoteId = "C" });
        }
    }
}
