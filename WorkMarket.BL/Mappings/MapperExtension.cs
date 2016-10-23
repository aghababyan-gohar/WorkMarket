using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarket.BL.Mappings
{
    public static class MapperExtension
    {
        public static TDest MapTo<TDest>(this object obj)
        {
            return DTOMapper.Instance.Map<TDest>(obj);
        }

        public static IEnumerable<TDest> MapTo<TDest>(this IEnumerable<object> list)
        {
            return list.Select(o => o.MapTo<TDest>());
        }
    }
}
