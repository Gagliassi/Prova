﻿// <auto-generated />
using System;
using API_Folhas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_FOlhas.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.FolhaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Impostofgts")
                        .HasColumnType("REAL");

                    b.Property<double>("Impostoinss")
                        .HasColumnType("REAL");

                    b.Property<double>("Impostorenda")
                        .HasColumnType("REAL");

                    b.Property<int>("MesAno")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantidadehoras")
                        .HasColumnType("REAL");

                    b.Property<double>("Salariobruto")
                        .HasColumnType("REAL");

                    b.Property<double>("Salarioliquido")
                        .HasColumnType("REAL");

                    b.Property<double>("Valorhora")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("API_Folhas.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salario")
                        .HasColumnType("INTEGER");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("API.Models.FolhaPagamento", b =>
                {
                    b.HasOne("API_Folhas.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}