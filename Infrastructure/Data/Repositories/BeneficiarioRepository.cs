using GS_PowerScore.Domain.Entities;
using GS_PowerScore.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GS_PowerScore.Infrastructure.Data.Repositories;

public class BeneficiarioRepository : IBeneficiarioRepository
{
    private readonly List<BeneficiarioEntity> _beneficiarios = new List<BeneficiarioEntity>();

    public void Adicionar(BeneficiarioEntity beneficiario)
    {
        beneficiario.IdCliente = _beneficiarios.Count > 0 ? _beneficiarios.Max(b => b.IdCliente) + 1 : 1;
        _beneficiarios.Add(beneficiario);
    }

    public void Atualizar(BeneficiarioEntity beneficiario)
    {
        var beneficiarioExistente = _beneficiarios.FirstOrDefault(b => b.IdCliente == beneficiario.IdCliente && b.IdCliente == beneficiario.IdCliente);
        if (beneficiarioExistente != null)
        {
            _beneficiarios.Remove(beneficiarioExistente);
            _beneficiarios.Add(beneficiario);
        }
    }

    public void Remover(int id, int idCliente)
    {
        var beneficiario = _beneficiarios.FirstOrDefault(b => b.IdCliente == id && b.IdCliente == idCliente);
        if (beneficiario != null)
        {
            _beneficiarios.Remove(beneficiario);
        }
    }

    public BeneficiarioEntity ObterPorId(int id, int idCliente)
    {
        return _beneficiarios.FirstOrDefault(b => b.IdCliente == id && b.IdCliente == idCliente);
    }

    public IEnumerable<BeneficiarioEntity> ObterTodos(int idCliente)
    {
        return _beneficiarios.Where(b => b.IdCliente == idCliente);
    }

    void IBeneficiarioRepository.Remover(int idCliente)
    {
        throw new NotImplementedException();
    }

    BeneficiarioEntity IBeneficiarioRepository.ObterPorId(int idCliente)
    {
        throw new NotImplementedException();
    }

    IEnumerable<BeneficiarioEntity> IBeneficiarioRepository.ObterTodos()
    {
        throw new NotImplementedException();
    }
}
