﻿// <auto-generated />
using FniteApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FniteApp.Migrations
{
    [DbContext(typeof(FniteAppContext))]
    [Migration("20200411064035_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FniteApp.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BRStatus")
                        .HasColumnType("bit");

                    b.Property<string>("BulletType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DPS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DamageB")
                        .HasColumnType("int");

                    b.Property<int>("DamageH")
                        .HasColumnType("int");

                    b.Property<decimal>("FireRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MagazineSize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RarityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReloadTime")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StructureDamage")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VaultedStatus")
                        .HasColumnType("bit");

                    b.Property<string>("WeaponType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Weapon");
                });
#pragma warning restore 612, 618
        }
    }
}
