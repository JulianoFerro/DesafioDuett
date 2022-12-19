using DesafioDuett.Data;
using DesafioDuett.Models;
using DesafioDuett.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioDuett.Repositorys
{
    public class FruitRepository : IFruitRepository
    {
        private readonly DesafioDuettDbContext _dBContext;

        public FruitRepository(DesafioDuettDbContext dBContext)
        {
            _dBContext = dBContext;
        }


        public async Task<List<Fruit>> GetAllAsync()
        {
            return await _dBContext.Fruits.ToListAsync();
        }

        public async Task<Fruit> GetByIdAsync(int id)
        {
            return await _dBContext.Fruits.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
