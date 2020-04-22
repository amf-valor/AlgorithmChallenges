using System.Collections.Generic;

namespace Common.Extensions
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> aCollection) 
        {
            return aCollection is null || aCollection.Count == 0;
        }
    }
}
