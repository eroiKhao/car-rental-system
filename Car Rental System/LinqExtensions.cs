using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal static class LinqExtensions
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> data, int currentPage, int skip)
        {
            return data.Skip(currentPage * skip).Take(skip);
        }
    }
}
