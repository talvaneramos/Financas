using Financas.Domain.Dtos;
using Financas.Domain.Interfaces.Services;
using Financas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Domain.Services
{
    public class ContaDomainService : IContaDomainService
    {
        private readonly IContaDomainService _contaDomainService;

        public ContaDomainService(IContaDomainService contaDomainService)
        {
            _contaDomainService = contaDomainService;
        }

        public async Task<Guid> Criar(CriarContaDto dto)
        {
            var conta = new Conta
            {

            };
        }
    }
}
