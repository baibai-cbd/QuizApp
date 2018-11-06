using System.Threading.Tasks;
using QuizApp.Core.Models;

namespace QuizApp.Core
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<Vehicle> GetVehicle(int id);
        Task<Vehicle> GetVehicleLite(int id);
        Task<Model> GetModel(int modelId);
    }
}