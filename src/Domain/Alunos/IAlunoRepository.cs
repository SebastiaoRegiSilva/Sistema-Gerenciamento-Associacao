using Disparo.Plataforma.Domain.Classes;
using Disparo.Plataforma.Domain.NumerosTelefones;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Domain.Alunos
{
    /// <summary>Interface que padroniza o repositório dos alunos.</summary>
    public interface IAlunoRepository
    {
        /// <summary>Cadastra na base de dados um novo aluno.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNascimento">Data de nascimento do aluno.</param>
        /// <param name="enderecoEmail">Endereço de e-mail institucional.</param>
        /// <param name="numerosTelefones">Números para comunicação direta com o aluno.</param>
        /// <param name="classe">Classe onde o aluno foi matriculado.</param>
        Task<string>CadastrarAluno(string matricula, string nome, DateTime dataNascimento, string enderecoEmail, IEnumerable<string> numerosTelefones, Classe classe);
        
        /// <summary>Edita na base de dados aluno cadastrado.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        Task<Aluno>EditarAluno(string matricula);
        
        /// <summary>Recupera na base de dados aluno cadastrado com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        Task<Aluno>RecuperarAlunoMatricula(string matricula);

        /// <summary>Recupera na base de dados aluno cadastrado com base no nome.</summary>
        /// <param name="nome">Nome do aluno.</param>
        Task<Aluno>RecuperarAlunoNome(string nome);
    }
}