//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using ServiceCommonCollection;
//using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using ServiceCommonCollection;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCommonPapping
{
    public static class PagingExtension
    {
        public static async Task<DataCollection<T>> GetPagedAsync<T>(this IQueryable<T> query)
        {
            var item = await query.ToListAsync();
            var result = new DataCollection<T>
            {
                Items = item,
                Count = item.Count
            };
            return result;
        }
    }
}
