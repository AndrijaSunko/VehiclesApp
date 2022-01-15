#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehiclesApp.Models;

namespace VehiclesApp.Data
{
    public class VehiclesAppContext : DbContext
    {
        public VehiclesAppContext (DbContextOptions<VehiclesAppContext> options)
            : base(options)
        {
        }

        public DbSet<VehiclesApp.Models.VehicleMake> VehicleMake { get; set; }
        public DbSet<VehiclesApp.Models.VehicleModel> VehicleModel { get; set; }
    }
}
