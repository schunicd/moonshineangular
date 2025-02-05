﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheMoonshineCafe.Models;

namespace TheMoonshineCafe.Data
{
    public class MoonshineCafeContext : DbContext
    {
        public MoonshineCafeContext(DbContextOptions<MoonshineCafeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var admin = new Admin{
                id = 1,
                name = "Derek",
                email = "schunicd@gmail.com",
                phoneNumber = "1234567890",
                accessLevel = 1
            };

            modelBuilder.Entity<Admin>().HasData(admin);
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Band>().ToTable("Band");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Payment>().ToTable("Payment");       
            modelBuilder.Entity<Refund>().ToTable("Refund");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");

        }

        public virtual DbSet<Admin> Admins { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Payment> Payments { get; set; }
        //public DbSet<Person> Persons { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Band>().ToTable("Band");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Payment>().ToTable("Payment");       
            modelBuilder.Entity<Refund>().ToTable("Refund");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
        }
        */
    }
}
