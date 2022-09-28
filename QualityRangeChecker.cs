using System;

namespace csharp
{
    public static class QualityRangeChecker
    {
        public static int SetQualityInRange(this Item item, int maxQuality, int minQuality)
        {
            return Math.Min(maxQuality, Math.Max(minQuality, item.Quality));
        }  
    }
}