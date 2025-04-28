using MagicVillaApi.Data;
using MagicVillaApi.Models.Dto;
using MagicVillaApi.Models;
using MagicVillaApi.Repository.IRepostiory;

namespace MagicVillaApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
