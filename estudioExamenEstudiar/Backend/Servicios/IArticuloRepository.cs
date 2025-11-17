using estudioExamenEstudiar.Backend.Modelos;

namespace estudioExamenEstudiar.Backend.Servicios
{
    /// <summary>
    /// Contrato de repositorio para la entidad <see cref="Articulo"/>.
    /// Extiende el repositorio genérico <see cref="IGenericRepository{T}"/>.
    /// </summary>
    public interface IArticuloRepository : IGenericRepository<Articulo>
    {
    }
}