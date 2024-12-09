using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderSystemAPI.Models;

namespace OrderSystemAPI.Data
{
    public class OrderSystemAPIDB : DbContext
    {
        public OrderSystemAPIDB (DbContextOptions<OrderSystemAPIDB> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            base.OnModelCreating(modelBuilder);
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = 1,
                         ProductName = "Shirt",
                         color = "Red",
                         ProductStock = 5,
                     },

                      new Product
                      {
                          Id = 2,
                          ProductName = "Shirt",
                          color = "Blue",
                          ProductStock = 2,
                      },

                      new Product
                      {
                          Id = 3,
                          ProductName = "Shirt",
                          color = "Black",
                          ProductStock = 5,
                      },

                      new Product
                      {
                          Id = 4,
                          ProductName = "Pants",
                          color = "Black",
                          ProductStock = 2,
                      },

                      new Product
                      {
                          Id = 5,
                          ProductName = "Pants",
                          color = "Brown",
                          ProductStock = 4,
                      }


                );

                modelBuilder.Entity<PhoneNumber>().HasData(
                    new PhoneNumber
                    {
                        ID = 1,
                        Number = "3602063171",
                        Type = "Cell"
                    },
                    new PhoneNumber
                    {
                        ID = 2,
                        Number = "3605455576",
                        Type = "Cell"
                    },
                    new PhoneNumber
                    {
                        ID = 3,
                        Number = "3607854298",
                        Type = "Home"
                    },
                    new PhoneNumber
                    {
                        ID = 4,
                        Number = "3214467819",
                        Type = "Cell"
                    }
                );


                modelBuilder.Entity<Customer>(p =>
                {
                    p.HasData(
                        new Customer
                        {

                            ID = 1,
                            FirstName = "Alys",
                            LastName = "Terwilliger",
                            Birthdate = new DateTime(),
                        },
                        new Customer
                        {

                            ID = 2,
                            FirstName = "Jayme",
                            LastName = "Terwilliger",
                            Birthdate = new DateTime(),
                        },
                        new Customer
                        {

                            ID = 3,
                            FirstName = "Joe",
                            LastName = "Smith",
                            Birthdate = new DateTime(),
                        },
                        new Customer
                        {

                            ID = 4,
                            FirstName = "Angel",
                            LastName = "Smexy",
                            Birthdate = new DateTime(),
                        }
                    );

                });

                modelBuilder.Entity<PeoplePhone>().HasData(

                    new PeoplePhone
                    {
                        ID = 1,
                        PeopleID = 1,
                        PhoneNumberID = 1,
                    },
                    new PeoplePhone
                    {
                        ID = 2,
                        PeopleID = 2,
                        PhoneNumberID = 2,
                    },
                    new PeoplePhone
                    {
                        ID = 3,
                        PeopleID = 3,
                        PhoneNumberID = 3,
                    },
                    new PeoplePhone
                    {
                        ID = 4,
                        PeopleID = 4,
                        PhoneNumberID = 4,
                    }


                );

                modelBuilder.Entity<Address>().HasData(
                    new Address
                    {
                        ID = 1,
                        AddressType = "Home",
                        StreetAddress = "408 sw Kerron st",
                        City = "Winlock",
                        State = "WA",
                        ZipCode = "98596",

                    },
                    new Address
                    {
                        ID = 2,
                        AddressType = "Bussiness",
                        StreetAddress = "485 Main st",
                        City = "Centralia",
                        State = "WA",
                        ZipCode = "98596",

                    },
                    new Address
                    {
                        ID = 3,
                        AddressType = "Home",
                        StreetAddress = "626 Alamoa drive",
                        City = "Gem",
                        State = "PA",
                        ZipCode = "43254",

                    },
                     new Address
                     {
                         ID = 4,
                         AddressType = "Home",
                         StreetAddress = "6969 This was hard ave",
                         City = "Jesus",
                         State = "Christ",
                         ZipCode = "78449",

                     }

                );

                modelBuilder.Entity<CustomerAddress>().HasData(
                    new CustomerAddress
                    {
                        ID = 1,
                        CustomerID = 1,
                        AddressID = 1,
                        

                    },
                    new CustomerAddress
                    {
                        ID = 2,
                        CustomerID = 2,
                        AddressID = 2,


                    },
                    new CustomerAddress
                    {
                        ID = 3,
                        CustomerID = 3,
                        AddressID = 3,


                    },
                     new CustomerAddress
                     {
                         ID = 4,
                         CustomerID = 4,
                         AddressID = 4,


                     }



                );

                modelBuilder.Entity<Order>().HasData(
                    new Order
                    {
                        ID = 1,
                        CustomerID = 3,
                        AddressID = 2,
                        ProductID = 1,

                    },
                    new Order
                    {
                        ID = 2,
                        CustomerID = 1,
                        AddressID = 1,
                        ProductID = 2,

                    },
                     new Order
                     {
                         ID = 3,
                         CustomerID = 2,
                         AddressID = 4,
                         ProductID = 1,

                     },
                     new Order
                     {
                         ID = 4,
                         CustomerID = 4,
                         AddressID = 3,
                         ProductID = 4,



                     }
                    );

            } else
            {
               
            }
            
        



            modelBuilder.Entity<Customer>().Navigation(e => e.CustomerAddress).AutoInclude();
            modelBuilder.Entity<CustomerAddress>().Navigation(e => e.Address).AutoInclude();
            modelBuilder.Entity<Customer>().Navigation(e => e.PhonePhones).AutoInclude();
            modelBuilder.Entity<PeoplePhone>().Navigation(e => e.PhoneNumber).AutoInclude();
        }

        public DbSet<OrderSystemAPI.Models.Product> Product { get; set; }
        public DbSet<OrderSystemAPI.Models.Customer> Customer { get; set; }
        public DbSet<OrderSystemAPI.Models.PhoneNumber> PhoneNumbers { get; set; } 

        public DbSet<OrderSystemAPI.Models.Order> Orders { get; set; } 

        public DbSet<OrderSystemAPI.Models.Address> Address { get; set; }
        public DbSet<OrderSystemAPI.Models.CustomerAddress> CustomerAddress { get; set; }
    }
}
