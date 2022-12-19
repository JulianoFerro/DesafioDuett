using DesafioDuett.Models;
using DesafioDuett.Repositorys.Interfaces;
using DesafioDuett.Services.Interfaces;

namespace DesafioDuett.Services
{
    public class FruitService : IFruitService
    {
        private readonly IFruitRepository _IFruitRepository;

        public FruitService(IFruitRepository IFruitRepository)
        {
            _IFruitRepository = IFruitRepository;
        }

        public async Task<int> DivideAsync(int id)
        {
            var fruit = await GetByIdAsync(id);
            return fruit.ValueA / fruit.ValueB;
        }

        public async Task<List<Fruit>> GetAllAsync()
        {
            return await _IFruitRepository.GetAllAsync();
        }

        public async Task<Fruit> GetByIdAsync(int id)
        {
            return await _IFruitRepository.GetByIdAsync(id);
        }

        public async Task<int> Multiply(int id)
        {
            var fruit = await GetByIdAsync(id);
            return fruit.ValueA * fruit.ValueB;
        }
    }
}
