using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using estudioExamenEstudiar.Backend.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudioExamenEstudiar.Backend.Servicios
{
    public class ModeloArticuloRepository : GenericRepository<Modeloarticulo>, IModeloArticuloRepository
    {
        public ModeloArticuloRepository(DiinventarioexamenContext context, ILogger<GenericRepository<Modeloarticulo>> logger) : base(context, logger)
        {

        }
    }
}
