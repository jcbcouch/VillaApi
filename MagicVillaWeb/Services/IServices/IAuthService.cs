﻿using MagicVillaWeb.Models.Dto;

namespace MagicVillaWeb.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate);
    }
}
