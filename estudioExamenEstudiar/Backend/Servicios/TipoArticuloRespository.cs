using Microsoft.Extensions.Logging;
using estudioExamenEstudiar.Backend.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudioExamenEstudiar.Backend.Servicios
{
    public class TipoArticuloRepository : GenericRepository<Tipoarticulo>, ITipoArticuloRepository
    {
        public TipoArticuloRepository(DiinventarioexamenContext context, ILogger<GenericRepository<Tipoarticulo>> logger)
            : base(context, logger)
        {

        }
    }
}
