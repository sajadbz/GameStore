﻿// <auto-generated />
using System;
using GameStore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStore.Data.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    [Migration("20211010160029_SeedGameGroup")]
    partial class SeedGameGroup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStore.Domain.Entities.Games.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Platform")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.GameGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified),
                            Title = "Action"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified),
                            Title = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 10, 10, 19, 28, 0, 0, DateTimeKind.Unspecified),
                            Title = "Racing"
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.GameRequirement", b =>
                {
                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<string>("CPU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FreeSpace")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GPU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GameId");

                    b.ToTable("GameRequirements");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.Game", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Games.GameGroup", "Group")
                        .WithMany("Games")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.GameRequirement", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Games.Game", "Game")
                        .WithOne("GameRequirement")
                        .HasForeignKey("GameStore.Domain.Entities.Games.GameRequirement", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.Game", b =>
                {
                    b.Navigation("GameRequirement");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Games.GameGroup", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
