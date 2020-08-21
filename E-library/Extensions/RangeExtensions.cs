using E_library.Constants;
using E_library.Dto;
using E_library.Models;
using System.Linq;

namespace E_library.Extensions
{
    public static class RangeExtensions
    {
        public static IQueryable<T> AddYearRangeFilter<T>(this IQueryable<T> query, IntRange range)
            where T : AbstractPublication
        {
            if (range == null)
            {
                return query;
            }

            return query.Where(x => x.Year >= (range.Gte ?? FilterLimits.MinYear)
            && x.Year <= (range.Lte ?? FilterLimits.MaxYear));
        }

        public static IQueryable<T> AddPageRangeFilter<T>(this IQueryable<T> query, IntRange range)
            where T : AbstractPublication
        {
            if (range == null)
            {
                return query;
            }

            return query.Where(x => x.PageAmount >= (range.Gte ?? FilterLimits.MinPageNumber) 
            && x.PageAmount <= (range.Lte ?? FilterLimits.MaxPageNumber));
        }
    }
}