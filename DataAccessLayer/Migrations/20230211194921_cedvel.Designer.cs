﻿// <auto-generated />
using System;
using DataAccessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230211194921_cedvel")]
    partial class cedvel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrate.Haqqımızda", b =>
                {
                    b.Property<int>("HaqqımızdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Məlumat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şəkil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HaqqımızdaID");

                    b.ToTable("Haqqımızdas");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Məlumat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Tarix")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajs");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Müəllimlər", b =>
                {
                    b.Property<int>("MüəllimlərID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Məlumat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şəkil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MüəllimlərID");

                    b.ToTable("Müəllimlərs");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Tələbələr", b =>
                {
                    b.Property<int>("TələbələrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Məlumat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nəticəsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şəkil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TələbələrID");

                    b.ToTable("Tələbələrs");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Xəbərlər", b =>
                {
                    b.Property<int>("XəbərlərID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Başlıq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Məlumat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("XəbərlərID");

                    b.ToTable("Xəbərlərs");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Əlaqə", b =>
                {
                    b.Property<int>("ƏlaqəID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecabook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("ƏlaqəID");

                    b.ToTable("Əlaqəs");
                });
#pragma warning restore 612, 618
        }
    }
}
