using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CandyShop.Models
{
    public class PieServiceWithEntity : IPieRepository
    {
        public AppDBContext AppDBContext { get; }
        public PieServiceWithEntity(AppDBContext appDBContext)
        {
            AppDBContext = appDBContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return AppDBContext.Pies.Include(p => p.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AppDBContext.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return AppDBContext.Pies.Include(p=>p.Category).FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
