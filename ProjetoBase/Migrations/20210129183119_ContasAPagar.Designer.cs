﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjetoBase.Infra;

namespace ProjetoBase.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210129183119_ContasAPagar")]
    partial class ContasAPagar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseSerialColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ProjetoBase.Domain.Entidades.ContaAPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseSerialColumn();

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datapagamento");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datavencimento");

                    b.Property<int>("DiasDeAtraso")
                        .HasColumnType("integer")
                        .HasColumnName("diasdeatraso");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("ValorCorrigido")
                        .HasColumnType("numeric")
                        .HasColumnName("valorcorrigido");

                    b.Property<decimal>("ValorOriginal")
                        .HasColumnType("numeric")
                        .HasColumnName("valororiginal");

                    b.HasKey("Id")
                        .HasName("pk_contaapagar");

                    b.ToTable("contaapagar");
                });
#pragma warning restore 612, 618
        }
    }
}