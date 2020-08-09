using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie> {
                new Pie{PieId=1,Name="Straberry Pie", Price=15.95M,ShortDescription="",LongDescription=""},
                new Pie{PieId=2,Name="Cheese cake", Price=18.95M,ShortDescription="",LongDescription=""},
                new Pie{PieId=3,Name="Rhubard Pie", Price=15.95M,ShortDescription="",LongDescription=""},
                new Pie{PieId=4,Name="Pumpskin Pie", Price=12.95M,ShortDescription="",LongDescription=""}
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
