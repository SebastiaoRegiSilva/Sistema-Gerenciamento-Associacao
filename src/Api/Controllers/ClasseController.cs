using System.Threading.Tasks;
using Disparo.Plataforma.Domain.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Disparo.Plataforma.Api.Controllers
{
    /// <summary>Controller que provê endpoints relacionados a entidade classe.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClasseController : Controller
    {
        /// <summary>Serviço que provê acesso aos dados e operações relaciondas as classes.</summary>
        private readonly ClasseService _classeService;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="classeService">Injeção de dependência do serviço que provê acesso aos dados e operações relacionadas as classes.</param>
        public ClasseController(ClasseService classeService)
        {
            _classeService = classeService;
        }

        [HttpGet("{habilitacao}")]
        public async Task<ActionResult<Classe>> BuscarClasseHabilitacaoAsync(string habilitacao)
        {
            var classeRecuperada = await _classeService.RecuperarClassePorHabilitacaoAsync(habilitacao);
            if (classeRecuperada == null)
                return Json($"A classe com esse nome {habilitacao} não existe na base de dados.");
            
            return Json(classeRecuperada);
        }

        /// <summary>Cadastrar classe.</summary>
        [HttpPost]
        public async Task<IActionResult> CadastrarClasseAsync(string habilitacao, int anoOC, string moduloSerie)
        {
            var classerecuperada = await _classeService.RecuperarClassePorHabilitacaoAsync(habilitacao);
            
            if(classerecuperada != null)
                return Json($"Já existe um classe cadastrada com a habilitação {habilitacao} no sistema!");
            else
            {
                await _classeService.CadastrarClasseAsync(habilitacao, anoOC, moduloSerie);        
                return Json("Classe cadastrada com sucesso!");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarClasseAsync(string habilitacao)
        {
            var classeRecuperada = await _classeService.RecuperarClassePorHabilitacaoAsync(habilitacao);
            if (classeRecuperada == null)
                return Json($"Classe com o nome {habilitacao} não existe na base de dados.");
            else
            {
                await _classeService.EditarClasseAsync(habilitacao);
                return Json("Classe editada com sucesso!");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarClasseAsync(string habilitacao)
        {
            var classeRecuperada = await _classeService.RecuperarClassePorHabilitacaoAsync(habilitacao);
            if (classeRecuperada == null)
                return Json($"Classe com o nome {habilitacao} não existe na base de dados.");
            else
            {
                await _classeService.ExcluirClasseAsync(habilitacao);
                return Json("Classe excluída com sucesso!");
            }
        }
    }
}