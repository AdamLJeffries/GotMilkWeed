namespace GotMilkWeed
{
    using System;
    using System.Collections.Generic;

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

    class Program
    {
        static void Main()
        {
            NorthAmericanEcoregions northAmericanEcoregions = new NorthAmericanEcoregions("North America");

            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Arctic Tundra", Description = "Cold and dry biome with low-growing vegetation" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Boreal Forests/Taiga", Description = "Coniferous forests with long, cold winters and short, mild summers" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Temperate Coniferous Forests", Description = "Forests dominated by coniferous trees in regions with mild, wet winters and warm, dry summers" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Temperate Broadleaf and Mixed Forests", Description = "Forests dominated by broadleaf trees in regions with mild winters and warm summers" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Temperate Grasslands, Savannas, and Shrublands", Description = "Grasslands, savannas, and shrublands in regions with moderate to high precipitation" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Mediterranean Forests, Woodlands, and Scrub", Description = "Forests, woodlands, and scrublands in regions with hot, dry summers and mild, wet winters" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Deserts and Xeric Shrublands", Description = "Areas with very low precipitation and characterized by desert or shrubland vegetation" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Tropical and Subtropical Coniferous Forests", Description = "Forests dominated by coniferous trees in regions with high precipitation and warm temperatures" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Tropical and Subtropical Moist Broadleaf Forests", Description = "Forests dominated by broadleaf trees in regions with high precipitation and warm temperatures" });
            northAmericanEcoregions.Ecoregions.Add(new TerrestrialEcoregion { Name = "Tropical and Subtropical Dry Broadleaf Forests", Description = "Forests dominated by broadleaf trees in regions with low precipitation and warm temperatures" });
        }
    }
}
