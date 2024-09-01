﻿// <auto-generated />
using System;
using AtivosTC5.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtivosTC5.Infra.Data.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Ativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtivoTipo_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NOME");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("Id");

                    b.HasIndex("AtivoTipo_Id");

                    b.ToTable("ATIVO", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AtivoTipo_Id = 3,
                            Nome = "Real",
                            Sigla = "BRL"
                        },
                        new
                        {
                            Id = 2,
                            AtivoTipo_Id = 3,
                            Nome = "Dólar Americano",
                            Sigla = "USD"
                        },
                        new
                        {
                            Id = 3,
                            AtivoTipo_Id = 3,
                            Nome = "Dólar Canadense",
                            Sigla = "CAD"
                        },
                        new
                        {
                            Id = 4,
                            AtivoTipo_Id = 3,
                            Nome = "Libra Esterlina",
                            Sigla = "GBP"
                        },
                        new
                        {
                            Id = 5,
                            AtivoTipo_Id = 3,
                            Nome = "Euro",
                            Sigla = "EUR"
                        },
                        new
                        {
                            Id = 6,
                            AtivoTipo_Id = 3,
                            Nome = "Iene Japonês",
                            Sigla = "JPY"
                        },
                        new
                        {
                            Id = 7,
                            AtivoTipo_Id = 3,
                            Nome = "Franco Suíço",
                            Sigla = "CHF"
                        },
                        new
                        {
                            Id = 8,
                            AtivoTipo_Id = 2,
                            Nome = "Bitcoin",
                            Sigla = "BTC"
                        },
                        new
                        {
                            Id = 9,
                            AtivoTipo_Id = 2,
                            Nome = "Ethereum",
                            Sigla = "ETH"
                        },
                        new
                        {
                            Id = 10,
                            AtivoTipo_Id = 2,
                            Nome = "Litecoin",
                            Sigla = "LTC"
                        },
                        new
                        {
                            Id = 11,
                            AtivoTipo_Id = 2,
                            Nome = "Ripple",
                            Sigla = "XRP"
                        },
                        new
                        {
                            Id = 12,
                            AtivoTipo_Id = 2,
                            Nome = "Cardano",
                            Sigla = "ADA"
                        },
                        new
                        {
                            Id = 13,
                            AtivoTipo_Id = 2,
                            Nome = "Binance Coin",
                            Sigla = "BNB"
                        },
                        new
                        {
                            Id = 14,
                            AtivoTipo_Id = 2,
                            Nome = "DogeCoin",
                            Sigla = "DOGE"
                        },
                        new
                        {
                            Id = 15,
                            AtivoTipo_Id = 2,
                            Nome = "Shiba Inu",
                            Sigla = "SHIB"
                        },
                        new
                        {
                            Id = 16,
                            AtivoTipo_Id = 1,
                            Nome = "ALLIANÇA SAÚDE E PARTICIPAÇÕES S.A.",
                            Sigla = "AALR3"
                        },
                        new
                        {
                            Id = 17,
                            AtivoTipo_Id = 1,
                            Nome = "AMBEV S.A.",
                            Sigla = "ABEV3"
                        },
                        new
                        {
                            Id = 18,
                            AtivoTipo_Id = 1,
                            Nome = "CAMIL ALIMENTOS S.A.",
                            Sigla = "CAML3"
                        },
                        new
                        {
                            Id = 19,
                            AtivoTipo_Id = 1,
                            Nome = "ITAUSA S.A.",
                            Sigla = "ITSA3"
                        },
                        new
                        {
                            Id = 20,
                            AtivoTipo_Id = 1,
                            Nome = "PETROLEO BRASILEIRO S.A. PETROBRAS",
                            Sigla = "PETW3"
                        },
                        new
                        {
                            Id = 21,
                            AtivoTipo_Id = 1,
                            Nome = "PETROLEO BRASILEIRO S.A. PETROBRAS",
                            Sigla = "PETW4"
                        },
                        new
                        {
                            Id = 22,
                            AtivoTipo_Id = 4,
                            Nome = "NTN-B - 02/2030 - BRSTNCNTB4J9",
                            Sigla = "NTN-B"
                        },
                        new
                        {
                            Id = 23,
                            AtivoTipo_Id = 4,
                            Nome = "NBCE - 05/2003 - BRBCBRNBC592",
                            Sigla = "NBCE"
                        },
                        new
                        {
                            Id = 24,
                            AtivoTipo_Id = 4,
                            Nome = "LFT-B - 09/2004 - BRSTNCLF1KR7",
                            Sigla = "LFT-b"
                        });
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.AtivoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("ATIVOTIPO", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Ação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Cripto Moeda"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Dinheiro"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Titulo"
                        });
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NOME");

                    b.Property<int>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("PORTFOLIO", (string)null);
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Transacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ativo_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataTransacao")
                        .HasColumnType("datetime")
                        .HasColumnName("DATATRANSACAO");

                    b.Property<int>("Portifolio_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,3)")
                        .HasColumnName("PRECO");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(20,3)")
                        .HasColumnName("QUANTIDADE");

                    b.Property<string>("TipoTransacao")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("TIPOTRANSACAO");

                    b.HasKey("Id");

                    b.HasIndex("Ativo_Id");

                    b.HasIndex("Portifolio_Id");

                    b.ToTable("TRANSACAO", (string)null);
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasColumnName("NOME");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("USUARIO", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "UserTeste@Teste.com",
                            Nome = "UserTeste",
                            Senha = "e501a9799a067184b96633716287a92626ef9c4c"
                        });
                });

            modelBuilder.Entity("AtivosTC5.Domain.ValueObjects.PortfolioAtivo", b =>
                {
                    b.Property<int>("Portfolio_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ativo_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,3)")
                        .HasColumnName("PRECO");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(20,3)")
                        .HasColumnName("QUANTIDADE");

                    b.HasKey("Portfolio_Id", "Ativo_Id");

                    b.HasIndex("Ativo_Id");

                    b.ToTable("PORTFOLIOATIVO", (string)null);
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Ativo", b =>
                {
                    b.HasOne("AtivosTC5.Domain.Entities.AtivoTipo", "ativoTipo")
                        .WithMany("ativos")
                        .HasForeignKey("AtivoTipo_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ativoTipo");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Portfolio", b =>
                {
                    b.HasOne("AtivosTC5.Domain.Entities.Usuario", "usuario")
                        .WithMany("portfolios")
                        .HasForeignKey("Usuario_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Transacao", b =>
                {
                    b.HasOne("AtivosTC5.Domain.Entities.Ativo", "ativo")
                        .WithMany("transacoes")
                        .HasForeignKey("Ativo_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtivosTC5.Domain.Entities.Portfolio", "portfolio")
                        .WithMany("transacoes")
                        .HasForeignKey("Portifolio_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ativo");

                    b.Navigation("portfolio");
                });

            modelBuilder.Entity("AtivosTC5.Domain.ValueObjects.PortfolioAtivo", b =>
                {
                    b.HasOne("AtivosTC5.Domain.Entities.Ativo", "ativo")
                        .WithMany("portfolioAtivos")
                        .HasForeignKey("Ativo_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtivosTC5.Domain.Entities.Portfolio", "portfolio")
                        .WithMany("portfolioAtivos")
                        .HasForeignKey("Portfolio_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ativo");

                    b.Navigation("portfolio");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Ativo", b =>
                {
                    b.Navigation("portfolioAtivos");

                    b.Navigation("transacoes");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.AtivoTipo", b =>
                {
                    b.Navigation("ativos");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Portfolio", b =>
                {
                    b.Navigation("portfolioAtivos");

                    b.Navigation("transacoes");
                });

            modelBuilder.Entity("AtivosTC5.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("portfolios");
                });
#pragma warning restore 612, 618
        }
    }
}
