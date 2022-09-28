using System;

namespace csharp
{
    public static class QualityRangeChecker
    {
        public static int CheckQualityAndSetInRange(this Item item, int maxQuality, int minQuality)
        {
            return Math.Min(maxQuality, Math.Max(0, item.Quality));
        }  
    }
}