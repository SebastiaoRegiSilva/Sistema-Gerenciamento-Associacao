using Disparo.Plataforma.Domain.Alunos;
using Disparo.Plataforma.Domain.Classes;
using Disparo.Plataforma.Domain.Emails.Exceptions;
using Disparo.Plataforma.Infrastructure.Repositories.MongoDb.Alunos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Api.Controllers
{
    /// <summary>Controller que provê endpoints relacionados a entidade aluno.</summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        /// <summary>Serviço que provê acesso aos dados e operações relacionadas aos alunos.</summary>
        private readonly AlunoService _alunoService;

        /// <summary>Serviço que provê acesso aos dados e operações relacionadas as classes.</summary>
        private readonly ClasseService _classeService;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="alunoService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas aos alunos.</param>
        /// <param name="classeService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas as classes.</param>
        public AlunoController(AlunoService alunoService, ClasseService classeService)
        {
            _alunoService = alunoService;
            _classeService = classeService;
        }

        /// <summary> Recuperar no repositório o aluno com base em sua matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <returns>Um aluno cadastrado no repositório.</returns>
        [HttpGet("{matricula}")]
        public async Task<ActionResult<AlunoModel>> BuscarPorMatricula(int matricula)
        {
            var alunoRecuperado = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            
            return alunoRecuperado == null? Json($"O aluno com a matrícula {matricula} não existe na base de dados."): Json(alunoRecuperado); 
        }

        /// <summary> 
        /// Cadastrar no repositório um aluno.
        /// </summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <param name="nome">Nome do aluno.</param>
        /// <param name="dataNascimento">Data de nascimento do aluno.(Formato yyyy-mm-dd)</param>
        /// <param name="enderecoEmail">Endereço institucional do aluno.</param>
        /// <param name="numerosTelefones">Formas de contato telefônico direto com o aluno.</param>
        /// <param name="habilitacaoClasse">Habilitação da classe que o aluno será cadastrado.</param>
        [HttpPost]
        public async Task<IActionResult> CadastrarAluno(int matricula, string nome,  string dataNascimento, 
        string enderecoEmail, string numerosTelefones, string habilitacaoClasse)
        {
            var classeRecuperada = await _classeService.RecuperarClassePorHabilitacaoAsync(habilitacaoClasse);
            
            if(classeRecuperada == null)
                Json($"A classe com a habilitação {habilitacaoClasse} não existe na base de dados!");
            
            if(! _alunoService.ValidarEmailAsync(enderecoEmail).Result)
                throw new AddressEmailInvalidException(enderecoEmail);
            
            var numeros = new List<string>();
            numeros.Add(numerosTelefones);

            await _alunoService.CadastrarAlunoAsync(ConverterIntString(matricula), nome, ConverterStringDateTime(dataNascimento), enderecoEmail, numeros, classeRecuperada);         

            return Json("Aluno cadastrado com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> EditarAluno(int matricula)
        {
            // Validar se o aluno existe antes de tentar editá-lo.
            var alunoRecuperado = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            if(alunoRecuperado == null)
                return NotFound($"A matrícula {matricula} não existe na base de dados.");
            
            await _alunoService.EditarAlunoAsync(ConverterIntString(matricula));
            return Json("Aluno editado com sucesso!");
        }

        [Route("deletar/{matricula}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAluno(int matricula)
        {
            var alunoRecuperado = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            if (alunoRecuperado == null)
                return Json($"O aluno com a matrícula{ConverterIntString(matricula)} não existe na base de dados!");
            
            await _alunoService.ExcluirAlunoAsync(ConverterIntString(matricula));
            return Json($"O aluno com a matrícula {matricula} foi deletado da base de dados.");
        }

        [Route("deletar/todos")]
        [HttpDelete]
        public async Task<IActionResult> DeleteTodosAlunos()
        {
            await _alunoService.ExcluirTodosAlunosAsync();
            return Json($"Toda base de alunos foi deletada com sucesso.");
        }

        /// <summary>Converte um integer em string.</summary>
        /// <param name="content">Conteúdo a ser convertido.</param>
        /// <returns>Uma string válida ou mensagem para o usuário.</returns>
        private string ConverterIntString(int? content)
        {
            string result = "";

            if(content != null)
                result = Convert.ToString(content);
            else
                result = "Insira uma matrícula válida, por favor!";

            return result;
        }

        /// <summary>Converte uma string em datetime.</summary>
        /// <param name="content">Conteúdo a ser convertido.</param>
        /// <returns>Uma datetime válida ou mensagem para o usuário.</returns>
        private DateTime ConverterStringDateTime(string content)
        {
            DateTime result = new DateTime();
            
            if(content != null)
                result = DateTime.Parse(content);
            else
                Json("Insira uma data válida, por favor!");

            return result;
        }
    }
}