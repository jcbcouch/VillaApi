using MagicVillaWeb.Models.Dto;

namespace MagicVillaWeb.Services.IServices
{
    public interface ITokenProvider
    {
        void SetToken(TokenDTO tokenDTO);
        TokenDTO? GetToken();
        void ClearToken();
    }
}
