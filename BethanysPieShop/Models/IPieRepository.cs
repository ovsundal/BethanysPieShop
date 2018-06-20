using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
