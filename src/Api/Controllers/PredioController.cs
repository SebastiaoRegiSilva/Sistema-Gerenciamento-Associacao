using Disparo.Plataforma.Domain.Predios.Exceptions;
using Domain.Plataforma.Domain.Predios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Api.Controllers
{
    /// <summary>Controller que provê endpoints relacionados a entidade prédio.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PredioController : ControllerBase
    {
        /// <summary>Serviço que provê acesso aos dados e operações relaciondas aos prédios.</summary>
        private readonly PredioService _predioService;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="predioService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas aos prédios.</param>
        public PredioController(PredioService predioService)
        {
            _predioService = predioService;
        }

        [HttpGet("{numero}")]
        public async Task<ActionResult<Predio>> BuscarPredioNumero (int numero)
        {
            var predio = await _predioService.RecuperarPredioPorNumeroAsync(numero);
            if (predio == null)
                return NotFound($"O prédio com o número {numero} não está cadastrado na base de dados!");
            
            return Ok();
        }

        /// <summary>Cadastrar um prédio na base de dados.</summary>
        [HttpPost]
        public async Task<IActionResult> CadastrarPredio(int numeroIdentificador)
        {
            // Validar se prédio já existi.
            if(_predioService.ValidarPredioExiste(numeroIdentificador).Result)
                throw new IdentificationNumberInvalidException(numeroIdentificador);

            await _predioService.CadastrarPredioAsync(numeroIdentificador);         
            return Ok("Prédio cadastrado com sucesso!");
        }

        [HttpPut]
        public async Task<IActionResult> EditarPredio(int numeroIdentificador)
        { 
            // Validar se prédio já existi.
            if(_predioService.ValidarPredioExiste(numeroIdentificador).Result)
                await _predioService.EditarPredioAsync(numeroIdentificador);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarPredio(int numeroIdentificador)
        {
            // Validar se prédio já existi.
            if(_predioService.ValidarPredioExiste(numeroIdentificador).Result)
                await _predioService.ExcluirPredioAsync(numeroIdentificador);

            return Ok($"O prédio de número {numeroIdentificador} foi excluído da base de dados!");
        }
    }
}