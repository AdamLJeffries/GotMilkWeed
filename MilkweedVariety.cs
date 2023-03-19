using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GotMilkWeed
{
    public class MilkweedVariety
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public bool IsToxicToMonarchs { get; set; }
    }
}


