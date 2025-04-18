using MagicVillaApi.Models;

namespace MagicVillaApi.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
