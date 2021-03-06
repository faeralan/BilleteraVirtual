﻿// <auto-generated />
using System;
using BilleteraVirtualMVC.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BilleteraVirtualMVC.Migrations
{
    [DbContext(typeof(BilleteraContext))]
    partial class BilleteraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BilleteraVirtualMVC.Models.Cuenta", b =>
                {
                    b.Property<int>("CuentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("CuentaId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("BilleteraVirtualMVC.Models.Movimiento", b =>
                {
                    b.Property<int>("MovimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CuentaId1")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Importe")
                        .HasColumnType("int");

                    b.Property<int>("TipoMovimiento")
                        .HasColumnType("int");

                    b.HasKey("MovimientoId");

                    b.HasIndex("CuentaId1");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("BilleteraVirtualMVC.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CuentaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("CuentaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BilleteraVirtualMVC.Models.Movimiento", b =>
                {
                    b.HasOne("BilleteraVirtualMVC.Models.Cuenta", "CuentaId")
                        .WithMany("Movimiento")
                        .HasForeignKey("CuentaId1");
                });

            modelBuilder.Entity("BilleteraVirtualMVC.Models.Usuario", b =>
                {
                    b.HasOne("BilleteraVirtualMVC.Models.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaId");
                });
#pragma warning restore 612, 618
        }
    }
}
