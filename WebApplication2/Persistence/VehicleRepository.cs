using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApp.Models;

namespace QuizApp.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly QuizAppDbContext context;

        public VehicleRepository(QuizAppDbContext context)
        {
            this.context = context;
        }

        public void Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            context.Remove(vehicle);
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            return await context.Vehicles
                .Include(v => v.Model)
                    .ThenInclude(m => m.Make)
                .Include(v => v.Features)
                    .ThenInclude(vf => vf.Feature)
                .SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<Vehicle> GetVehicleLite(int id)
        {
            return await context.Vehicles.FindAsync(id);
        }
    }
}
