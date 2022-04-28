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
        Task<string>CadastrarAluno(string matricula, string nome, DateTime dataNascimento, string enderecoEmail, IEnumerable<NumeroTelefone> numerosTelefones, Classe classe);
        
        /// <summary>Edita na base de dados aluno cadastrado.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        Task<Aluno>EditarAluno(string matricula);
        
        /// <summary>Recupera na base de dados aluno cadastrado com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        Task<Aluno>RecuperarAlunoMatricula(string matricula);

        /// <summary>Recupera na base de dados aluno cadastrado com base no nome.</summary>
        /// <param name="nome">Nome do aluno.</param>
        Task<Aluno>RecuperarAlunoNome(string nome);

        
        // /// <summary>Recupera na base de dados uma conta com base em seu número.</summary>
        // /// <param name="numeroConta"> Número da conta.</param>
        // /// <returns>Objeto de valor contendo as informações da conta recuperada.</returns>
        // Task<Account> RecuperarContaPorNumeroAsync(int numeroConta);

        // /// <summary>Recupera na base de dados uma conta com base em seu número.</summary>
        // /// <param name="id"> Código de identificação da conta.</param>
        // /// <returns>Objeto de valor contendo as informações da conta recuperada.</returns>
        // Task<Account> RecuperarContaPorIdAsync(string id);

        // /// <summary>Edita na base de dados uma conta cadastrada no sistema.</summary>
        // /// <param name="id">Código de identificação da conta.</param>
        // /// <param name="numeroConta">Número da conta do cliente.</param>
        // /// <param name="cliente">Proprietário da conta.</param>
        // /// <param name="tipoDaConta">Tipo da conta.</param>
        // /// <param name="dataCadastro">Data em que o cliente foi cadastrado no sistema.</param>
        // /// <param name="dataUltimoAcesso">Data em que o cliente fez o último acesso no sistema.</param>
        // /// <param name="dataAlteracao">Data em que foram feitas eventuais alterações cadastrais na conta.</param>
        // /// <param name="saldo">Quantidade de saldo em conta.</param>
        // /// <param name="statusDaConta">Situação da conta do cliente.</param>
        // Task EditarContaAsync(string id, int numeroConta, Client cliente, AccountType tipoDaConta, DateTime dataCadastro, DateTime dataUltimoAcesso, 
        // DateTime dataAlteracao, decimal saldo, AccountStatus statusDaConta);
        
        // /// <summary>Exclui na base de dados uma conta cadastrada no sistema.</summary>
        // /// <param name="numeroConta">Número da conta.</param>
        // Task ExcluirContaAsync(int numeroConta);

        // /// <summary>Realiza depósito em conta com base no númera do conta.</summary>
        // /// <param name="numeroConta">Número da conta.</param>
        // /// <param name="valor">Valor a ser depositado na conta.</param>
        // Task DepositarContaAsync(int numeroConta, decimal valor);

        // /// <summary>Recuperar na base de dados o saldo em conta de um cliente cadastrado.</summary>
        // /// <param name="numeroConta">Número da conta.</param>
        // ///<returns>Saldo em conta.</returns>
        // Task<decimal> RecuperarSaldoAsync(int numeroConta);

        // /// <summary>Sacar na conta do cliente.</summary>
        // /// <param name="accountNumber">Número da conta do cliente.</param>
        // /// <param name="value">Valor em reais a ser sacado na conta do cliente.</param>
        // Task SacarContaAsync(int accountNumber, decimal value);
    }
}