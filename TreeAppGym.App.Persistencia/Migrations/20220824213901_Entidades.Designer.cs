﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TreeAppGym.App.Persistencia;

namespace TreeAppGym.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220824213901_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TreeAppGym.App.Dominio.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TreeAppGym.App.Dominio.Gym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int?>("PlanNutricionalId")
                        .HasColumnType("int");

                    b.Property<int?>("RutinaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("PlanNutricionalId");

                    b.HasIndex("RutinaId");

                    b.ToTable("Gym");
                });

            modelBuilder.Entity("TreeAppGym.App.Dominio.PlanNutricional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanNutricional");
                });

            modelBuilder.Entity("TreeAppGym.App.Dominio.Rutina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rutina");
                });

            modelBuilder.Entity("TreeAppGym.App.Dominio.Gym", b =>
                {
                    b.HasOne("TreeAppGym.App.Dominio.Clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClientesId");

                    b.HasOne("TreeAppGym.App.Dominio.PlanNutricional", "PlanNutricional")
                        .WithMany()
                        .HasForeignKey("PlanNutricionalId");

                    b.HasOne("TreeAppGym.App.Dominio.Rutina", "Rutina")
                        .WithMany()
                        .HasForeignKey("RutinaId");

                    b.Navigation("Clientes");

                    b.Navigation("PlanNutricional");

                    b.Navigation("Rutina");
                });
#pragma warning restore 612, 618
        }
    }
}
