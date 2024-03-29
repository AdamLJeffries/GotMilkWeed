﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using GotMilkWeed;

public interface IMilkweedRepository
    {
        Task<List<MilkweedVariety>> GetAllAsync();
        Task<MilkweedVariety> GetByIdAsync(int id);
        Task CreateAsync(MilkweedVariety variety);
        Task UpdateAsync(MilkweedVariety variety);
        Task DeleteAsync(int id);
    }

