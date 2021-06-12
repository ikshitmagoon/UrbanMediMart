﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UrbanMediMart.Model
{
    public partial class UrbanMediMartContext : DbContext
    {
        public UrbanMediMartContext()
        {
        }

        public UrbanMediMartContext(DbContextOptions<UrbanMediMartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                optionsBuilder.UseSqlServer("Server=DESKTOP-UENS42J\\SQLEXPRESS;database=UrbanMediMart;trusted_connection=true");
=======
                optionsBuilder.UseSqlServer("Server=LAPTOP-BQ2NAUDM\\SQLEXPRESS01;Database=UrbanMediMart;Trusted_Connection=true;");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                optionsBuilder.UseSqlServer("Server=LAPTOP-5TQNB10G\\SQLEXPRESS;Database=UrbanMediMart;Trusted_Connection=True;");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Server=DESKTOP-LQFLIB6\\IKSHIT;Database=UrbanMediMart;Trusted_Connection=true;");
=======
                optionsBuilder.UseSqlServer("Server=DESKTOP-UENS42J\\SQLEXPRESS;database=UrbanMediMart;trusted_connection=true");
>>>>>>> yaman
=======
                optionsBuilder.UseSqlServer("Server=LAPTOP-5TQNB10G\\SQLEXPRESS;Database=UrbanMediMart;Trusted_Connection=True;");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasIndex(e => e.Email)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasName("UQ__Admin__AB6E6164FB9BB406")
                    .IsUnique();

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Admin__19491390EA1C6CD3")
=======
                    .HasName("UQ__Admin__AB6E6164F4EBA9DB")
                    .IsUnique();

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Admin__19491390174AEE63")
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasName("UQ__Admin__AB6E6164F4EBA9DB")
                    .IsUnique();

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Admin__19491390174AEE63")
=======
                    .HasName("UQ__Admin__AB6E61649F08D924")
                    .IsUnique();

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Admin__19491390C8A17CE4")
>>>>>>> yaman
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
=======
                    .HasName("UQ__Admin__AB6E6164E741286F")
                    .IsUnique();

                entity.HasIndex(e => e.FullName)
                    .HasName("UQ__Admin__194913902B16B8E3")
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(30);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasName("PK__Customer__A4AE64B8658DBD33");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D1053474718768")
=======
                    .HasName("PK__Customer__A4AE64B813CC1052");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D10534BBB184D6")
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasName("PK__Customer__A4AE64B813CC1052");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D10534BBB184D6")
=======
                    .HasName("PK__Customer__A4AE64B8EF6580D1");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D105343AE287BB")
>>>>>>> yaman
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
=======
                    .HasName("PK__Customer__A4AE64B822F6A905");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Customer__A9D10534475CFAAE")
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("Order_detail");

                entity.Property(e => e.OrderDetailId)
                    .HasColumnName("Order_detail_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasConstraintName("FK__Order_det__Order__4CA06362");
=======
                    .HasConstraintName("FK__Order_det__Order__5CD6CB2B");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasConstraintName("FK__Order_det__Order__48CFD27E");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasConstraintName("FK__Order_det__Order__6477ECF3");
=======
                    .HasConstraintName("FK__Order_det__Order__5CD6CB2B");
>>>>>>> itika
=======
                    .HasConstraintName("FK__Order_det__Order__48CFD27E");
>>>>>>> yaman
=======
                    .HasConstraintName("FK__Order_det__Order__48CFD27E");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasConstraintName("FK__Order_det__Produ__4D94879B");
=======
                    .HasConstraintName("FK__Order_det__Produ__5DCAEF64");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasConstraintName("FK__Order_det__Produ__49C3F6B7");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasConstraintName("FK__Order_det__Produ__656C112C");
=======
                    .HasConstraintName("FK__Order_det__Produ__5DCAEF64");
>>>>>>> itika
=======
                    .HasConstraintName("FK__Order_det__Produ__49C3F6B7");
>>>>>>> yaman
=======
                    .HasConstraintName("FK__Order_det__Produ__49C3F6B7");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasName("PK__Orders__46596229F249E21E");
=======
                    .HasName("PK__Orders__465962294DA16B87");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasName("PK__Orders__46596229FF047197");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasName("PK__Orders__465962294DA16B87");
=======
                    .HasName("PK__Orders__46596229F65BC608");
>>>>>>> yaman
=======
                    .HasName("PK__Orders__46596229FF047197");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus).HasMaxLength(20);

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReciptantName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ReciptantPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .IsRequired()
                    .HasColumnName("shippingAddress")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasConstraintName("FK__Orders__Customer__45F365D3");
=======
                    .HasConstraintName("FK__Orders__Customer__3D5E1FD2");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasConstraintName("FK__Orders__Customer__44FF419A");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasConstraintName("FK__Orders__Customer__3D5E1FD2");
=======
                    .HasConstraintName("FK__Orders__Customer__44FF419A");
>>>>>>> yaman
=======
                    .HasConstraintName("FK__Orders__Customer__44FF419A");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.MedicineId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasName("PK__Product__4F2128F0C432C82A");
=======
                    .HasName("PK__Product__4F2128F04A5010DD");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasName("PK__Product__4F2128F02F9F9FFE");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasName("PK__Product__4F2128F04A5010DD");
=======
                    .HasName("PK__Product__4F2128F0B2FE0103");
>>>>>>> yaman
=======
                    .HasName("PK__Product__4F2128F02F9F9FFE");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs

                entity.Property(e => e.MedicineId)
                    .HasColumnName("MedicineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ExpDate).HasColumnType("datetime");

                entity.Property(e => e.MedicineName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MfgDate).HasColumnType("datetime");

                entity.Property(e => e.Pimage).HasColumnName("PImage");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
<<<<<<< HEAD:Model/UrbanMediMartContext.cs
                    .HasConstraintName("FK__Product__Categor__4316F928");
=======
                    .HasConstraintName("FK__Product__Categor__412EB0B6");
>>>>>>> itika:Models/UrbanMediMartContext.cs
=======
                    .HasConstraintName("FK__Product__Categor__4222D4EF");
>>>>>>> origin/mohitB:Models/UrbanMediMartContext.cs
=======
<<<<<<< HEAD
<<<<<<< HEAD
                    .HasConstraintName("FK__Product__Categor__412EB0B6");
=======
                    .HasConstraintName("FK__Product__Categor__4222D4EF");
>>>>>>> yaman
=======
                    .HasConstraintName("FK__Product__Categor__4222D4EF");
>>>>>>> mohitB
>>>>>>> origin/Ikshit:Models/UrbanMediMartContext.cs
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
