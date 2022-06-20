using Hort.Etec.Apm.Domain.Alunos;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hort.Etec.Apm.Infra.Alunos;
using System.Globalization;
using System.IO;
using System.Threading;

namespace DomainTests
{
    /// <summary>Classe de testes para o domínio de alunos.</summary>
    [TestClass]
    public class AlunoTests
    {
        /// <summary>Serviço que provê acesso aos dados e operações relacionadas aos alunos na plataforma.</summary>
        private static AlunoService _alunoService;

        /// <summary>Método de preparação para os testes.</summary>
        [ClassInitialize]
        public static void PrepareTestsData(TestContext context)
        {
            var ptBR = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = ptBR;
            Thread.CurrentThread.CurrentUICulture = ptBR;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            string conString = config.GetValue<string>("DB:MongoDB:ConString");
            string database = config.GetValue<string>("DB:MongoDB:Database");

            var alunoRepository = new AlunoRepository(conString, database);
            _alunoService = new AlunoService(alunoRepository);
        }
    }
}