using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcSocks.Data;


namespace MvcSocks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSocksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSocksContext>>()))
            {
                // Look for any socks.
                if (context.Socks.Any())
                {
                    return;   // DB has been seeded
                }

                context.Socks.AddRange(
                    new socks
                    {
                        Company = "Nike",
                        LaunchDate = DateTime.Parse("1989-2-12"),
                        Type = "Sports",
                        Color = "Black",
                        Size = "Medium",
                        Price = 10,
                        Rating = 2
                    },

                    new socks
                    {
                        Company = "Celvin Clain",
                        LaunchDate = DateTime.Parse("1999-12-1"),
                        Type = "Trainning",
                        Color = "Gray",
                        Size = "Large",
                        Price = 15,
                        Rating = 4
                    },

                    new socks
                    {
                        Company = "New Balance",
                        LaunchDate = DateTime.Parse("2001-6-20"),
                        Type = "Loafer",        
                        Color = "Blue",
                        Size = "Small",
                        Price = 20,
                        Rating = 3
                    },

                    new socks
                    {
                        Company = "Puma",
                        LaunchDate = DateTime.Parse("2003-7-23"),
                        Type = "Trainning",
                        Color = "Purple",
                        Size = "Extra Large",
                        Price = 10,
                        Rating = 1
                    },

                    new socks
                    {
                        Company = "Sketchers",
                        LaunchDate = DateTime.Parse("2011-11-30"),
                        Type = "Sports",
                        Color = "Red",
                        Size = "Medium",
                        Price = 30,
                        Rating = 5
                    },

                    new socks
                    {
                        Company = "Under Armour",
                        LaunchDate = DateTime.Parse("2021-12-12"),
                        Type = "Running",
                        Color = "Yellow",
                        Size = "Extra Small",
                        Price = 13,
                        Rating = 2
                    },

                    new socks
                    {
                        Company = "Guess",
                        LaunchDate = DateTime.Parse("2017-6-17"),
                        Type = "Casual",
                        Color = "Gray",
                        Size = "Medium",
                        Price = 25,
                        Rating = 2
                    },

                    new socks
                    {
                        Company = "Tommy",
                        LaunchDate = DateTime.Parse("1979-3-27"),
                        Type = "Loafer",
                        Color = "Dark Green",
                        Size = "Small",
                        Price = 20,
                        Rating = 5
                    },

                    new socks
                    {
                        Company = "Armany",
                        LaunchDate = DateTime.Parse("2003-9-27"),
                        Type = "Sport",
                        Color = "Orenge",
                        Size = "Large",
                        Price = 25,
                        Rating = 3
                    },

                    new socks
                    {
                        Company = "Gap",
                        LaunchDate = DateTime.Parse("1990-10-16"),
                        Type = "Casual",
                        Color = "Grey",
                        Size = "Extra Large",
                        Price = 15,
                        Rating = 4
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
