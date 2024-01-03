using Financas.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Domain.Interfaces.Services
{
    public interface IContaDomainService
    {
        Task<Guid> Criar(CriarContaDto dto);
    }
}
