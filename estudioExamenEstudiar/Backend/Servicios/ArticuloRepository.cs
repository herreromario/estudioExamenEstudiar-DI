using Microsoft.Extensions.Logging;
using estudioExamenEstudiar.Backend.Modelos;

namespace estudioExamenEstudiar.Backend.Servicios
{
    /// <summary>
    /// Repositorio específico para <see cref="Articulo"/>, implementa <see cref="IArticuloRepository"/>.
    /// Sigue el mismo patrón que los repositorios existentes en la carpeta.
    /// </summary>
    public class ArticuloRepository : GenericRepository<Articulo>, IArticuloRepository
    {
        private readonly DiinventarioexamenContext _context;

        public ArticuloRepository(
            DiinventarioexamenContext context,
            ILogger<GenericRepository<Articulo>> logger)
            : base(context, logger)
        {
            _context = context;
        }

        public async Task AddArticulosAsync(Articulo articulo)
        {
            try
            {
                await _context.Articulos.AddAsync(articulo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al añadir artículo: " + ex.Message);
            }
        }
    }
}