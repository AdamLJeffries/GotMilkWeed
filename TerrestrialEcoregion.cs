using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GotMilkWeed
{
    class TerrestrialEcoregion
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class NorthAmericanTerrestrialEcoregions
    {
        public List<TerrestrialEcoregion> Ecoregions { get; set; }

        public NorthAmericanTerrestrialEcoregions()
        {
            Ecoregions = new List<TerrestrialEcoregion>();
        }
    }

    class NorthAmericanEcoregions : NorthAmericanTerrestrialEcoregions
    {
        public string Continent { get; set; }

        public NorthAmericanEcoregions(string continent)
        {
            Continent = continent;
        }
    }
}
