using Disparo.Plataforma.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Domain.Alunos
{
    /// <summary>Serviço que provê acesso aos dados dos alunos.</summary>
    public class AlunoService
    {
        /// <summary>Repositório para armazenamento dos alunos.</summary>
        private readonly IAlunoRepository _alunoRep;
        
        /// <summary>Construtor com injeção de dependência.</summary>
        /// <param name="alunoRep">Repositório para armazenamento dos alunos.</param>
        public AlunoService(IAlunoRepository alunoRep)
        {
            _alunoRep = alunoRep;
        }
    
        /// <summary>Cadastra no repositório um novo aluno.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNascimento">Data de nascimento do aluno.</param>
        /// <param name="enderecoEmail">Endereço de e-mail institucional.</param>
        /// <param name="numerosTelefones">Números para comunicação direta com o aluno.</param>
        /// <param name="classe">Classe onde o aluno foi matriculado.</param>
        /// <returns>Código de identificação gerado para um aluno cadastrado.</returns>
        public async Task<string> CadastrarAlunoAsync(string matricula, string nome, DateTime dataNascimento, 
        string enderecoEmail, IEnumerable<string> numerosTelefones, Classe classe)
        {
            var idConta = await _alunoRep.CadastrarAlunoAsync(matricula, nome, dataNascimento, enderecoEmail, numerosTelefones, classe);

            return idConta;
        }

        /// <summary>Edita no repositório um aluno cadastrado.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task EditarAlunoAsync(string matricula)
        {
            // Melhorar aqui... Permitir a edição de todos os campos da classe.
            await _alunoRep.EditarAlunoAsync(matricula);
        }

        /// <summary>Recupera no repositório um aluno cadastrado com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task<Aluno>RecuperarAlunoMatriculaAsync(string matricula)
        {
            return await _alunoRep.RecuperarAlunoMatriculaAsync(matricula);
        }

        /// <summary>Recupera no repositório um aluno cadastrado com base no nome.</summary>
        /// <param name="nome">Nome do aluno.</param>
        public async Task<Aluno>RecuperarAlunoNomeAsync(string nome)
        {
            return await _alunoRep.RecuperarAlunoNomeAsync(nome);
        }

        /// <summary>Exclui no repositório um aluno cadastrado no sistema com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task ExcluirAlunoAsync(string matricula)
        {
            await _alunoRep.ExcluirAlunoAsync(matricula);
        }

        /// <summary>Exclui no repositório todos alunos cadastrados.</summary>
        public async Task ExcluirTodosAlunoAsync()
        {
            await _alunoRep.ExcluirTodosAlunoAsync();
        }
    }
}