﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(KitapContext))]
    [Migration("20221223103743_remove-identity")]
    partial class removeidentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 1L, 1);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("Entities.Concrete.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"), 1L, 1);

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapResmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapTanimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayinEvi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitaps");
                });

            modelBuilder.Entity("Entities.Concrete.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"), 1L, 1);

                    b.Property<string>("YazarAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("YazarMail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("YazarResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("YazarTanım")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazars");
                });

            modelBuilder.Entity("Entities.Concrete.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"), 1L, 1);

                    b.Property<int>("KitapID")
                        .HasColumnType("int");

                    b.Property<string>("YorumAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumID");

                    b.HasIndex("KitapID");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.Property<int>("KategorilerKategoriID")
                        .HasColumnType("int");

                    b.Property<int>("KitaplarKitapID")
                        .HasColumnType("int");

                    b.HasKey("KategorilerKategoriID", "KitaplarKitapID");

                    b.HasIndex("KitaplarKitapID");

                    b.ToTable("KategoriKitap");
                });

            modelBuilder.Entity("Entities.Concrete.Kitap", b =>
                {
                    b.HasOne("Entities.Concrete.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("Entities.Concrete.Yorum", b =>
                {
                    b.HasOne("Entities.Concrete.Kitap", "Kitap")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");
                });

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.HasOne("Entities.Concrete.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerKategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarKitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Kitap", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("Entities.Concrete.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
