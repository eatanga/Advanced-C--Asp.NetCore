﻿// <auto-generated />
using System;
using AssignmentsAtanga.Areas.TicketSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentsAtanga.Migrations.Ticket
{
    [DbContext(typeof(TicketContext))]
    [Migration("20200729114707_TicketSystem")]
    partial class TicketSystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentsAtanga.Areas.TicketSystem.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "open",
                            Name = "To Do"
                        },
                        new
                        {
                            StatusId = "ip",
                            Name = "In Progress"
                        },
                        new
                        {
                            StatusId = "qa",
                            Name = "Quality Assurance"
                        },
                        new
                        {
                            StatusId = "closed",
                            Name = "Done"
                        });
                });

            modelBuilder.Entity("AssignmentsAtanga.Areas.TicketSystem.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PointValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SprintNumber")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("AssignmentsAtanga.Areas.TicketSystem.Models.Ticket", b =>
                {
                    b.HasOne("AssignmentsAtanga.Areas.TicketSystem.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
