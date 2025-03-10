﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sushiAPI.Data;

#nullable disable

namespace sushiAPI.Migrations
{
    [DbContext(typeof(sushiDBContext))]
    [Migration("20250308230009_Payment")]
    partial class Payment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("sushiAPI.Entities.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("sushiAPI.Entities.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("sushiAPI.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("sushiAPI.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductDescription = "3 lax, 1 räka, 1 avokado, 3 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHC97aSO8QolfP_75c905eSbFjSYFkuHRmzA&s",
                            ProductName = "Liten sushi 8 bitar",
                            ProductPrice = 110m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6M9H7I418gOLiVZ48aXGo5GNIhNjf1XMi4w&s",
                            ProductName = "Mellan sushi 11 bitar",
                            ProductPrice = 145m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductDescription = "5 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_rPIccq0sVCTu6Vypgs5qg9mkNLiaVqRn5g&s",
                            ProductName = "Stor sushi 14 bitar",
                            ProductPrice = 165m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductDescription = "Halstrad lax med chilimajonnäs, ålsås, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwXWRc-bVTqjz_uRMjBh7pJP3amHNOBBE5zA&s",
                            ProductName = "Lätt grillad 8 bitar",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductDescription = "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 ål, 1 bläckfisk, chillimajonäs, ålsås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSk2AIUIoGdq8t0h5THZYxnP4XqGMpsbILMhw&s",
                            ProductName = "Yume special sushi 11 bitar",
                            ProductPrice = 165m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductDescription = "9 bitar laxnigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwY_15mOvAKlD2J6J9JpDweEpBhnS2BH5CWQ&s",
                            ProductName = "Lax sushi 9 bitar",
                            ProductPrice = 150m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductDescription = "5 lax, 4 avokado, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ48iaAy81c6BCNL1QOMYUaAzh5O6i5yVlkVw&s",
                            ProductName = "Lax avokado sushi 9 bitar",
                            ProductPrice = 145m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductDescription = "5 lax, 4 räkor, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXPraCfYN857lbWbxZ9-n8TrELfOS4XpCTfw&s",
                            ProductName = "Lax räkor sushi 9 bitar",
                            ProductPrice = 145m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductDescription = "9 bitar räknigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSaBo81jS3KYx4bSDzJKopZDApnvPVNEuAuCA&s",
                            ProductName = "Räk sushi 9 bitar",
                            ProductPrice = 145m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductDescription = "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI87TnpM3n3bSd-3N-fwG1SBG_7NXny0qjJA&s",
                            ProductName = "Vegetarisk sushi 9 bitar",
                            ProductPrice = 120m
                        },
                        new
                        {
                            ProductId = 11,
                            ProductDescription = "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEnuqODIUMocXlMm054D1G0-hfJ-J_-TcXIw&s",
                            ProductName = "Vegetarisk sushi 12 bitar",
                            ProductPrice = 140m
                        },
                        new
                        {
                            ProductId = 12,
                            ProductDescription = "2 avokado, 1 räka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS016V_D80oDQ1kgaudn-6JUcr6zucxWG08fw&s",
                            ProductName = "Mamma sushi 9 bitar",
                            ProductPrice = 120m
                        },
                        new
                        {
                            ProductId = 13,
                            ProductDescription = "4 avokado, 1 räka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS7h189nxA56bT7-gZEVpm0bzSr6s2YTxW_5g&s",
                            ProductName = "Mamma sushi 12 bitar",
                            ProductPrice = 140m
                        },
                        new
                        {
                            ProductId = 14,
                            ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö och rostad lök",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSO5OIdUxpnygTC86_eWbfM8ifJqNAylwSBRQ&s",
                            ProductName = "Sashimi mellan",
                            ProductPrice = 205m
                        },
                        new
                        {
                            ProductId = 15,
                            ProductDescription = "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTbYpfW_Sfcs4e-W3eXIkv83jbd0h2jOMv2Q&s",
                            ProductName = "Sushi 6 bitar och sashimi",
                            ProductPrice = 250m
                        },
                        new
                        {
                            ProductId = 16,
                            ProductDescription = "Lax, tonfisk, avokado, gurka, crabstick surimi, ål sås, chilimajonnäs, sesamfrö och rostad lök.",
                            ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr7l1LmWInyy3_hdsohHWI-xsjV6CauBtvHw&s",
                            ProductName = "Yume special roll 10 bitar",
                            ProductPrice = 165m
                        });
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.HasOne("Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sushiAPI.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("sushiAPI.Entities.CartItem", b =>
                {
                    b.HasOne("sushiAPI.Entities.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sushiAPI.Entities.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("sushiAPI.Entities.Payment", b =>
                {
                    b.HasOne("Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("sushiAPI.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("sushiAPI.Entities.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("sushiAPI.Entities.Product", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
