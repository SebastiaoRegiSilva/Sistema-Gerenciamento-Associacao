using Disparo.Plataforma.Domain.Alunos;
using Disparo.Plataforma.Domain.Classes;
using Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Alunos.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Alunos
{
    public class AlunoRepository : IAlunoRepository
    {
        /// <summary>Contexto utilizado pelo repositório de alunos para acessar a coleção de um aluno na base de dados.</summary> 
        private readonly AlunoContext _ctxAluno = null;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="conString">String para conexão com a base de dados.</param>
        /// <param name="database">Nome da base de dados onde se encontra o repositório.</param>
        public AlunoRepository(string conString, string database)
        {
            _ctxAluno = new AlunoContext(conString, database);
        }
    
        /// <summary>Cadastra na base de dados um novo aluno.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNascimento">Data de nascimento do aluno.</param>
        /// <param name="enderecoEmail">Endereço de e-mail institucional.</param>
        /// <param name="numerosTelefones">Números para comunicação direta com o aluno.</param>
        /// <param name="classe">Classe onde o aluno foi matriculado.</param>
        public async Task<string>CadastrarAlunoAsync(string matricula, string nome, DateTime dataNascimento, string enderecoEmail, IEnumerable<string> numerosTelefones, Classe classe)
        {
            // Chamar services da classe.
            
            var model = new AlunoModel
            {
                Matricula = matricula,
                Nome = nome,
                DataNascimento = dataNascimento,
                EnderecoEmail = enderecoEmail,
                NumerosTelefones = numerosTelefones
            };

            await _ctxAluno.Alunos.InsertOneAsync(model);

            return model.Id;
        }
        
        /// <summary>Edita na base de dados um aluno cadastrado.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task EditarAlunoAsync(string matricula)
        {
            var alunoRecuperado = RecuperarAlunoMatriculaAsync(matricula);
            
            var builder = Builders<AlunoModel>.Filter;
            var filter = builder.Eq(a => a.Matricula, matricula);

            var update = Builders<AlunoModel>.Update
                .Set(a => a.Matricula, alunoRecuperado.Result.Matricula)
                .Set(a => a.Nome, alunoRecuperado.Result.Nome)
                .Set(a => a.DataNascimento, alunoRecuperado.Result.DataNascimento)
                .Set(a => a.EnderecoEmail, alunoRecuperado.Result.EnderecoEmail)
                .Set(a => a.NumerosTelefones, alunoRecuperado.Result.NumerosTelefones);

            await _ctxAluno.Alunos.UpdateOneAsync(filter, update);
        }
        
        /// <summary>Recupera na base de dados um aluno cadastrado com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task<Aluno>RecuperarAlunoMatriculaAsync(string matricula)
        {
            var builder = Builders<AlunoModel>.Filter;
            var filter = builder.Eq(a => a.Matricula, matricula);
            
            return await _ctxAluno.Alunos
                .Aggregate()
                .Match(filter)
                .FirstOrDefaultAsync();
        }

        /// <summary>Recupera na base de dados um aluno cadastrado com base no nome.</summary>
        /// <param name="nome">Nome do aluno.</param>
        public async Task<Aluno>RecuperarAlunoNomeAsync(string nome)
        {
            var builder = Builders<AlunoModel>.Filter;
            var filter = builder.Eq(a => a.Nome, nome);
            
            return await _ctxAluno.Alunos
                .Aggregate()
                .Match(filter)
                .FirstOrDefaultAsync();
        }

        // <summary>Exclui na base de dados um aluno cadastrado no sistema com base na matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        public async Task ExcluirAlunoAsync(string matricula)
        {
            var filter = Builders<AlunoModel>.Filter.Eq(a => a.Matricula, matricula);

            await _ctxAluno.Alunos.DeleteOneAsync(filter);
        }

        /// <summary>Exclui na base de dados todos alunos cadastrados.</summary>
        /// <param name="matricula">Corrigir essa função.</param>
        public async Task ExcluirTodosAlunoAsync(string matricula)
        {
            // Recuperar todos para excluir.
            
            var filter = Builders<AlunoModel>.Filter.Eq(a => a.Matricula, matricula);

            await _ctxAluno.Alunos.DeleteOneAsync(filter);
        }
    }
}