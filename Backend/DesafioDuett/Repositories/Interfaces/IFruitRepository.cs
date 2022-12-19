using DesafioDuett.Models;

namespace DesafioDuett.Repositorys.Interfaces
{
    public interface IFruitRepository
    {
        Task<List<Fruit>> GetAllAsync();
        Task<Fruit> GetByIdAsync(int id);
    }
}
