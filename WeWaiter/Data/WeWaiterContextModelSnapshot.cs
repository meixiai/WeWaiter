﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WeWaiter.Data;

namespace WeWaiter.Data
{
    [DbContext(typeof(WeWaiterContext))]
    partial class WeWaiterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WeWaiter.Data.BuyItem", b =>
                {
                    b.Property<string>("BuyItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("GoodsID");

                    b.Property<string>("GoodsName");

                    b.Property<string>("Icon");

                    b.Property<string>("Image");

                    b.Property<string>("OrderID");

                    b.Property<decimal>("Total");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("BuyItemID");

                    b.ToTable("BuyItem");
                });

            modelBuilder.Entity("WeWaiter.Data.Catalog", b =>
                {
                    b.Property<string>("CatalogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatalogName");

                    b.Property<bool>("Deleted");

                    b.Property<int>("OrderBy");

                    b.Property<string>("SellerID");

                    b.HasKey("CatalogID");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("WeWaiter.Data.Goods", b =>
                {
                    b.Property<string>("GoodsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarCode");

                    b.Property<string>("CatalogID");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Icon");

                    b.Property<string>("Image");

                    b.Property<decimal>("MinSellingPrice");

                    b.Property<string>("Name");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Rating");

                    b.Property<string>("Seller");

                    b.Property<decimal>("SellingPrice");

                    b.Property<int>("Stock");

                    b.Property<bool>("Visible");

                    b.HasKey("GoodsID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WeWaiter.Data.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("ActPay");

                    b.Property<DateTime>("Create");

                    b.Property<string>("OpenID");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("OrderStatus");

                    b.Property<DateTime>("PayDateTime");

                    b.Property<string>("PayType");

                    b.Property<decimal>("Payable");

                    b.Property<string>("PrepayId");

                    b.Property<string>("SeatID");

                    b.Property<int>("SeatNumber");

                    b.Property<string>("SellerID");

                    b.Property<decimal>("TotalPrice");

                    b.Property<string>("TransactionId");

                    b.Property<string>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WeWaiter.Data.Printer", b =>
                {
                    b.Property<string>("PrinterID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApiURL");

                    b.Property<string>("Desc");

                    b.Property<string>("Name");

                    b.Property<string>("PrinterType");

                    b.HasKey("PrinterID");

                    b.ToTable("Printer");
                });

            modelBuilder.Entity("WeWaiter.Data.Seat", b =>
                {
                    b.Property<string>("SeatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SeatNumber");

                    b.Property<int>("Seats");

                    b.Property<string>("Seller");

                    b.Property<bool>("Sit");

                    b.HasKey("SeatId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("WeWaiter.Data.Seller", b =>
                {
                    b.Property<string>("SellerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Bulletin");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int>("FoodScore");

                    b.Property<float>("MinPrice");

                    b.Property<string>("Name");

                    b.Property<string[]>("Pics");

                    b.Property<string>("PrintID");

                    b.Property<int>("RankRate");

                    b.Property<int>("RatingCount");

                    b.Property<int>("Score");

                    b.Property<int>("SellCount");

                    b.Property<int>("ServiceScore");

                    b.Property<int>("TableNumber");

                    b.HasKey("SellerID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("WeWaiter.Data.SellerInfo", b =>
                {
                    b.Property<string>("SellerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("LogoURL");

                    b.Property<string>("MapURL");

                    b.Property<string>("OwnerIDNumber");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhone");

                    b.Property<string>("OwnerWeixinID");

                    b.HasKey("SellerID");

                    b.ToTable("SellerInfo");
                });

            modelBuilder.Entity("WeWaiter.Data.User", b =>
                {
                    b.Property<string>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("JoinIn");

                    b.Property<string>("Language");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("NickName");

                    b.Property<string>("OpenID");

                    b.Property<string>("Phone");

                    b.Property<string>("Province");

                    b.Property<string>("Remark");

                    b.Property<int>("Sex");

                    b.Property<int>("Subscribe");

                    b.Property<string>("SubscribeScene");

                    b.Property<long>("SubscribeTime");

                    b.Property<string>("UnionId");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}