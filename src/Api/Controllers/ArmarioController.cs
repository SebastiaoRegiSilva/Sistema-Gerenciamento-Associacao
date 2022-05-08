using Disparo.Plataforma.Domain.Armarios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Disparo.Plataforma.Api.Controllers
{
    /// <summary>Controller que provê endpoints relacionados a entidade armário.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArmarioController : ControllerBase
    {
        /// <summary>Serviço que provê acesso aos dados e operações relaciondas aos armários.</summary>
        private readonly ArmarioService _armarioService;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="armarioService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas aos armários.</param>
        public ArmarioController(ArmarioService armarioService)
        {
            _armarioService = armarioService;
        }

        [HttpGet("{numeroIdentificador}")]
        public async Task<ActionResult<Armario>> BuscarArmarioNumeroAsync(int numeroIdentificador)
        {
            var armarioRecuperado = await _armarioService.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
            if (armarioRecuperado == null)
                return NotFound($"O armário com o número {numeroIdentificador} não existe na base de dados");
            
            return Ok(armarioRecuperado);
        }

        /// <summary>Cadastrar armário.</summary>
        [HttpPost]
        public async Task<IActionResult> CadastrarArmarioAsync(int numeroPredio, int numeroIdentificador, int anoValidade)
        {
            var armariorecuperada = await _armarioService.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
            
            if(armariorecuperada != null)
                return Ok($"Já existe um armário cadastrada com o número {numeroIdentificador} no sistema!");
            else
            {
                await _armarioService.CadastrarArmarioAsync(numeroPredio, numeroIdentificador, anoValidade);        
                return Ok("Armário cadastrado com sucesso!");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarArmarioAsync(int numeroIdentificador)
        {
            var armarioRecuperado = await _armarioService.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
            if (armarioRecuperado == null)
                return NotFound($"Armário com o número {numeroIdentificador} não existe na base de dados");
            else
            {
                await _armarioService.EditarArmarioAsync(numeroIdentificador);
                return Ok("Armário editada com sucesso!");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarArmarioAsync(int numeroIdentificador)
        {
            var armarioRecuperado = await _armarioService.RecuperarArmarioNumeroIdentificadorAsync(numeroIdentificador);
            if (armarioRecuperado == null)
                return NotFound($"Armário com o nome {numeroIdentificador} não existe na base de dados");
            else
            {
                await _armarioService.EditarArmarioAsync(numeroIdentificador);
                return Ok("Armário excluído com sucesso!");
            }
        }
    }
}