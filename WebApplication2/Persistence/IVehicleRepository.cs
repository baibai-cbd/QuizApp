using System.Threading.Tasks;
using QuizApp.Models;

namespace QuizApp.Persistence
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<Vehicle> GetVehicle(int id);

        Task<Vehicle> GetVehicleLite(int id);
    }
}