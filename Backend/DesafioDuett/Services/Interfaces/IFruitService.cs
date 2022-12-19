using DesafioDuett.Models;

namespace DesafioDuett.Services.Interfaces
{
    public interface IFruitService
    {
        Task<List<Fruit>> GetAllAsync();
        Task<Fruit> GetByIdAsync(int id);
        Task<int> DivideAsync(int id);
        Task<int> Multiply(int id);
    }
}
