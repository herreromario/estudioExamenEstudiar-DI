using Castle.Core.Logging;
using estudioExamenEstudiar.Backend.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudioExamenEstudiar.Backend.Servicios
{
    public class ModeloArticuloRepository : GenericRepository<Modeloarticulo>, IModeloArticuloRepository
    {
        public ModeloArticuloRepository(
            DiinventarioexamenContext context,
            ILogger<GenericRepository<Modeloarticulo>> logger)
            : base(context, logger)
        {
        }

        public async Task<bool> ExistsByNameAsync(string nombre, CancellationToken cancellationToken = default)
        {
            return await Query(asNoTracking: true)
                .AnyAsync(m => m.Nombre == nombre, cancellationToken);
        }
    }
}
