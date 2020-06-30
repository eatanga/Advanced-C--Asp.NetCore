﻿// <auto-generated />
using AssignmentsAtanga.Areas.Assignments.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentsAtanga.Migrations.Student
{
    [DbContext(typeof(StudentContext))]
    [Migration("20200630180936_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentsAtanga.Areas.Assignments.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "John",
                            Grade = "A",
                            LastName = "Emeka"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Peter",
                            Grade = "B",
                            LastName = "Oniocha"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Frank",
                            Grade = "A",
                            LastName = "Eneigho"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Hamlet",
                            Grade = "C",
                            LastName = "Ngong"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Mark",
                            Grade = "A",
                            LastName = "Jacob"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Luke",
                            Grade = "B",
                            LastName = "Marshall"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "James",
                            Grade = "B",
                            LastName = "Tyshawn"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Richard",
                            Grade = "C",
                            LastName = "Roberts"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Philip",
                            Grade = "A",
                            LastName = "Grace"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
