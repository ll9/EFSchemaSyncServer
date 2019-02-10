﻿// <auto-generated />
using EFSchemaSyncServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFSchemaSyncServer.Migrations
{
    [DbContext(typeof(EFSchemaSyncServerContext))]
    [Migration("20190210110837_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("EFSchemaSyncServer.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDColumn", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataType");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<string>("SDDataTableId");

                    b.Property<bool>("Synchronize");

                    b.HasKey("Id");

                    b.HasIndex("SDDataTableId");

                    b.ToTable("SDColumns");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SDColumn");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDDataTable", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("Synchronize");

                    b.HasKey("Id");

                    b.ToTable("SDDataTables");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDProject", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("SDProjects");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDComboboxColumn", b =>
                {
                    b.HasBaseType("EFSchemaSyncServer.Models.SDColumn");

                    b.Property<string>("ComboboxValues");

                    b.ToTable("SDComboboxColumn");

                    b.HasDiscriminator().HasValue("SDComboboxColumn");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDTextBoxColumn", b =>
                {
                    b.HasBaseType("EFSchemaSyncServer.Models.SDColumn");


                    b.ToTable("SDTextBoxColumn");

                    b.HasDiscriminator().HasValue("SDTextBoxColumn");
                });

            modelBuilder.Entity("EFSchemaSyncServer.Models.SDColumn", b =>
                {
                    b.HasOne("EFSchemaSyncServer.Models.SDDataTable")
                        .WithMany("Columns")
                        .HasForeignKey("SDDataTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
