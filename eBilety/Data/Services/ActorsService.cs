using eBilety.Data.Base;
using eBilety.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilety.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
