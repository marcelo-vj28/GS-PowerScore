using GS_PowerScore.Domain.Entities;
using System.Collections.Generic;

namespace GS_PowerScore.Domain.Interfaces
{
    public interface IBeneficiarioRepository
    {
        void Adicionar(BeneficiarioEntity beneficiario);
        void Atualizar(BeneficiarioEntity beneficiario);
        void Remover(int idCliente);
        BeneficiarioEntity ObterPorId(int idCliente);
        IEnumerable<BeneficiarioEntity> ObterTodos();
    }
}
