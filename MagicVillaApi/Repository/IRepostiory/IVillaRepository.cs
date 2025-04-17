using MagicVillaApi.Models;
using System.Linq.Expressions;

namespace MagicVillaApi.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {

        Task<Villa> UpdateAsync(Villa entity);

    }
}
