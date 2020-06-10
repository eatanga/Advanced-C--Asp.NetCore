﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneListAtanga.Models;

namespace PhoneListAtanga.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneListAtanga.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("NoteId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Adress = "5225 SE Gateway Johnston IA 50131",
                            Name = "Joe Struss",
                            NoteId = "B",
                            Phone = "515-225-6050"
                        },
                        new
                        {
                            ContactId = 2,
                            Adress = "201 Way St Des Moines Iowa 50310",
                            Name = "Jill Dawkins",
                            NoteId = "A",
                            Phone = "515-225-6525"
                        },
                        new
                        {
                            ContactId = 3,
                            Adress = "1252 Millway WaukeeIowa 50222",
                            Name = "Jay Atanga",
                            NoteId = "C",
                            Phone = "515-226-9060"
                        });
                });

            modelBuilder.Entity("PhoneListAtanga.Models.Note", b =>
                {
                    b.Property<string>("NoteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoteId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            NoteId = "A",
                            Name = "Aquintance"
                        },
                        new
                        {
                            NoteId = "B",
                            Name = "Business"
                        },
                        new
                        {
                            NoteId = "F",
                            Name = "Friend"
                        },
                        new
                        {
                            NoteId = "C",
                            Name = "Family"
                        });
                });

            modelBuilder.Entity("PhoneListAtanga.Models.Contact", b =>
                {
                    b.HasOne("PhoneListAtanga.Models.Note", "Note")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
