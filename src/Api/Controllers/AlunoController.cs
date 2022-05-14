using Disparo.Plataforma.Domain.Alunos;
using Disparo.Plataforma.Domain.Classes;
using Disparo.Plataforma.Domain.Emails.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Api.Controllers
{
    /// <summary>Controller que provê endpoints relacionados a entidade aluno.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        /// <summary>Serviço que provê acesso aos dados e operações relacionadas aos alunos.</summary>
        private readonly AlunoService _alunoService;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="alunoeService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas aos alunos.</param>
        public AlunoController(AlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        /// <summary> Recuperar no repositório o aluno com base em sua matrícula.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <returns>Um aluno cadastrado no repositório.</returns>
        [HttpGet("{matricula}")]
        public async Task<ActionResult<Aluno>> BuscarPorMatricula(int matricula)
        {
            var aluno = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            if (aluno == null)
                return NotFound();
            
            return Ok(aluno);
        }

        /// <summary> Recuperar no repositório o aluno com base em seu nome.</summary>
        /// <param name="nome">Nome do aluno.</param>
        /// <returns>Um aluno cadastrado no repositório.</returns>
        [HttpGet("{nome}")]
        public async Task<ActionResult<Aluno>> BuscarPorNome(string nome)
        {
            var aluno = await _alunoService.RecuperarAlunoNomeAsync(nome);
            if (aluno == null)
                return NotFound();
            
            return Ok(aluno);
        }
        
        /// <summary> Cadastrar no repositório um aluno.</summary>
        /// <param name="matricula">Matrícula do aluno.</param>
        /// <param name="dataNascimento">Data de nascimento do aluno.</param>
        /// <param name="enderecoEmail">Endereço institucional do aluno.</param>
        /// <param name="numerosTelefones">Formas de contato telefônico direto com o aluno.</param>
        /// <param name="classe">Classe que o aluno será cadastradado.</param>
        [HttpPost]
        public async Task<IActionResult> CadastrarAluno(int matricula, string nome,  DateTime dataNascimento, 
        string enderecoEmail, string numerosTelefones, Classe classe)
        {
            if(! _alunoService.ValidarEmailAsync(enderecoEmail).Result)
                throw new AddressEmailInvalidException(enderecoEmail);
            
            var numeros = new List<string>();
            numeros.Add(numerosTelefones);

            await _alunoService.CadastrarAlunoAsync(ConverterIntString(matricula), nome, dataNascimento, enderecoEmail, numeros, classe);         

            return Ok("Aluno cadastrado com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> EditarAluno(int matricula)
        {
            // Validar se o aluno existe antes de tentar editá-lo.
            var alunoRecuperado = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            if(alunoRecuperado == null)
                return NotFound($"A matrícula {matricula} não existe na base de dados.");
            
            await _alunoService.EditarAlunoAsync(ConverterIntString(matricula));
            return Ok("Aluno editado com sucesso!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAluno(int matricula)
        {
            var alunoRecuperado = await _alunoService.RecuperarAlunoMatriculaAsync(ConverterIntString(matricula));
            if (alunoRecuperado == null)
                return Ok($"O aluno com a matrícula{ConverterIntString(matricula)} não existe na base de dados!");
            
            await _alunoService.ExcluirAlunoAsync(ConverterIntString(matricula));
            return Ok($"O aluno com a matrícula {matricula} foi deletado da base de dados.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTodosAluno()
        {
            await _alunoService.ExcluirTodosAlunoAsync();
            return Ok($"Toda base de alunos foi deletada com sucesso.");
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
    }
}