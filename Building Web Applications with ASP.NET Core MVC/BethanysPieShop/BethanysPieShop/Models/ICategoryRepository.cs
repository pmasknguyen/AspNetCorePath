using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
