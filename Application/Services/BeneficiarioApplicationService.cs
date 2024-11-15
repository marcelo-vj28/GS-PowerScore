using GS_PowerScore.MVC.Domain.Entities;
using GS_PowerScore.MVC.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using GS_PowerScore.Application.Dtos;
using GS_PowerScore.Application.Interfaces;

namespace GS_PowerScore.Application.Services
{
    public class BeneficiarioApplicationService : IBeneficiarioApplicationService
    {
        private readonly IBeneficiarioRepository _beneficiarioRepository;

        public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository)
        {
            _beneficiarioRepository = beneficiarioRepository;
        }

        public void Adicionar(BeneficiarioDto beneficiarioDto)
        {
            var beneficiario = new BeneficiarioEntity
            {
                IdCliente = beneficiarioDto.IdCliente,
                Nome = beneficiarioDto.Nome,
                DataNascimento = beneficiarioDto.DataNascimento,
                Cpf = beneficiarioDto.Cpf,
                Telefone = beneficiarioDto.Telefone,
                Email = beneficiarioDto.Email,
                Endereco = beneficiarioDto.Endereco
            };
            _beneficiarioRepository.Adicionar(beneficiario);
        }

        public void Atualizar(BeneficiarioDto beneficiarioDto)
        {
            var beneficiario = new BeneficiarioEntity
            {
                IdCliente = beneficiarioDto.IdCliente,
                Nome = beneficiarioDto.Nome,
                DataNascimento = beneficiarioDto.DataNascimento,
                Cpf = beneficiarioDto.Cpf,
                Telefone = beneficiarioDto.Telefone,
                Email = beneficiarioDto.Email,
                Endereco = beneficiarioDto.Endereco
            };
            _beneficiarioRepository.Atualizar(beneficiario);
        }

        public void Remover(int id)
        {
            _beneficiarioRepository.Remover(id);
        }

        public BeneficiarioDto? ObterPorId(int id)
        {
            var beneficiario = _beneficiarioRepository.ObterPorId(id);
            return beneficiario == null ? null : new BeneficiarioDto
            {
                IdCliente = beneficiario.IdCliente,
                Nome = beneficiario.Nome,
                DataNascimento = beneficiario.DataNascimento,
                Cpf = beneficiario.Cpf,
                Telefone = beneficiario.Telefone,
                Email = beneficiario.Email,
                Endereco = beneficiario.Endereco
            };
        }

        public IEnumerable<BeneficiarioDto> ObterTodos()
        {
            var beneficiarios = _beneficiarioRepository.ObterTodos();
            return beneficiarios.Select(beneficiario => new BeneficiarioDto
            {
                IdCliente = beneficiario.IdCliente,
                Nome = beneficiario.Nome,
                DataNascimento = beneficiario.DataNascimento,
                Cpf = beneficiario.Cpf,
                Telefone = beneficiario.Telefone,
                Email = beneficiario.Email,
                Endereco = beneficiario.Endereco
            });
        }
    }
}