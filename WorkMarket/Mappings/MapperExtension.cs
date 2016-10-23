using System.Collections.Generic;
using System.Linq;

namespace WorkMarket.Mappings
{
    public static class MapperExtension
    {
        public static TDest MapTo<TDest>(this object obj)
        {
            return VMMapper.Instance.Map<TDest>(obj);
        }

        public static IEnumerable<TDest> MapTo<TDest>(this IEnumerable<object> list)
        {
            return list.Select(o => o.MapTo<TDest>());
        }
    }
}
