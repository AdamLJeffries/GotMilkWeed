
namespace GotMilkWeed
{
    public class GrowRegion
    {
        public static string GetStateByEcoregion(string ecoregion)
        {
            // Define a lookup table that maps ecoregions to US states
            Dictionary<string, string> ecoregionToState = new Dictionary<string, string>()
        {
            { "Eastern Temperate Forests", "AL, AR, CT, DE, FL, GA, IL, IN, KY, LA, MA, MD, ME, MI, MN, MO, MS, NC, NH, NJ, NY, OH, OK, PA, RI, SC, TN, TX, VA, VT, WI, WV" },
            { "Great Plains", "CO, IA, KS, MN, MO, MT, ND, NE, NM, OK, SD, TX, WY" },
            { "North American Deserts", "AZ, CA, CO, ID, MT, ND, NM, NV, OR, SD, TX, UT, WA, WY" },
            { "Northern Forests", "ME, NH, NY, VT, MA, CT, RI, PA, NJ, MD, DE, WV, OH, IN, IL, WI, MI, MN, IA, MO" },
            { "Northwestern Forested Mountains", "AK, CA, CO, ID, MT, NV, OR, UT, WA, WY" },
            { "Pacific Coastal", "AK, CA, HI, OR, WA" },
            { "Prairies and Savannas", "AL, AR, FL, GA, IL, IN, IA, KS, KY, LA, MI, MN, MS, MO, NE, NC, ND, OH, OK, SC, SD, TN, TX, VA, WI, WV" },
            { "Southern Semi-Arid Highlands", "AZ, NM, OK, TX" },
            { "Temperate Sierras", "CA, NV" },
            { "Tropical Wet Forests", "FL, HI, PR, VI" }
        };

            // Find the state(s) associated with the given ecoregion
            if (ecoregionToState.TryGetValue(ecoregion, out string stateList))
            {
                // If there is only one state associated with the ecoregion, return it
                if (stateList.Length == 2)
                {
                    return stateList;
                }
                else // If there are multiple states associated with the ecoregion, return a comma-separated list
                {
                    return stateList.Replace(", ", ",");
                }
            }
            else // If there is no state associated with the given ecoregion, return null
            {
                return null;
            }
        }
    }
}

