using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GotMilkWeed
{
    public class InMemoryMilkweedRepository : IMilkweedRepository
    {
        readonly List<MilkweedVariety> _varieties;

        public InMemoryMilkweedRepository()
        {
            _varieties = new List<MilkweedVariety>();

            new MilkweedVariety { Id = 1, Name = "Common Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 2, Name = "Butterfly Weed", Region = "North America", IsToxicToMonarchs = false };
            new MilkweedVariety { Id = 3, Name = "Swamp Milkweed", Region = "North America", IsToxicToMonarchs = false };
            ///Add more Ids
        }

        public async Task<List<MilkweedVariety>> GetAllAsync()
        {
            return await Task.FromResult(_varieties);
        }

        public async Task<MilkweedVariety> GetByIdAsync(int id)
        {
            return await Task.FromResult(_varieties.FirstOrDefault(v => v.Id == id));
        }

        public async Task CreateAsync(MilkweedVariety variety)
        {
            variety.Id = _varieties.Count + 1;
            _varieties.Add(variety);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(MilkweedVariety variety)
        {
            var index = _varieties.FindIndex(v => v.Id == variety.Id);
            if (index >= 0)
            {
                _varieties[index] = variety;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var index = _varieties.FindIndex(v => v.Id == id);
            if (index >= 0)
            {
                _varieties.RemoveAt(index);
            }
            await Task.CompletedTask;
        }
    }
}
