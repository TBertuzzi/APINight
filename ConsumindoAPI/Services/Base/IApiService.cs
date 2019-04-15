using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConsumindoAPI.Model;

namespace ConsumindoAPI.Services
{
    public interface IApiService
    {
        Task<List<Pessoa>> GetUsuario();
    }
}
