using GS_PowerScore.Application.Dtos;
using System.Collections.Generic;

namespace GS_PowerScore.Application.Interfaces
{
    public interface IBeneficiarioApplicationService
    {
        void Adicionar(BeneficiarioDto beneficiarioDto);
        void Atualizar(BeneficiarioDto beneficiarioDto);
        void Remover(int id);
        BeneficiarioDto ObterPorId(int id);
        IEnumerable<BeneficiarioDto> ObterTodos();
    }
}