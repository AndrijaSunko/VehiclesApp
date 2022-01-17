using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehiclesApp.Data;
using VehiclesApp.Models;
using System;
using System.Linq;

namespace VehiclesApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehiclesAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VehiclesAppContext>>()))
            {
                // Look for any movies.
                if (context.VehicleMake.Any())
                {
                    return;   // DB has been seeded
                }

                context.VehicleMake.AddRange(

                    new VehicleMake
                    {                        
                        Name = "BMW",
                        Abrv = "BMW"
                    },

                    new VehicleMake
                    {
                        Name = "Volkswagen",
                        Abrv = "VW"
                    },

                    new VehicleMake
                    {
                        Name = "Ford",
                        Abrv = "Ford"
                    },
                    new VehicleMake
                    {
                        Name = "Citroen",
                        Abrv = "Cit"
                    },
                    new VehicleMake
                    {
                        Name = "Rolls Royce",
                        Abrv = "RR"
                    }




                );
                context.SaveChanges();

                context.VehicleModel.AddRange(

                    new VehicleModel
                    {
                        MakeId = 100,
                        Name = "BMW",
                        Abrv = "x5",
                    },
                    new VehicleModel
                    {
                        MakeId = 200,
                        Name = "Volkswagen",
                        Abrv = "Golf",
                    },
                    new VehicleModel
                    {
                        MakeId = 300,
                        Name = "Ford",
                        Abrv = "Focus",
                    },
                    new VehicleModel
                    {
                        MakeId = 400,
                        Name = "Citroen",
                        Abrv = "C5",
                    },
                    new VehicleModel
                    {
                        MakeId = 500,
                        Name = "Rolls Royce",
                        Abrv = "PE",
                    }


                    );
                context.SaveChanges();
            }
        }
    }
}