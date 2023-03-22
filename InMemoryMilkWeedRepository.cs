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
            new MilkweedVariety { Id = 4, Name = "Showy Butterfly", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 5, Name = "Whorled Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 6, Name = "Green Milkweed", Region = "North America", IsToxicToMonarchs = false };
            new MilkweedVariety { Id = 7, Name = "Antelope Horns", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 8, Name = "Purple Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 9, Name = "Sand Milkweed", Region = "North American", IsToxicToMonarchs = false };
            new MilkweedVariety { Id = 10, Name = "Red Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 11, Name = "Poke Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 12, Name = "Texas Milkweed", Region = "North America", IsToxicToMonarchs = false };
            new MilkweedVariety { Id = 13, Name = "Sullivants Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 14, Name = "Horsetail Milkweed", Region = "North America", IsToxicToMonarchs = true };
            new MilkweedVariety { Id = 15, Name = "Clasping Milkweed", Region = "North America", IsToxicToMonarchs = true }; 
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
