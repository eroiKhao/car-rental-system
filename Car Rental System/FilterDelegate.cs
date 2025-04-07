using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal delegate bool FilterDelegate<T>(T entity) where T : IEntity;
}
