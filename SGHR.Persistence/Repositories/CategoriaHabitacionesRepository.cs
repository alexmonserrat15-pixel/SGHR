using SGHR.Persistence.Base;
using SGHR.Persistence.Interfaces;
using SGRH.Domain.Base;
using SGRH.Domain.Entities.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGHR.Persistence.Repositories
{
    public class CategoriaHabitacionesRepository : BaseRepository<CategoriaHabitaciones, int>, ICategoriaHabitaciones
    {
        private readonly SGHRContext context;
        public CategoriaHabitacionesRepository(SGHRContext context) : base(context)
        {
            this.context = context;
        }

        public override Task<OperationResult> SaveEntityAsync(CategoriaHabitaciones entity)
        {
            return base.SaveEntityAsync(entity);
        }
    }
}
